using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class Server : MonoBehaviour
{
    static public bool isConnectedToRobot = false;
    string RobotServerIP = "127.0.0.1";
    int RobotServerPort = 22000;
    Socket ClientSocket;
    EndPoint ServerEndPoint;
    string recvStr;
    string sendStr;
    byte[] recvData = new byte[10240];
    byte[] sendData = new byte[10240];
    int recvLen;
    public bool isRecvingMode = false;
    Thread SendThread;
    GameObject Joystick;
    // Start is called before the first frame update
    void Start()
    {
        Joystick = GameObject.Find("Canvas/Joystick");
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
        RobotController.runTraj = !isConnectedToRobot;
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
            Debug.Log(Encoding.Default.GetString(recvData));
            string[] data = Encoding.Default.GetString(recvData).Split(',');
            float[] tempAngle = new float[3];
            for(int i = 0; i < 3; i++)
            {
                tempAngle[i] = float.Parse(data[i]);
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
    public void SetRecvingMode(bool value)
    {
        Debug.Log(value);
        isRecvingMode = value;
        Joystick.SetActive(!isRecvingMode);
    }

    public void StartPlay()
    {
        if (isConnectedToRobot)
        {
            sendStr = "play" + ",end";
            sendData = Encoding.ASCII.GetBytes(sendStr);
            ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
        }
    }
    public void ResetPlay()
    {
        if (isConnectedToRobot)
        {
            sendStr = "stop" + ",end";
            sendData = Encoding.ASCII.GetBytes(sendStr);
            ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
        }
    }
    private void OnApplicationQuit()
    {
        if (SendThread != null)
            SendThread.Abort();
    }
}
