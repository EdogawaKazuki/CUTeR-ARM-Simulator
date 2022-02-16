using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class SceneServer : MonoBehaviour
{
    int port = 2301;
    Socket serverSocket; 
    IPEndPoint ipEnd; //侦听端口

    Thread serverThread; 
    Dictionary<Socket, Thread> clientSocketDict;

    void HandleConnection(Socket socket)
    {
        // reply connect
        IPEndPoint ipEndClient = (IPEndPoint)socket.RemoteEndPoint;
        Debug.Log("Connect with " + ipEndClient.Address.ToString() + ":" + ipEndClient.Port.ToString());
        SocketSend(socket, "Connected to " + ObjectManager.ipAddress);
        socket.ReceiveTimeout = 1000;
        socket.SendTimeout = 1000;

        // waiting for msg
        while (true)
        {
            byte[] recvData = new byte[65535];
            int recvLen = socket.Receive(recvData);
            string recvStr = Encoding.ASCII.GetString(recvData, 0, recvLen);
            Debug.Log(recvStr);
            if (recvStr.Equals("startSync"))
            {
                Debug.Log("Start Sync...");
                SocketSend(socket, "obj");
                socket.Receive(recvData);
                if (Directory.Exists(ObjectManager.ObjectFolder))
                {
                    Debug.Log("Obj folder exists");
                    foreach (string file in Directory.GetFiles(ObjectManager.ObjectFolder))
                    {
                        //Debug.Log(file);
                        if (file.Contains(".meta"))
                        {
                            continue;
                        }
                        byte[] bs = File.ReadAllBytes(file);
                        Debug.Log("sending file: " + file);
                        SocketSend(socket, "file");
                        recvLen = socket.Receive(recvData);
                        SocketSend(socket, file.Split('\\')[1] + ";" + bs.Length);
                        recvLen = socket.Receive(recvData);
                        SocketSend(socket, bs);
                        recvLen = socket.Receive(recvData);
                        recvStr = Encoding.ASCII.GetString(recvData, 0, recvLen);
                        Debug.Log(recvStr);
                    }
                }
                SocketSend(socket, "scene");
                recvLen = socket.Receive(recvData);
                if (Directory.Exists(ObjectManager.SceneFolder))
                {
                    Debug.Log("Scene folder exists");
                    foreach (string file in Directory.GetFiles(ObjectManager.SceneFolder))
                    {
                        //Debug.Log(file);
                        if (file.Contains(".meta"))
                        {
                            continue;
                        }
                        byte[] bs = File.ReadAllBytes(file);
                        Debug.Log("sending file: " + file);
                        SocketSend(socket, "file");
                        recvLen = socket.Receive(recvData);
                        SocketSend(socket, file.Split('\\')[1] + ";" + bs.Length);
                        recvLen = socket.Receive(recvData);
                        SocketSend(socket, bs);
                        recvLen = socket.Receive(recvData);
                        recvStr = Encoding.ASCII.GetString(recvData, 0, recvLen);
                        Debug.Log(recvStr);
                    }
                }
                SocketSend(socket, "bye");
            }
            if (recvLen == 0)
            {
                Debug.Log("Disconnect with " + ipEndClient.Address.ToString() + ":" + ipEndClient.Port.ToString());
                clientSocketDict.Remove(socket);
                socket.Close();
                break;
            }
        }
    }
    void SocketSend(Socket socket, string sendStr)
    {
        byte[] sendData = Encoding.ASCII.GetBytes(sendStr);
        SocketSend(socket, sendData);
    }
    void SocketSend(Socket socket, byte[] bs)
    {
        socket.Send(bs, bs.Length, SocketFlags.None);
    }
    void StartListening()
    {
        while (true)
        {
            print("Ready to connect");
            Socket clientSocket = serverSocket.Accept();
            print("New connection request");
            Thread newThread = new Thread(new ThreadStart(() => HandleConnection(clientSocket)));
            newThread.Start();
            print("Start connection Thread: " + clientSocket);
            clientSocketDict.Add(clientSocket, newThread);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        // init socket
        ipEnd = new IPEndPoint(IPAddress.Any, port);
        serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        serverSocket.Bind(ipEnd);
        serverSocket.Listen(10);

        // init thread dict
        clientSocketDict = new Dictionary<Socket, Thread>();
        
        // new thread for recving connection
        serverThread = new Thread(new ThreadStart(StartListening));
        try
        {
            serverThread.Start();
            ObjectManager.serverStatus = "Started";
            ObjectManager.InformationText.text = "Scene: " + ObjectManager.GameAdmin.GetComponent<SceneManager>().SceneName + ". IP: " + ObjectManager.ipAddress + " Server " + ObjectManager.serverStatus;
        }
        catch(Exception e)
        {
            ObjectManager.DebugMsg.text += e;
            Debug.LogError(e);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    void OnApplicationQuit()
    {
        if (clientSocketDict != null)
            foreach (var kv in clientSocketDict)
            {
                // close connection
                kv.Key.Shutdown(SocketShutdown.Both);
                kv.Key.Close();
                // end thread
                kv.Value.Interrupt();
                kv.Value.Abort();
                Debug.Log("Closeing " + kv.Key);
            }
        // close server
        if (serverSocket != null)
        {
            serverSocket.Close();
            Debug.Log("Closeing " + serverSocket);
        }
        // end server thread
        if (serverThread != null)
        {
            serverThread.Interrupt();
            serverThread.Abort();
        }
    }
}
