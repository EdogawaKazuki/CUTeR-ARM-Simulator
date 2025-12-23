using UnityEngine;
using UnityEditor;

public static class LessonEditorStyles
{
    // User toggle for dark mode (defaults to follow Unity skin)
    public static bool UserDarkMode
    {
        get => EditorPrefs.GetBool("LessonEditorStyles_UserDarkMode", EditorGUIUtility.isProSkin);
        set => EditorPrefs.SetBool("LessonEditorStyles_UserDarkMode", value);
    }

    // Colors for light and dark schemes
    public static readonly Color DarkPanelBG = new Color(0.18f, 0.21f, 0.25f);
    public static readonly Color LightPanelBG = new Color(0.93f, 0.94f, 0.96f);
    public static readonly Color DarkAccent = new Color(0.21f, 0.74f, 1.00f);
    public static readonly Color LightAccent = new Color(0.14f, 0.44f, 0.76f);
    public static readonly Color DarkWarning = new Color(1f, 0.8f, 0.3f);
    public static readonly Color LightWarning = new Color(1f, 0.7f, 0.18f);

    // Getters for current mode
    public static Color PanelBG => UserDarkMode ? DarkPanelBG : LightPanelBG;
    public static Color Accent => UserDarkMode ? DarkAccent : LightAccent;
    public static Color Warning => UserDarkMode ? DarkWarning : LightWarning;

    // Cached window background texture for overall bg
    private static Texture2D _windowBGTex;
    private static bool _lastDarkMode = false;

    public static Texture2D WindowBGTex
    {
        get
        {
            if (_windowBGTex == null || _lastDarkMode != UserDarkMode)
            {
                _windowBGTex = MakeTex(2, 2, PanelBG);
                _lastDarkMode = UserDarkMode;
            }
            return _windowBGTex;
        }
    }

    // Styles (regenerate when mode changes)
    private static GUIStyle _headerLabel, _sectionLabel, _stepBox, _subStepBox, _timelineBox;
    private static bool _stylesDirty = true;

    public static GUIStyle HeaderLabel
    {
        get { CheckDirty(); return _headerLabel; }
    }
    public static GUIStyle SectionLabel
    {
        get { CheckDirty(); return _sectionLabel; }
    }
    public static GUIStyle StepBox
    {
        get { CheckDirty(); return _stepBox; }
    }
    public static GUIStyle SubStepBox
    {
        get { CheckDirty(); return _subStepBox; }
    }
    public static GUIStyle TimelineBox
    {
        get { CheckDirty(); return _timelineBox; }
    }

    // Call after toggle to rebuild styles
    public static void MarkStylesDirty()
    {
        _stylesDirty = true;
    }

    private static void CheckDirty()
    {
        if (_stylesDirty || _lastDarkMode != UserDarkMode)
        {
            GenerateStyles();
            _stylesDirty = false;
        }
    }

    private static void GenerateStyles()
    {
        _headerLabel = new GUIStyle(EditorStyles.boldLabel)
        {
            fontSize = 18,
            fontStyle = FontStyle.Bold,
            alignment = TextAnchor.MiddleLeft,
            normal = { textColor = Accent }
        };

        _sectionLabel = new GUIStyle(EditorStyles.label)
        {
            fontSize = 14,
            fontStyle = FontStyle.Italic,
            alignment = TextAnchor.MiddleLeft,
            normal = { textColor = Accent }
        };

        _stepBox = new GUIStyle(GUI.skin.box)
        {
            fontSize = 12,
            fontStyle = FontStyle.Normal,
            padding = new RectOffset(12, 12, 8, 8),
            margin = new RectOffset(8, 8, 8, 8),
            normal = { background = MakeTex(16, 16, PanelBG) }
        };

        _subStepBox = new GUIStyle(GUI.skin.box)
        {
            fontSize = 11,
            fontStyle = FontStyle.Italic,
            padding = new RectOffset(8, 8, 5, 5),
            margin = new RectOffset(14, 14, 6, 6),
            normal = { background = MakeTex(16, 16, Color.Lerp(PanelBG, UserDarkMode ? Color.white : Color.black, 0.08f)) }
        };

        _timelineBox = new GUIStyle(GUI.skin.box)
        {
            fontSize = 13,
            fontStyle = FontStyle.Bold,
            padding = new RectOffset(16, 16, 10, 10),
            margin = new RectOffset(8, 8, 8, 8),
            normal = { background = MakeTex(16, 16, Color.Lerp(PanelBG, Accent, 0.07f)) }
        };
    }

    // Utility: Make a solid color texture for backgrounds
    private static Texture2D MakeTex(int width, int height, Color col)
    {
        Color[] pix = new Color[width * height];
        for (int i = 0; i < pix.Length; ++i) pix[i] = col;
        Texture2D result = new Texture2D(width, height);
        result.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
        result.SetPixels(pix);
        result.Apply();
        return result;
    }
}