﻿/****************************************************************************
* Copyright 2019 Xreal Techonology Limited. All rights reserved.
*                                                                                                                                                          
* This file is part of NRSDK.                                                                                                          
*                                                                                                                                                           
* https://www.xreal.com/        
* 
*****************************************************************************/

namespace NRKernal.NRExamples
{
    using UnityEngine;

    /// <summary> Uses 4 frame corner objects to visualize an TrackingImage. </summary>
    public class TrackingImageVisualizer : MonoBehaviour
    {
        /// <summary> The TrackingImage to visualize. </summary>
        public NRTrackableImage Image;

        /// <summary>
        /// A model for the lower left corner of the frame to place when an image is detected. </summary>
        public GameObject FrameLowerLeft;

        /// <summary>
        /// A model for the lower right corner of the frame to place when an image is detected. </summary>
        public GameObject FrameLowerRight;

        /// <summary>
        /// A model for the upper left corner of the frame to place when an image is detected. </summary>
        public GameObject FrameUpperLeft;

        /// <summary>
        /// A model for the upper right corner of the frame to place when an image is detected. </summary>
        public GameObject FrameUpperRight;

        /// <summary> The axis. </summary>
        public GameObject Joints;
        public GameObject JointsTransparent;

        /// <summary> Updates this object. </summary>
        public void Update()
        {
            if (Image == null || Image.GetTrackingState() != TrackingState.Tracking)
            {
                FrameLowerLeft.SetActive(false);
                FrameLowerRight.SetActive(false);
                FrameUpperLeft.SetActive(false);
                FrameUpperRight.SetActive(false);
                // Joints.SetActive(false);
                // JointsTransparent.SetActive(false);
                return;
            }

            float halfWidth = Image.ExtentX / 2;
            float halfHeight = Image.ExtentZ / 2;
            FrameLowerLeft.transform.localPosition = (halfWidth * Vector3.left) + (halfHeight * Vector3.back);
            FrameLowerRight.transform.localPosition = (halfWidth * Vector3.right) + (halfHeight * Vector3.back);
            FrameUpperLeft.transform.localPosition = (halfWidth * Vector3.left) + (halfHeight * Vector3.forward);
            FrameUpperRight.transform.localPosition = (halfWidth * Vector3.right) + (halfHeight * Vector3.forward);

            var center = Image.GetCenterPose();
            Vector3 offset = new Vector3(0, -0.05f, -0.1188f);
            transform.position = center.position;
            transform.rotation = center.rotation;
            Joints.transform.position = center.position + offset;
            Joints.transform.rotation = center.rotation;
            Joints.transform.RotateAround(center.position, center.up, 90);
            JointsTransparent.transform.position = center.position + offset;
            JointsTransparent.transform.rotation = center.rotation;
            JointsTransparent.transform.RotateAround(center.position, center.up, 90);
            FrameLowerLeft.SetActive(true);
            FrameLowerRight.SetActive(true);
            FrameUpperLeft.SetActive(true);
            FrameUpperRight.SetActive(true);
            
        }
    }
}