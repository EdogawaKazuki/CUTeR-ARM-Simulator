#!/usr/bin/env bash
set -euo pipefail

# Local Ubuntu/Linux Editor workaround for Meta XR Core SDK 201.0.0.
#
# This patches:
#   Library/PackageCache/com.meta.xr.sdk.core@201.0.0/Editor/OVRProjectConfig.cs
#
# It does NOT patch tracked project code. The patch can be lost whenever Unity
# regenerates Library/PackageCache, so rerun this script after package refreshes.
#
# Usage:
#   ./tools/patch-meta-xr-ovrprojectconfig-linux.sh
#   ./tools/patch-meta-xr-ovrprojectconfig-linux.sh "Source/CUTeR Arm Simulator v2"
#   ./tools/patch-meta-xr-ovrprojectconfig-linux.sh "/absolute/path/to/OVRProjectConfig.cs"

PACKAGE_VERSION="${META_XR_CORE_VERSION:-201.0.0}"
RELATIVE_FILE="Library/PackageCache/com.meta.xr.sdk.core@${PACKAGE_VERSION}/Editor/OVRProjectConfig.cs"

usage() {
  cat <<EOF
Usage:
  $0 [UNITY_PROJECT_ROOT_OR_OVRPROJECTCONFIG_FILE]

Examples:
  $0
  $0 "Source/CUTeR Arm Simulator v2"
  $0 "/home/user/project/Library/PackageCache/com.meta.xr.sdk.core@201.0.0/Editor/OVRProjectConfig.cs"

Environment:
  META_XR_CORE_VERSION=201.0.0   Override the Meta XR Core package version.
EOF
}

if [[ "${1:-}" == "-h" || "${1:-}" == "--help" ]]; then
  usage
  exit 0
fi

if [[ $# -gt 1 ]]; then
  usage >&2
  exit 2
fi

if ! command -v python3 >/dev/null 2>&1; then
  echo "ERROR: python3 is required." >&2
  exit 1
fi

repo_root="$(git rev-parse --show-toplevel 2>/dev/null || pwd)"
input="${1:-}"
target=""

find_candidates_in() {
  local root="$1"
  find "$root" -path "*/$RELATIVE_FILE" -type f 2>/dev/null | sort
}

if [[ -n "$input" ]]; then
  if [[ -f "$input" ]]; then
    target="$(realpath "$input")"
  elif [[ -d "$input" ]]; then
    if [[ -f "$input/$RELATIVE_FILE" ]]; then
      target="$(realpath "$input/$RELATIVE_FILE")"
    else
      mapfile -t candidates < <(find_candidates_in "$input")
      if [[ "${#candidates[@]}" -eq 1 ]]; then
        target="$(realpath "${candidates[0]}")"
      elif [[ "${#candidates[@]}" -gt 1 ]]; then
        echo "ERROR: Found multiple OVRProjectConfig.cs candidates under: $input" >&2
        printf '  %s\n' "${candidates[@]}" >&2
        echo "Pass the exact Unity project root or exact OVRProjectConfig.cs path." >&2
        exit 1
      else
        echo "ERROR: Could not find $RELATIVE_FILE under: $input" >&2
        echo "Open the Unity project once so Package Manager creates Library/PackageCache, then rerun." >&2
        exit 1
      fi
    fi
  else
    echo "ERROR: Path does not exist: $input" >&2
    exit 1
  fi
else
  mapfile -t candidates < <(find_candidates_in "$repo_root")

  if [[ "${#candidates[@]}" -eq 0 && "$repo_root" != "$PWD" ]]; then
    mapfile -t candidates < <(find_candidates_in "$PWD")
  fi

  if [[ "${#candidates[@]}" -eq 0 ]]; then
    echo "ERROR: Could not find $RELATIVE_FILE under: $repo_root" >&2
    echo "Open the Unity project once so Package Manager creates Library/PackageCache, then rerun." >&2
    exit 1
  fi

  if [[ "${#candidates[@]}" -eq 1 ]]; then
    target="$(realpath "${candidates[0]}")"
  else
    preferred=()
    for candidate in "${candidates[@]}"; do
      if [[ "$candidate" == *"/Source/CUTeR Arm Simulator v2/$RELATIVE_FILE" ]]; then
        preferred+=("$candidate")
      fi
    done

    if [[ "${#preferred[@]}" -eq 1 ]]; then
      target="$(realpath "${preferred[0]}")"
    else
      echo "ERROR: Found multiple OVRProjectConfig.cs candidates:" >&2
      printf '  %s\n' "${candidates[@]}" >&2
      echo "Pass the Unity project root explicitly, for example:" >&2
      echo "  $0 \"Source/CUTeR Arm Simulator v2\"" >&2
      exit 1
    fi
  fi
fi

if [[ "$(basename "$target")" != "OVRProjectConfig.cs" ]]; then
  echo "ERROR: Target is not OVRProjectConfig.cs: $target" >&2
  exit 1
fi

project_root="${target%/$RELATIVE_FILE}"

if [[ "$project_root" == "$target" ]]; then
  echo "ERROR: Could not infer Unity project root from target:" >&2
  echo "  $target" >&2
  exit 1
fi

echo "Unity project root:"
echo "  $project_root"
echo "Target file:"
echo "  $target"
echo

# Remove stale same-directory backups from earlier manual patch attempts.
# Leaving backup files inside PackageCache can produce Unity warnings such as:
# "Asset Packages/com.meta.xr.sdk.core/... has no meta file, but it's in an immutable folder."
stale_count=0
while IFS= read -r -d '' stale_file; do
  rm -f "$stale_file"
  stale_count=$((stale_count + 1))
done < <(find "$(dirname "$target")" -maxdepth 1 -type f -name 'OVRProjectConfig.cs.bak*' -print0 2>/dev/null)

if [[ "$stale_count" -gt 0 ]]; then
  echo "Removed $stale_count stale same-directory backup file(s)."
  echo
fi

export TARGET_OVR_PROJECT_CONFIG="$target"
export UNITY_PROJECT_ROOT="$project_root"

python3 <<'PY'
from pathlib import Path
from datetime import datetime
import os
import re
import sys

target = Path(os.environ["TARGET_OVR_PROJECT_CONFIG"])
project_root = Path(os.environ["UNITY_PROJECT_ROOT"])

text = target.read_text()
original_text = text

block_re = re.compile(
    r"public\s+static\s+int\[\]\s+horizonOsSdkVersions\s*=\s*Enumerable\.Range\(.*?\.ToArray\(\);",
    re.S,
)

match = block_re.search(text)

if not match:
    idx = text.find("horizonOsSdkVersions")
    if idx >= 0:
        start = max(0, idx - 400)
        end = min(len(text), idx + 900)
        print("Found 'horizonOsSdkVersions', but not in the expected format.")
        print("Context:")
        print(text[start:end])
    else:
        print("Could not find 'horizonOsSdkVersions' in target file.")
    sys.exit(1)

block = match.group(0)
patched = block

# Expected original:
#   Enumerable.Range(minSdkVersion, currentSdkVersion - minSdkVersion + 1)
patched = re.sub(
    r"Enumerable\.Range\(\s*minSdkVersion\s*,\s*currentSdkVersion\s*-\s*minSdkVersion\s*\+\s*1\s*\)",
    "Enumerable.Range(minSdkVersion, System.Math.Max(1, currentSdkVersion - minSdkVersion + 1))",
    patched,
    count=1,
)

# Expected original:
#   Enumerable.Range(version2Start, currentSdkVersion - version2Start + 1)
patched = re.sub(
    r"Enumerable\.Range\(\s*version2Start\s*,\s*currentSdkVersion\s*-\s*version2Start\s*\+\s*1\s*\)",
    "Enumerable.Range(version2Start, System.Math.Max(1, currentSdkVersion - version2Start + 1))",
    patched,
    count=1,
)

# Repair a previous accidental local patch where the Concat range used minSdkVersion
# instead of version2Start.
patched = re.sub(
    r"\.Concat\(\s*Enumerable\.Range\(\s*minSdkVersion\s*,\s*System\.Math\.Max\(\s*1\s*,\s*currentSdkVersion\s*-\s*minSdkVersion\s*\+\s*1\s*\)\s*\)\s*\)",
    ".Concat(Enumerable.Range(version2Start, System.Math.Max(1, currentSdkVersion - version2Start + 1)))",
    patched,
    count=1,
)

patched = re.sub(
    r"\.Concat\(\s*Enumerable\.Range\(\s*minSdkVersion\s*,\s*currentSdkVersion\s*-\s*minSdkVersion\s*\+\s*1\s*\)\s*\)",
    ".Concat(Enumerable.Range(version2Start, System.Math.Max(1, currentSdkVersion - version2Start + 1)))",
    patched,
    count=1,
)

wanted_1 = "Enumerable.Range(minSdkVersion, System.Math.Max(1, currentSdkVersion - minSdkVersion + 1))"
wanted_2 = "Enumerable.Range(version2Start, System.Math.Max(1, currentSdkVersion - version2Start + 1))"

if wanted_1 in patched and wanted_2 in patched and patched == block:
    print("Already patched. No changes made.")
    sys.exit(0)

if wanted_1 not in patched or wanted_2 not in patched:
    print("ERROR: The horizonOsSdkVersions block did not match the expected patch shape.")
    print()
    print("Current block:")
    print(block)
    print()
    print("Attempted patched block:")
    print(patched)
    sys.exit(1)

new_text = text[:match.start()] + patched + text[match.end():]

backup_dir = project_root / "Temp" / "MetaXRLinuxPatchBackups"
backup_dir.mkdir(parents=True, exist_ok=True)

timestamp = datetime.now().strftime("%Y%m%d-%H%M%S")
backup_path = backup_dir / f"OVRProjectConfig.cs.{timestamp}.bak"
backup_path.write_text(original_text)

target.write_text(new_text)

print("Patched OVRProjectConfig.cs successfully.")
print(f"Backup written outside PackageCache:")
print(f"  {backup_path}")
print()
print("Patched horizonOsSdkVersions block:")
print(patched)
PY

echo
echo "Done."
echo "Reopen Unity after this patch. If Unity regenerates Library/PackageCache, rerun this script."
