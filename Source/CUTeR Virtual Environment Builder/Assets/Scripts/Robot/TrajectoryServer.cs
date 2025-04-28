using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class TrajectoryServer : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private int port = 5000;
    private UdpClient udpServer;
    private bool isRunning = false;
    private IPEndPoint remoteEndPoint;
    private RobotController _robotController;
    private InputField _trajectoryPortIF;
    private Toggle _serverModeToggle;
    private float[] angles = new float[3];
    #endregion

    #region MonoBehaviour   
    void Start()
    {
    }

    private void OnEnable()
    {
        _robotController = GetComponent<RobotController>();
        Transform robotServerSettingTransform = _robotController.GetRobotCanvas().transform.Find("RobotSettingPanel/Window/Robot/RobotServer");
        _trajectoryPortIF = robotServerSettingTransform.Find("ServerMode/InputField").GetComponent<InputField>();
        _trajectoryPortIF.onValueChanged.AddListener(SetPort);
        _trajectoryPortIF.text = port.ToString();

        _serverModeToggle = robotServerSettingTransform.Find("ServerMode/Toggle").GetComponent<Toggle>();
        _serverModeToggle.onValueChanged.AddListener(SetServer);
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < 3; i++)
        {
            _robotController.GetJoystickController().SetAngleSliderValue(i, angles[i], false);
        }
    }
    void OnDestroy()
    {
    }
    private void OnApplicationQuit()
    {
        StopServer();
    }
    #endregion

    #region Methods
    public void SetPort(string value)
    {
        port = int.Parse(value);
    }   
    public void SetServer(bool value)
    {
        if (value)
        {
            StartServer();
        }
        else
        {
            StopServer();
        }   
    }   
    public void StartServer()
    {
        try
        {
            udpServer = new UdpClient(port);
            remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
            isRunning = true;
            Debug.Log($"UDP Server started on port {port}");
            
            // Start receiving data asynchronously
            udpServer.BeginReceive(ReceiveCallback, null);
        }
        catch (Exception e)
        {
            Debug.LogError($"Failed to start UDP server: {e.Message}");
        }
    }

    private void ReceiveCallback(IAsyncResult ar)
    {
        try
        {
            if (!isRunning) return;

            byte[] receivedBytes = udpServer.EndReceive(ar, ref remoteEndPoint);
            string receivedMessage = Encoding.ASCII.GetString(receivedBytes);
            
            // Debug.Log($"Received from {remoteEndPoint}: {receivedMessage}");
            
            // Process the received command here
            ProcessCommand(receivedMessage);

            // Continue receiving
            udpServer.BeginReceive(ReceiveCallback, null);
        }
        catch (Exception e)
        {
            Debug.LogError($"Error receiving data: {e.Message}");
        }
    }

    private void ProcessCommand(string command)
    {
        // Add your command processing logic here
        string[] commandParts = command.Split(',');
        for (int i = 0; i < 3; i++)
        {
            angles[i] = float.Parse(commandParts[i]);
        }
        Debug.Log($"Processing command: {command}");
    }

    public void StopServer()
    {
        if (udpServer != null)
        {
            isRunning = false;
            udpServer.Close();
            Debug.Log("UDP Server stopped");
        }
    }

    public void SetPort(int newPort)
    {
        if (isRunning)
        {
            StopServer();
        }
        port = newPort;
        StartServer();
    }
    #endregion  
}
