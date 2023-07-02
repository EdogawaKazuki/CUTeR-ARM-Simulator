using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenCvSharp;
using System.Threading.Tasks;
using OpenCvSharp.Aruco;
using System;
using UnityEngine.UI;

public class ImageTracker : MonoBehaviour
{
    public GameObject CameraContainer;
    public Camera ARCamera;
    public RawImage OutputImage;
    public Transform ArucoIndicator;
    private WebCamTexture webcamTexture = null;
    private Texture2D renderedTexture = null;
    
    Mat cameraMatrix = new Mat(3, 3, MatType.CV_64FC1, new double[] { 710.6095021898424, 0.0, 316.60453569562026, 0.0, 710.7115564393268, 255.1462556783168, 0.0, 0.0, 1.0 });
    Mat distCoeffs = new Mat(1, 5, MatType.CV_64FC1, new double[] { 0.05282949016850485, 0.4931362059400071, -0.0001368901900445027, 0.002526697725007028, -0.9633706183460452 });
    Vector3 cameraPosition;
    Quaternion cameraRotation;
    //public Text webcamName;
    private void Start()
    {
        WebCamDevice device = WebCamTexture.devices[1];
        //webcamName.text = device.name;
        webcamTexture = new WebCamTexture(device.name);
        if (webcamTexture != null)
        {
            webcamTexture.Play();
        }
        else
        {
            Debug.Log("no device");
        }
        renderedTexture = new Texture2D(webcamTexture.width, webcamTexture.height, TextureFormat.BGRA32, false);

    }
    private void Update()
    {
        if (webcamTexture != null && webcamTexture.didUpdateThisFrame)
        {
            processFrame(webcamTexture);
        }
    }
    private void OnDestroy()
    {
        if (webcamTexture != null)
        {
            if (webcamTexture.isPlaying)
            {
                webcamTexture.Stop();
            }
            webcamTexture = null;
        }
    }
    public void UpdateRobotPosition()
    {

        ARCamera.transform.localPosition = cameraPosition;
        CameraContainer.transform.localRotation = cameraRotation;
        CameraContainer.transform.Rotate(new Vector3(-90, 0, 0), Space.World);
    }
    private void processFrame(WebCamTexture inputTexture)
    {
        /*int height = webcamTexture.height;
        int width = webcamTexture.width;
        Vec3b[] data = new Vec3b[height * width];
        Parallel.For(0, height, i => {
            for (var j = 0; j < width; j++) {
                int index = j + i * width;
                data[j + i * width] = new Vec3b (0,0,255);
            }
        });
        Mat img = new Mat(webcamTexture.height, webcamTexture.width, MatType.CV_8UC3, data);
        Mat img = Cv2.ImRead("./Lenna.jpg", ImreadModes.Color);
        */
        Mat img = null;
        TextureToMat(webcamTexture, ref img);

        Mat imgDistorted = new Mat();
        //Cv2.CvtColor(img, img, 23);
        //Cv2.MedianBlur(img, imgBlur, 23);
        //Create??????
        DetectorParameters parameters = new DetectorParameters();
        parameters.AdaptiveThreshWinSizeMax = 50;
        parameters.PolygonalApproxAccuracyRate = 0.05f;

        //定????字典
        /*
         此?定?的???字典要与生成Aruco??定?的字典相同
         */
        Dictionary dictionary = CvAruco.GetPredefinedDictionary(PredefinedDictionaryName.Dict4X4_1000);

        /*
         corners：??到的??角向量
         points:包含那些?部代??有正确??的方?的imgpoint。有用用于??目的。
         */
        Point2f[][] corners, points;

        //??到的??的??符向量
        int[] ids;

        /*
         ?行?片??
         */
        var rvec = new Mat();
        var tvec = new Mat();
        try
        {
            CvAruco.DetectMarkers(img, dictionary, out corners, out ids, parameters, out points);
            CvAruco.EstimatePoseSingleMarkers(corners, 0.1f, cameraMatrix, distCoeffs, rvec, tvec);
            //Cv2.DrawFrameAxes(img, cameraMatrix, distCoeffs, rvec, tvec, 0.1f);
            //Debug.Log(rvec);

            //Debug.Log((float)rvec.At<Vec4d>(0)[0] + " " + (float)rvec.At<Vec4d>(0)[1] + " " + (float)rvec.At<Vec4d>(0)[2] + " " + (float)rvec.At<Vec4d>(0)[3] + " " + (float)rvec.At<Vec4d>(2)[1] + " " + (float)rvec.At<Vec3d>(3)[2]);

            /*
            String str = "";
            for (int i = 0; i < ids.Length; i++)
                str += "ids" + i + ": " + ids[i];
            Debug.Log(str);  
            */
            if (ids.Length > 0 && ids[0] == 871)
            {
                var pos = new Vector3((float)tvec.At<Vec3d>(0)[0], (float)tvec.At<Vec3d>(0)[1], (float)tvec.At<Vec3d>(0)[2]);
                cameraPosition = (Vector3.zero - pos) * 100;
                Vector3 m = new Vector3((float)rvec.At<Vec4d>(0)[0], (float)rvec.At<Vec4d>(0)[1], (float)rvec.At<Vec4d>(0)[2]);
                float theta = (float)(Math.Sqrt(m.x * m.x + m.y * m.y + m.z * m.z) * 180 / Math.PI);
                Vector3 axis = new Vector3(m.x, m.y, m.z);
                //Quaternion rotation = Quaternion.Inverse(Quaternion.AngleAxis(theta, axis));
                var rot = Quaternion.AngleAxis(theta, axis);
                cameraRotation = Quaternion.Inverse(rot);
                //Quaternion rotation = new Quaternion(rvec.At<float>(0, 0), rvec.At<float>(0, 1), rvec.At<float>(0, 2), rvec.At<float>(0, 3));
                //Quaternion rotation = new Quaternion();
                ArucoIndicator.SetPositionAndRotation(pos, rot);
                //Camera.main.transform.SetPositionAndRotation(position, rotation);
                //ARCamera.transform.localPosition = position;
                //CameraContainer.transform.localRotation = rotation;
                //CameraContainer.transform.Rotate(new Vector3(-90, 0, 0), Space.World);
                //Camera.main.transform.
            }
        }
        catch (Exception e)
        {
            Debug.LogWarning(e);
        }

        Cv2.Undistort(img, imgDistorted, cameraMatrix, distCoeffs);
        MatToTexture(imgDistorted, ref renderedTexture);
        OutputImage.texture = renderedTexture;

    }

    private void TextureToMat(WebCamTexture input, ref Mat output)
    {
        int height = input.height;
        int width = input.width;
        Color32[] c = input.GetPixels32();
        Vec3b[] data = new Vec3b[height * width];
        Parallel.For(0, height, i => {
            for (var j = 0; j < width; j++)
            {
                int index = j + i * width;
                data[index] = new Vec3b(c[index].b, c[index].g, c[index].r);
            }
        });
        output = new Mat(input.height, input.width, MatType.CV_8UC3, data);
    }
    private void MatToTexture(Mat input, ref Texture2D output)
    {
        int height = input.Height;
        int width = input.Width;
        Vec3b[] data = new Vec3b[height * width];
        input.GetArray(out data);
        Color32[] c = new Color32[height * width];
        Parallel.For(0, height, i => {
            for (var j = 0; j < width; j++)
            {
                int index = j + i * width;
                var color32 = new Color32
                {
                    b = data[index][0],
                    g = data[index][1],
                    r = data[index][2],
                    a = 255
                };
                c[j + i * width] = color32;
            }
        });

        output.SetPixels32(c);
        output.Apply();

    }
}
