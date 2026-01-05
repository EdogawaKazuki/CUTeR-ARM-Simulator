using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.FullSerializer;
using System.Threading.Tasks;

public class SpatialAnchorManager : MonoBehaviour
{
    public const string numUuidsPlayerPref = "numUuids";
    public Transform anchorPrefab;
    private List<OVRSpatialAnchor> anchors = new List<OVRSpatialAnchor>();
    private OVRSpatialAnchor lastCreatedAnchor;
    public TMP_Text uuidText;
    public TMP_Text savedStatusText;
    private WorldFrameSynchronizer worldFrameSynchronizer;


    private void Start()
    {
        worldFrameSynchronizer = this.GetComponent<WorldFrameSynchronizer>();
        // PlayerPrefs.DeleteAll();
    }

    private async void Awake()
    {
        await LoadAnchorsFromPlayerPrefs();
        Debug.Log("Loaded anchors from PlayerPrefs. Total anchors: " + anchors.Count);
        if (anchors.Count > 0)
        {
            lastCreatedAnchor = anchors[anchors.Count - 1];
            uuidText = lastCreatedAnchor.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>();
            savedStatusText = lastCreatedAnchor.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>();
            worldFrameSynchronizer.SynchAnchorToJoints(lastCreatedAnchor.gameObject);
        }
    }

    async Task LoadAnchorsFromPlayerPrefs()
    {
        for(int i = 0; i < anchors.Count; i++)
        {
            Destroy(anchors[i].gameObject);
        }
        anchors.Clear();
        int playerNumUuids = PlayerPrefs.GetInt(numUuidsPlayerPref);
        if (playerNumUuids == 0) return;

        List<Guid> uuids = new List<Guid>();
        for(int i = 0; i < playerNumUuids; i++)
        {
            string uuidKey = "uuid" + i;
            string currentUuid = PlayerPrefs.GetString(uuidKey);
            Guid currentGuid = new Guid(currentUuid);
            uuids.Add(currentGuid);
        }
        List<OVRSpatialAnchor.UnboundAnchor> _unboundAnchors = new();
        var result = await OVRSpatialAnchor.LoadUnboundAnchorsAsync(uuids, _unboundAnchors);
        if(result.Success){
            foreach(var unboundAnchor in _unboundAnchors)
            {
                await unboundAnchor.LocalizeAsync();

                GameObject anchor = Instantiate(anchorPrefab.gameObject, OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch), OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch));
                worldFrameSynchronizer.ComputeOrientation(anchor);
                anchor.AddComponent<OVRSpatialAnchor>();
                uuidText = anchor.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>();
                savedStatusText = anchor.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>();
                unboundAnchor.BindTo(anchor.GetComponent<OVRSpatialAnchor>());
                uuidText.text = unboundAnchor.Uuid.ToString();
                savedStatusText.text = "Loaded";

                anchors.Add(anchor.GetComponent<OVRSpatialAnchor>());
            }
        }
        
    }

    public OVRSpatialAnchor GetlastAnchor()
    {
        return lastCreatedAnchor;
    }

    public void Update()
    {
        // if(OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        // {
        //     PlaceAnchor();
        // }
        // if(OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch))
        // {
        //     SaveLastCreatedAnchor();
        // }
        // if(OVRInput.GetDown(OVRInput.Button.Two, OVRInput.Controller.RTouch))
        // {
        //     EraseLastCreatedAnchor();
        // }
    }
    public async Task PlaceAnchor()
    {
        GameObject anchor = Instantiate(anchorPrefab.gameObject, OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch), OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch));
        worldFrameSynchronizer.ComputeOrientation(anchor);

        anchor.AddComponent<OVRSpatialAnchor>();
        uuidText = anchor.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>();
        savedStatusText = anchor.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>();

        await CreateAnchor(anchor.GetComponent<OVRSpatialAnchor>());
    }
    public async Task CreateAnchor(OVRSpatialAnchor anchor)
    {
        while(!anchor.Created && !anchor.Localized)
        {
            await Task.Yield();
        }
        Guid anchorGuid = anchor.Uuid;
        anchors.Add(anchor);
        lastCreatedAnchor = anchor;

        uuidText.text = anchorGuid.ToString();
        savedStatusText.text = "Not saved";
    }

    public async void SaveLastCreatedAnchor(){
        if(lastCreatedAnchor != null)
        {
            OVRResult<OVRAnchor.SaveResult> result = await lastCreatedAnchor.SaveAnchorAsync();
            if(result.Status == OVRAnchor.SaveResult.Success)
            {
                savedStatusText.text = "Saved";
                SaveUuidToPlayerPrefs(lastCreatedAnchor.Uuid);
            }
            else
            {
                savedStatusText.text = "Failed to save";
            }
        }
    }
    public async Task EraseLastCreatedAnchor(){
        if(lastCreatedAnchor != null)
        {
            OVRResult<OVRAnchor.EraseResult> result = await lastCreatedAnchor.EraseAnchorAsync();
            if(result.Status == OVRAnchor.EraseResult.Success)
            {
                savedStatusText.text = "Erased";
            }
            else
            {
                savedStatusText.text = "Failed to erase";
            }
            anchors.Remove(lastCreatedAnchor);
            DeleteUuidFromPlayerPrefs(lastCreatedAnchor.Uuid);
            Destroy(lastCreatedAnchor.gameObject);
            lastCreatedAnchor = null;
            
        }
    }
    void SaveUuidToPlayerPrefs(Guid uuid){
        if (!PlayerPrefs.HasKey(numUuidsPlayerPref))
        {
            PlayerPrefs.SetInt(numUuidsPlayerPref, 0);
        }
     
        int playerNumUuids = PlayerPrefs.GetInt(numUuidsPlayerPref);
        PlayerPrefs.SetString("uuid" + playerNumUuids, uuid.ToString());
        PlayerPrefs.SetInt(numUuidsPlayerPref, ++playerNumUuids);
    }

    void DeleteUuidFromPlayerPrefs(Guid uuid){
        if (!PlayerPrefs.HasKey(numUuidsPlayerPref))
        {
            return;
        }
     
        int playerNumUuids = PlayerPrefs.GetInt(numUuidsPlayerPref);
        for(int i = 0; i < playerNumUuids; i++)
        {
            string uuidKey = "uuid" + i;
            string currentUuid = PlayerPrefs.GetString(uuidKey);
            if(currentUuid == uuid.ToString())
            {
                // Shift all subsequent UUIDs down by one
                for(int j = i; j < playerNumUuids - 1; j++)
                {
                    string nextUuidKey = "uuid" + (j + 1);
                    string nextUuid = PlayerPrefs.GetString(nextUuidKey);
                    PlayerPrefs.SetString("uuid" + j, nextUuid);
                }
                PlayerPrefs.DeleteKey("uuid" + (playerNumUuids - 1));
                PlayerPrefs.SetInt(numUuidsPlayerPref, --playerNumUuids);
                break;
            }
        }
    }
    
}