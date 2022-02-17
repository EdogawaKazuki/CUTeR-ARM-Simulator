using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class RobotClient : MonoBehaviour
{
    public string RobotServerIP = "127.0.0.1";
    public int RobotServerPort = 22000;
    Socket ClientSocket;
    EndPoint ServerEndPoint;
    string recvStr;
    string sendStr;
    byte[] recvData = new byte[10240];
    byte[] sendData = new byte[10240];
    int recvLen;
    static public bool isRecvingMode = false;
    static public bool isConnectedToRobot = false;
    Thread SendThread;

    GameObject Joystick;

    RobotController Robot;
    // Start is called before the first frame update
    void Start()
    {
        Joystick = GameObject.Find("Canvas/Joystick");
        Robot = GameObject.Find("GameAdmin").GetComponent<RobotController>();
        // init socket
        ServerEndPoint = new IPEndPoint(IPAddress.Parse(RobotServerIP), RobotServerPort);
        ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        ClientSocket.SendTimeout = 1000;
        ClientSocket.ReceiveTimeout = 1000;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void SetRobotIP(string value)
    {
        RobotServerIP = value;
    }
    public void SetRobotPort(string value)
    {
        RobotServerPort = int.Parse(value);
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
            if (data[0].Equals("fire"))
            {
                RobotController.Grabber.Toggle();
                RobotController.Launcher.Toggle();
                tempAngle = new float[] { float.Parse(data[1]), float.Parse(data[2]), float.Parse(data[3]) };
            }
            else
            {
                tempAngle = new float[] { float.Parse(data[0]), float.Parse(data[1]), float.Parse(data[2]) };
            }
            for(int i = 0; i < 3; i++)
            {
                RobotController.JointAngle[i] = tempAngle[i];
            }
        }
        catch(Exception e)
        {
            Debug.LogError(e);
            return;
        }
    }
    public void SetRecvingMode(bool value)
    {
        Debug.Log(value);
        isRecvingMode = value;
    }

    public void StartPlay()
    {
        sendStr = "play" + ",end";
        sendData = Encoding.ASCII.GetBytes(sendStr);
        ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
    }
    public void ResetPlay()
    {
        sendStr = "stop" + ",end";
        sendData = Encoding.ASCII.GetBytes(sendStr);
        ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
    }
    private void OnApplicationQuit()
    {
        if (SendThread != null)
            SendThread.Abort();
    }
}
