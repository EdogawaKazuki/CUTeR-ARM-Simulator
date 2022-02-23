using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class RobotClient : MonoBehaviour
{
    public string RobotServerIP = "127.0.0.1";
    public int RobotServerPort = 22000;
    Socket ClientSocket;
    EndPoint ServerEndPoint;
    string sendStr;
    byte[] recvData = new byte[10240];
    byte[] sendData = new byte[10240];
    static public bool isRecvingMode = false;
    static public bool isConnectedToRobot = false;
    Thread SendThread;
    bool isFinished = false;
    bool isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        // init socket
        ServerEndPoint = new IPEndPoint(IPAddress.Parse(RobotServerIP), RobotServerPort);
        ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        ClientSocket.SendTimeout = 1000;
        ClientSocket.ReceiveTimeout = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFinished)
        {
            ObjectManager.TrajectoryStatus.text = "Finised";
            ObjectManager.TrajectoryBG.color = new Color32(255, 255, 255, 78);
        }
    }
    public void SetRobotIP(string value)
    {
        RobotServerIP = value;
        ServerEndPoint = new IPEndPoint(IPAddress.Parse(RobotServerIP), RobotServerPort);
    }
    public void SetRobotPort(string value)
    {
        RobotServerPort = int.Parse(value);
        ServerEndPoint = new IPEndPoint(IPAddress.Parse(RobotServerIP), RobotServerPort);
    }
    public void SetConnect(bool value)
    {
        if (value)
        {
            // start client socket
            SendThread = new Thread(new ThreadStart(ClientThread));
            SendThread.Start();
            isConnectedToRobot = true;
        }
        else
        {
            SendThread.Abort();
            isConnectedToRobot = false;
        }
    }
    void ClientThread()
    {
        while (true)
        {
            if (isConnectedToRobot)
            {
                if (isRecvingMode)
                {
                    ReceiveFromRealRobot();
                }
                else
                {
                    UpdateRealRobot();
                }
            }
            
        }
    }
    void UpdateRealRobot()
    {
        try
        {
            Debug.Log("" + RobotController.JointAngle[0] + "," + RobotController.JointAngle[1] + "," + RobotController.JointAngle[2]);
            /*
            realAngle[0] = (Robot.angle[0] - offset[0]) / scale[0];
            realAngle[1] = 180 - (angle[1] - offset[1]) / scale[1];
            realAngle[2] = (Robot.angle[2] - offset[2]) / scale[2];
            */
            sendStr = "post," + RobotController.JointAngle[0] + "," + RobotController.JointAngle[1] + "," + RobotController.JointAngle[2] + ",end";
            sendData = Encoding.ASCII.GetBytes(sendStr);
            ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
            Debug.Log("send to " + RobotServerIP + ":" + RobotServerPort + ". Data: " + sendStr);
            Thread.Sleep(10);
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }
    }
    void ReceiveFromRealRobot()
    {
        try
        {
            recvData = new byte[65000];
            sendStr = "get" + ",end";
            sendData = Encoding.ASCII.GetBytes(sendStr);
            ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
            int recvLen = ClientSocket.ReceiveFrom(recvData, ref ServerEndPoint);
            //Debug.Log(Encoding.Default.GetString(recvData));
            string[] data = Encoding.Default.GetString(recvData).Split(',');
            float[] tempAngle;
            if (data[0].Equals("point"))
            {
                tempAngle = CartesianToAngle(float.Parse(data[1]), float.Parse(data[2]), float.Parse(data[3]));
                if (data[1].Equals("fire"))
                {
                    RobotController.Grabber.Toggle();
                    RobotController.Launcher.Toggle();
                    tempAngle = new float[] { float.Parse(data[2]), float.Parse(data[3]), float.Parse(data[4]) };
                }
            }
            else if (data[0].Equals("fire"))
            {
                RobotController.Grabber.Toggle();
                RobotController.Launcher.Toggle();
                tempAngle = new float[] { float.Parse(data[1]), float.Parse(data[2]), float.Parse(data[3]) };
            }
            else if (data[0].Equals("end"))
            {

                sendStr = "post," + RobotController.JointAngle[0] + "," + RobotController.JointAngle[1] + "," + RobotController.JointAngle[2] + ",end";
                sendData = Encoding.ASCII.GetBytes(sendStr);
                ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
                tempAngle = RobotController.JointAngle;
                isPlaying = false;
                isFinished = true;
            }
            else
            {
                isFinished = false;
                tempAngle = new float[] { float.Parse(data[0]), float.Parse(data[1]), float.Parse(data[2]) };
            }
            Debug.Log(Encoding.Default.GetString(recvData));
            Debug.Log(tempAngle[0] + "," + tempAngle[1] + "," + tempAngle[2]);
            for(int i = 0; i < 3; i++)
            {
                RobotController.JointAngle[i] = tempAngle[i];
            }
            Thread.Sleep(10);
        }
        catch(Exception e)
        {
            Debug.LogError(e);
            return;
        }
    }
    float[] CartesianToAngle(float x, float y, float z)
    {
        x = -x;
        y = -y;
        float[] angles = new float[3];
        float l1 = 10.18f;
        float l2 = 19.41f;
        float l3 = 2.91f;
        float l23 = Mathf.Sqrt(l2 * l2 + l3 * l3);
        float l4 = 20.2f;
        float alpha = Mathf.Atan(l3 / l2);
        if (x == 0)
        {
            angles[0] = Mathf.PI / 2;
        }
        else
        {
            if (x > 0)
            {
                angles[0] = Mathf.Atan(-y / x);
            }
            else
            {
                angles[0] = Mathf.PI - Mathf.Atan(y / x);
            }
        }
        float A = -y * Mathf.Sin(angles[0]) + x * Mathf.Cos(angles[0]);
        float B = z - l1;
        float tmp = (A * A + B * B - (l23 * l23 + l4 * l4)) / (2 * l23 * l4);
        if (tmp < -1)
            tmp = -0.999999f;
        if (tmp > 1)
            tmp = 0.99999f;
        angles[2] = -Mathf.Acos(tmp);
        if ((A * (l23 + l4 * Mathf.Cos(angles[2])) + B * l4 * Mathf.Sin(angles[2])) > 0)
            angles[1] = Mathf.Atan((B * (l23 + l4 * Mathf.Cos(angles[2])) - A * l4 * Mathf.Sin(angles[2])) /
                                   (A * (l23 + l4 * Mathf.Cos(angles[2])) + B * l4 * Mathf.Sin(angles[2])));
        else
            angles[1] = Mathf.PI - Mathf.Atan((B * (l23 + l4 * Mathf.Cos(angles[2])) - A * l4 * Mathf.Sin(angles[2])) /
                                   -(A * (l23 + l4 * Mathf.Cos(angles[2])) + B * l4 * Mathf.Sin(angles[2])));

        angles[0] = angles[0] / Mathf.PI * 180 - 90;
        angles[1] = (angles[1] + alpha) / Mathf.PI * 180;
        angles[2] = (angles[2] - alpha) / Mathf.PI * 180;
        return angles;
    }
    public void SetRecvingMode(bool value)
    {
        isRecvingMode = value;
        for (int i = 0; i < 3; i++)
            RobotController.Sliders[i].interactable = !value;
        if (isRecvingMode)
        {
            ObjectManager.TrajectoryStatus.text = "Ready to play";
            ObjectManager.TrajectoryBG.color = new Color32(255, 255, 255, 78);
        }
        else
        {
            ObjectManager.TrajectoryStatus.text = "No Trajectory";
            ObjectManager.TrajectoryBG.color = new Color32(255, 255, 255, 78);
        }
            

    }

    public void StartPlay()
    {
        if (isRecvingMode && isConnectedToRobot)
        {
            if (!isPlaying)
            {
                isPlaying = true;
                sendStr = "play" + ",end";
                sendData = Encoding.ASCII.GetBytes(sendStr);
                ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
                isFinished = false;
                ObjectManager.TrajectoryStatus.text = "Playing";
                ObjectManager.TrajectoryBG.color = new Color32(100, 255, 100, 160);
            }
            else
            {
                isPlaying = false;
                sendStr = "pause" + ",end";
                sendData = Encoding.ASCII.GetBytes(sendStr);
                ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
                isFinished = false;
                ObjectManager.TrajectoryStatus.text = "Pause";
                ObjectManager.TrajectoryBG.color = new Color32(255, 255, 100, 160);
            }
        }
    }
    public void ResetPlay()
    {
        if (isRecvingMode && isConnectedToRobot)
        {
            isPlaying = false;
            sendStr = "stop," + RobotController.JointAngle[0] + "," + RobotController.JointAngle[1] + "," + RobotController.JointAngle[2] + ",end";
            sendData = Encoding.ASCII.GetBytes(sendStr);
            ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
            isFinished = false;
            ObjectManager.TrajectoryStatus.text = "Ready to play";
            ObjectManager.TrajectoryBG.color = new Color32(255, 255, 255, 78);
        }
    }
    private void OnApplicationQuit()
    {
        if (SendThread != null)
        {
            SendThread.Interrupt();
            SendThread.Abort();
        }
    }
}
