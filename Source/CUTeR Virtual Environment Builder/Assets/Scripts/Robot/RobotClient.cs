using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class RobotClient : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private RobotController _robotController;
    [SerializeField]
    private string _robotIP = "192.168.2.53";
    [SerializeField]
    private int _robotPort = 22000;
	[SerializeField]
	private InputField _robotIPIF;
	[SerializeField]
	private InputField _robotPortIF;


	private List<int> _pwmList = new List<int>() { 0, 0, 0 };
	private List<float> _angleList = new List<float>() { 0, 0, 0 };

	private bool _connected = false;
	private bool _unlocked = true;
	private TcpClient _client;
	private Thread _clientThread;
	private Thread _sendThread;

	Socket ClientSocket;
	EndPoint ServerEndPoint;

	#endregion

	#region MonoBehaviour
	private void Start()
    {
		_robotIP = PlayerPrefs.GetString("_robotIP");
		_robotPort = PlayerPrefs.GetInt("_robotPort");
		_robotIPIF.text = _robotIP;
		_robotPortIF.text = _robotPort.ToString();
		//Connect();
	}
    private void FixedUpdate()
	{
		if (_connected)
		{
			List<int> robotJointPWM = _robotController.GetSendPWM();
			//SendMsg("post," + String.Join(",", robotJointAngles) + ",end");

			try
			{
				//Debug.Log("" + robotJointAngles[0] + "," + robotJointAngles[1] + "," + robotJointAngles[2]);
				byte[] sendData;
				
				if(_unlocked)
					sendData = Encoding.ASCII.GetBytes("unlock,end");
				else
					sendData = Encoding.ASCII.GetBytes("post," + robotJointPWM[0] + "," + robotJointPWM[1] + "," + robotJointPWM[2] + ",end");

				ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);

				if (_unlocked)
				{
					for (int i = 0; i < 3; i++)
					{
						_robotController.GetJoystickController().SetAngleSliderValue(i, _angleList[i]);
					}
				}
			}
			catch (Exception e)
			{
				Debug.Log(e.ToString());
			}
		}
	}
    private void OnApplicationQuit()
	{
		if(_sendThread != null)
			_sendThread.Abort();
		if(_clientThread != null)
			_clientThread.Abort();
		Disconnect();
    }
    #endregion

    #region Methods
    public void SetRobotIP(string value)
    {
        _robotIP = value;
		PlayerPrefs.SetString("_robotIP", _robotIP);
		PlayerPrefs.Save();
	}
    public void SetRobotPort(string value)
    {
        _robotPort = int.Parse(value);
		PlayerPrefs.SetInt("_robotPort", _robotPort);
		PlayerPrefs.Save();
	}
    public void SetConnect(bool value)
    {
        if (value)
		{
			ServerEndPoint = new IPEndPoint(IPAddress.Parse(_robotIP), _robotPort);
			ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			ClientSocket.SendTimeout = 1000;
			ClientSocket.ReceiveTimeout = 1000;
			_sendThread = new Thread(new ThreadStart(ClientThread));
			_connected = true;
			_sendThread.Start();
			//Connect();
        }
        else
		{
			_sendThread.Abort();
			_connected = false;
			//Disconnect();
        }
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
				//Debug.Log(serverMessage);
				ParsePWM(serverMessage);
			}
			catch (Exception e)
			{
				Debug.Log(e);
			}
		}

    }

	/// <summary> 	
	/// Setup socket connection. 	
	/// </summary> 	
	private void Connect()
    {
        try
        {
            _client = new TcpClient(_robotIP, _robotPort);
            _clientThread = new Thread(new ThreadStart(ListenForData));
            _clientThread.IsBackground = true;
            _clientThread.Start();
            _connected = true;
        }
        catch (Exception e)
        {
            Debug.Log("On client connect exception " + e);
        }
    }

    /// <summary>
    /// Disconnect with the server
    /// </summary>
    private void Disconnect()
	{
		/*
        if (_connected)
		{
			SendMsg("bye");
			_client.Close();
		}
		_connected = false;
		_client = null;
		*/
	}

	/// <summary> 	
	/// Runs in background clientReceiveThread; Listens for incomming data. 	
	/// </summary>     
	private void ListenForData()
	{
		try
		{
			Byte[] bytes = new Byte[1024];
			while (true)
			{
				// Get a stream object for reading 				
				using (NetworkStream stream = _client.GetStream())
				{
					int length;
					// Read incomming stream into byte arrary. 					
					while ((length = stream.Read(bytes, 0, bytes.Length)) != 0)
					{
						var incommingData = new byte[length];
						Array.Copy(bytes, 0, incommingData, 0, length);
						// Convert byte array to string message. 						
						string serverMessage = Encoding.ASCII.GetString(incommingData);
						//Debug.Log("server message received as: " + serverMessage);
						ParsePWM(serverMessage);
					}
				}
			}
		}
		catch (SocketException socketException)
		{
			Debug.Log("Socket exception: " + socketException);
		}
	}
	/// <summary> 	
	/// Send message to server using socket connection. 	
	/// </summary> 	
	private void SendMsg(string clientMessage)
	{
		if (_client == null)
		{
			return;
		}
		try
		{
			// Get a stream object for writing. 			
			NetworkStream stream = _client.GetStream();
			if (stream.CanWrite)
			{
				// Convert string message to byte array.                 
				byte[] clientMessageAsByteArray = Encoding.ASCII.GetBytes(clientMessage);
				// Write byte array to socketConnection stream.                 
				stream.Write(clientMessageAsByteArray, 0, clientMessageAsByteArray.Length);
				//Debug.Log("Client sent his message - should be received by server");
			}
		}
		catch (SocketException socketException)
		{
			Debug.Log("Socket exception: " + socketException);
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
    private void ParsePWM(string str)
    {
        try
        {
			string[] vs = str.Split(',');
			for (int i = 1; i < 4; i++)
			{
				_pwmList[i - 1] = int.Parse(vs[i]);
			}
			for (int i = 4; i < 7; i++)
			{
				_angleList[i - 4] = float.Parse(vs[i]);
			}
		}
		catch(Exception e)
        {
			Debug.Log(str);
			Debug.LogError(e);
        }
    }
	public List<int> GetReadPWM() { return _pwmList; }
	public void Unlock() { 
		_unlocked = true; 
	}
	public void Lock()
    {
		_unlocked = false;
    }
	public bool IsUnLocked()
    {
		return _unlocked;
    }
	#endregion
}
