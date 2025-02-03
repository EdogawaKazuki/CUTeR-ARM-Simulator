using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Net;
using System;

public class TestingScript : MonoBehaviour
{
    [SerializeField]
    private string _robotIP = "192.168.2.124";
    [SerializeField]
    private int _robotPort = 1234;
    Socket ClientSocket;
    EndPoint ServerEndPoint;
    float joint0 = 90;
    float joint1 = 90;
    float joint2 = 90;
    private Thread _clientThread;
    // Start is called before the first frame update
    void Start()
    {
        ServerEndPoint = new IPEndPoint(IPAddress.Parse(_robotIP), _robotPort);
        ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        ClientSocket.SendTimeout = 1000;
        ClientSocket.ReceiveTimeout = 1000;
        _clientThread = new Thread(new ThreadStart(ClientThread));
        _clientThread.Start();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    }
    public void SetAngle0(float angle)
    {
        joint0 = angle;
        byte[] sendData = Encoding.ASCII.GetBytes("angle," + joint0 + "," + joint1 + "," + joint2);
        ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
    }
    public void SetAngle1(float angle)
    {
        joint1 = angle;
        byte[] sendData = Encoding.ASCII.GetBytes("angle," + joint0 + "," + joint1 + "," + joint2);
        ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
    }
    public void SetAngle2(float angle)
    {
        joint2 = angle;
        byte[] sendData = Encoding.ASCII.GetBytes("angle," + joint0 + "," + joint1 + "," + joint2);
        ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
    }
    public void ToggleLock(bool value)
    {
        byte[] sendData = Encoding.ASCII.GetBytes("lock," + (value?"true":"false"));
        ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
    }
    void ClientThread()
    {
        while (true)
        {

            try
            {
                byte[] recvData = new byte[1000];
                int recvLen = ClientSocket.ReceiveFrom(recvData, ref ServerEndPoint);
                string serverMessage = Encoding.ASCII.GetString(recvData);
                Debug.Log(serverMessage);
            }
            catch (Exception e)
            {
                Debug.Log(e);
            }
        }

    }
    private void OnApplicationQuit()
    {
        if (_clientThread != null)
            _clientThread.Abort();
    }
}
