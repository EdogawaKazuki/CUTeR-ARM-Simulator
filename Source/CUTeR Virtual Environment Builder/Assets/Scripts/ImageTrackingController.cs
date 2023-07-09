namespace NRKernal.NRExamples
{
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    /// <summary> Controller for TrackingImage example. </summary>
    [HelpURL("https://developer.nreal.ai/develop/unity/image-tracking")]
    public class ImageTrackingController : MonoBehaviour
    {

        /// <summary> The temporary tracking images. </summary>
        private List<NRTrackableImage> m_TempTrackingImages = new List<NRTrackableImage>();

        /// <summary>
        /// AR Object
        /// </summary>
        public GameObject Cube;

        public Text DebugText;

        List<NRTrackableImage> m_Images = new List<NRTrackableImage>();
        string text = "";
        /// <summary> Updates this object. </summary>
        public void Update()
        {
            text = "";
            text += Application.persistentDataPath + "/Resources/objects" + "\n";
            DebugText.text = text;
            // Get updated augmented images for this frame.
            NRFrame.GetTrackables<NRTrackableImage>(m_TempTrackingImages, NRTrackableQueryFilter.New);

            // Create visualizers and anchors for updated augmented images that are tracking and do not previously
            // have a visualizer. Remove visualizers for stopped images.
            foreach (var image in m_TempTrackingImages)
            {
                Cube.SetActive(true);
                Cube.transform.position = image.GetCenterPose().position;
                Cube.transform.rotation = image.GetCenterPose().rotation;
                m_Images.Add(image);
                if (image.GetTrackingState() != TrackingState.Stopped)
                {
                    NRDebugger.Info("Create new TrackingImageVisualizer!");
                    // Create an anchor to ensure that NRSDK keeps tracking this augmented image.
                    
                }
            }
            foreach(NRTrackableImage image in m_Images)
            {
                text += image.GetTrackableType() + "," + image.GetTrackingState() + "," + image.GetDataBaseIndex() + "," + image.GetCenterPose().position + ";\n";
                if(image.GetTrackingState() == TrackingState.Tracking)
                {
                    Cube.transform.position = image.GetCenterPose().position;
                    Cube.transform.rotation = image.GetCenterPose().rotation;

                }
                DebugText.text = text;
            }
        }

    }
}
