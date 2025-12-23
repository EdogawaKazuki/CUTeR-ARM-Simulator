// using UnityEngine;
// using PassthroughCameraSamples;
// public class CameraAnchor : MonoBehaviour
// {
//     [SerializeField] private GameObject _cameraAnchor;
//     [SerializeField] private WebCamTextureManager _webCamTextureManager;
//     private PassthroughCameraEye _passthroughCameraEye;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//         _passthroughCameraEye = _webCamTextureManager.Eye;
//     }

//     public void updateCameraAnchor()
//     {
//         var headPose = OVRPlugin.GetNodePoseStateImmediate(OVRPlugin.Node.Head).Pose.ToOVRPose();
//         var cameraPose = PassthroughCameraUtils.GetCameraPoseInWorld(_passthroughCameraEye);
//         _cameraAnchor.transform.position = cameraPose.position;
//         _cameraAnchor.transform.rotation = cameraPose.rotation;
//     }

//     // Update is called once per frame
//     void Update()
//     {

//     }
// }
