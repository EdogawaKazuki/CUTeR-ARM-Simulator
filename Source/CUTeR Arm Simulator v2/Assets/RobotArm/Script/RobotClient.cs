using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RobotClient : MonoBehaviour
{
    #region Variables
	// Hooks
    private RobotController _robotController;
	private TMP_InputField _robotIPIF;
	private TMP_InputField _robotPortIF;
	private Text _debugText;
	private TMP_Dropdown _filterDropdown;

	// Client Variables
	[SerializeField]
	private string _robotIP = "192.168.4.1";
	[SerializeField]
	private int _robotPort = 1234;

	// Robot Variables
	private List<int> _feedbackPwmList = new() { 0, 0, 0 };
	private List<int> _cmdPwmList = new() { 0, 0, 0 };
	private List<float> _angleListRead = new() { 0, 0, 0 };
	private bool _connected = false;
	private Thread _receiveThread;
	private bool _unlocked = true;
	private int windowSize = 5;
	private int filterIndex = 0;
	private List<Queue<float>> _filterQueue = new List<Queue<float>>() { new Queue<float>(), new Queue<float>(), new Queue<float>() };
	// Filter
	int count = 0;
	float tmp;
	float[] sum = { 0, 0, 0 };
	int frameIndex = 0;
	enum FilterType
	{
		NoFilter,
		MovingAverageFilter_size_1,
		MovingAverageFilter_size_3,
		MovingAverageFilter_size_5,
		MovingAverageFilter_size_7,
		MovingAverageFilter_size_10,
		ButterworthFilter_1st,
		ButterworthFilter_2ed,
	}
	
	private bool ESP32 = true;

	// Client Threads
	private Thread _clientThread;
	private Socket ClientSocket;
	private EndPoint ServerEndPoint;
	private List<int> robotJointPWM;
	private List<float> robotJointAngleCmd;
	private int recvLen = 0;
	private byte[] sendData;
	private byte[] recvData = new byte[2*3 + 4*3 + 2*3];
	private byte[] byteArray;
	public bool SendCmd = true;


	#endregion

	#region MonoBehaviour
	private void Start(){}
    private void OnEnable()
    {
		// Get hooks
        _robotController = GetComponent<RobotController>();
		_debugText = _robotController.GetRobotCanvas().transform.Find("DebugText")?.GetComponent<Text>();
		Transform robotSettingTransform = _robotController.GetRobotCanvas().transform.Find("RobotSettingPanel/Window/Robot");
		_robotIPIF = robotSettingTransform.Find("RobotServer/RobotIP/InputField (TMP)")?.GetComponent<TMP_InputField>();
		_robotPortIF = robotSettingTransform.Find("RobotServer/RobotPort/InputField (TMP)")?.GetComponent<TMP_InputField>();
		_filterDropdown = robotSettingTransform.Find("RobotServer/Filter/Dropdown")?.GetComponent<TMP_Dropdown>();


		// Set up UIs
		_robotIPIF.onValueChanged.AddListener((value) =>{ SetRobotIP(value); });
		_robotPortIF.onValueChanged.AddListener((value) => { SetRobotPort(value); });
		_filterDropdown.onValueChanged.AddListener((value) => { SetFilter(value); });
		
		_robotIPIF.text = PlayerPrefs.GetString("_robotIP", "localhost");
		_robotPortIF.text = PlayerPrefs.GetInt("_robotPort", 1234).ToString();
		//Time.fixedDeltaTime = 0.05f;
	}
    private void FixedUpdate()
	{
		ReceiveFromClient();
	}
    private void OnApplicationQuit()
	{
		SetConnect(false);
		if(_receiveThread != null)
			_receiveThread.Abort();
		if(_clientThread != null)
			_clientThread.Abort();
    }
    #endregion

    #region 
	// Tool Functions
	float[] CartesianToAngle(float x, float y, float z)
    {
        x = -x;
        y = -y;
        float[] angles = new float[3];
        float A1 = RobotController.A1; // 10.18f;
        float L1 = RobotController.L1; // 19.41f;
        float A2 = RobotController.A2; // 2.91f;
        float L1_star = Mathf.Sqrt(L1 * L1 + A2 * A2);
        float L2 = RobotController.L2; // 20.2f;
        float alpha = Mathf.Atan(A2 / L1);
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
        float B = z - A1;
        float tmp = (A * A + B * B - (L1_star * L1_star + L2 * L2)) / (2 * L1_star * L2);
        if (tmp < -1)
            tmp = -0.999999f;
        if (tmp > 1)
            tmp = 0.99999f;
        angles[2] = -Mathf.Acos(tmp);
        if ((A * (L1_star + L2 * Mathf.Cos(angles[2])) + B * L2 * Mathf.Sin(angles[2])) > 0)
            angles[1] = Mathf.Atan((B * (L1_star + L2 * Mathf.Cos(angles[2])) - A * L2 * Mathf.Sin(angles[2])) /
                                   (A * (L1_star + L2 * Mathf.Cos(angles[2])) + B * L2 * Mathf.Sin(angles[2])));
        else
            angles[1] = Mathf.PI - Mathf.Atan((B * (L1_star + L2 * Mathf.Cos(angles[2])) - A * L2 * Mathf.Sin(angles[2])) /
                                   -(A * (L1_star + L2 * Mathf.Cos(angles[2])) + B * L2 * Mathf.Sin(angles[2])));

        angles[0] = angles[0] / Mathf.PI * 180 - 90;
        angles[1] = (angles[1] + alpha) / Mathf.PI * 180;
        angles[2] = (angles[2] - alpha) / Mathf.PI * 180;
        return angles;
    }

	// Client Settings
    public void SetRobotIP(string value)
    {
        _robotIP = value;
		PlayerPrefs.SetString("_robotIP", _robotIP);
		PlayerPrefs.Save();
		// Debug.Log(value);
	}
    public void SetRobotPort(string value)
    {
        _robotPort = int.Parse(value);
		PlayerPrefs.SetInt("_robotPort", _robotPort);
		PlayerPrefs.Save();
		// Debug.Log(value);
	}
    public void SetConnect(bool value)
    {
        if (value)
		{
            try
            {
				Debug.Log("Connecting to " + _robotIP + ":" + _robotPort);
				ServerEndPoint = new IPEndPoint(IPAddress.Parse(_robotIP), _robotPort);
                ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
                {
                    SendTimeout = 1000,
                    ReceiveTimeout = 1000
                };
                _receiveThread = new Thread(new ThreadStart(ClientThread));
				_connected = true;
				_receiveThread.Start();

				byteArray = new byte[2];
				byteArray[0] = 0;
				byteArray[1] = 1;
				ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
			}
			catch (Exception ex)
			{
				_debugText.text =  ex.ToString() + "\n" + _debugText.text;
				print(ex);
			}
			//Connect();
		}
        else
		{
			_receiveThread.Abort();
			_connected = false;
			byteArray = new byte[2];
			byteArray[0] = 0;
			byteArray[1] = 0;
			ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
			//Disconnect();
		}
    }
	public bool IsConnected() { return _connected; }
	
	// Get Robot Status
	public List<int> GetFeedbackPWM() { return _feedbackPwmList; }
	public List<int> GetCmdPWM() { return _cmdPwmList; }

	// Client Functions
	void ReceiveFromClient(){
		if (!_connected) return;

		robotJointPWM = _robotController.GetSendPWM();
		robotJointAngleCmd = _robotController.GetCmdJointAngles();
		//SendMsg("post," + String.Join(",", robotJointAngles) + ",end");

		try
		{
			//Debug.Log("" + robotJointAngles[0] + "," + robotJointAngles[1] + "," + robotJointAngles[2]);

			if (_unlocked || !SendCmd)
			{
				if (_unlocked)
				{
					_robotController.SetCmdJointAngles(_angleListRead);
					_robotController.SetTransparentCmdJointAngles(_angleListRead);
				}
				
				
			}
			else if(SendCmd)
			{
				if (ESP32)
				{

					frameIndex = 0;
					byteArray = new byte[sizeof(float) * 3 + 1];
					byteArray[0] = 2;
					// Debug.Log(robotJointAngleCmd[0]);
					Buffer.BlockCopy(BitConverter.GetBytes(robotJointAngleCmd[0]), 0, byteArray, 1, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(robotJointAngleCmd[1]), 0, byteArray, 5, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(robotJointAngleCmd[2]), 0, byteArray, 9, 4);
					//sendData = Encoding.ASCII.GetBytes("angle," + String.Join(",", _robotController.GetJointAngles()));
					ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
				}
				else
				{
					sendData = Encoding.ASCII.GetBytes("post," + robotJointPWM[0] + "," + robotJointPWM[1] + "," + robotJointPWM[2] + ",end");
					ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
				}

				//_debugText.text = "angle," + String.Join(",", _robotController.GetJointAngles()) + ",end" + "\n" + _debugText.text;
			}
		}
		catch (Exception e)
		{
			Debug.Log(e.ToString());
			_debugText.text = e.ToString() + "\n" + _debugText.text;
		}
	}
	void ClientThread()
	{
		while (true)
        {

			try
			{
                if (_unlocked)
				{
					recvLen = ClientSocket.ReceiveFrom(recvData, ref ServerEndPoint);
					// Debug.Log(BitConverter.ToInt16(recvData, 4));
					ParsePWMByte(recvData);
					//ParsePWM(Encoding.ASCII.GetString(recvData));
				}
			}
			catch (Exception e)
			{
                if (_connected)
				{
					//sendData = Encoding.ASCII.GetBytes("connect");
					//ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
					//ClientSocket.Close();
					Debug.Log("Resend connecting request");
					byteArray = new byte[2];
					byteArray[0] = 0;
					byteArray[1] = 1;
					ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
				}
				Debug.Log(e);
			}
		}

    }
	private void ParsePWMByte(byte[] byteArray)
	{
		if (filterIndex == 1 && count <= windowSize)
		{
			count++;
		}
		for (int i = 0; i < 3; i++)
		{
			_feedbackPwmList[i] = BitConverter.ToInt16(byteArray, i * 2);
			//Debug.Log(BitConverter.ToInt16(byteArray, i * 2));
		}
		//Debug.Log(_feedbackPwmList[0] + " " + _feedbackPwmList[1] + " " + _feedbackPwmList[2] + " ");
		for (int i = 0; i < 3; i++)
		{
			tmp = BitConverter.ToSingle(byteArray, 3 * 2 + i * 4);
			if (filterIndex == 1)
			{
				if (count <= windowSize)
				{
					sum[i] += tmp;
					_filterQueue[i].Enqueue(tmp);
					_angleListRead[i] = sum[i] / count;
					//Debug.Log(tail[i].Count);
				}
                else
				{
					sum[i] += tmp;
					_filterQueue[i].Enqueue(tmp);
					sum[i] -= _filterQueue[i].Dequeue();
					//Debug.Log(tail[i].Count);
					_angleListRead[i] = sum[i] / windowSize;
				}
            }
            else if(filterIndex == 0 || filterIndex == 2)
			{
				_angleListRead[i] = tmp;
			}
			//Debug.Log(BitConverter.ToInt16(byteArray, 3 * 2 + i * 4));
		}
        //Debug.Log(" " + _angleListRead[0] + " " + _angleListRead[1] + " " + _angleListRead[2] + " ");
        if (SendCmd)
		{
			for (int i = 0; i < 3; i++)
			{
				_cmdPwmList[i] = BitConverter.ToInt16(byteArray, 3 * 2 + 3 * 4 + i * 2);
				//Debug.Log(BitConverter.ToInt16(byteArray, 3 * 2 + 3 * 4 + i * 2));
			}
			//Debug.Log(_cmdPwmList[0] + " " + _cmdPwmList[1] + " " + _cmdPwmList[2] + " ");
		}
	}
	private void ParsePWM(string str)
    {
        try
		{
			string[] vs = str.Split(',');
            if (ESP32)
			{
				for (int i = 0; i < 3; i++)
				{
					_feedbackPwmList[i - 0] = int.Parse(vs[i]);
				}
				for (int i = 3; i < 6; i++)
				{
					_angleListRead[i - 3] = float.Parse(vs[i]);
				}
            }
            else
			{
				for (int i = 1; i < 4; i++)
				{
					_feedbackPwmList[i - 1] = int.Parse(vs[i]);
				}
				for (int i = 4; i < 7; i++)
				{
					_angleListRead[i - 4] = float.Parse(vs[i]);
				}
			}
		}
		catch(Exception e)
        {
			Debug.Log(str);
			Debug.LogError(e);
        }
    }
	
	// Set Robot Status
	public void Unlock() { 
		_unlocked = true;
		//sendData = Encoding.ASCII.GetBytes("unlock,true,end");
		//ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
		byteArray = new byte[2];
		byteArray[0] = 1;
		byteArray[1] = 0;
		ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
	}
	public void Lock()
    {
		_unlocked = false;
		//sendData = Encoding.ASCII.GetBytes("unlock,false,end");
		//ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
		byteArray = new byte[2];
		byteArray[0] = 1;
		byteArray[1] = 1;
		ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
	}
	public void SendPWMCmd(int index, int pwm)
	{
		_cmdPwmList[index] = pwm;
		byteArray = new byte[sizeof(float) * 3 + 1];
		byteArray[0] = 3;
		Buffer.BlockCopy(BitConverter.GetBytes((float)_cmdPwmList[0]), 0, byteArray, 1, 4);
		Buffer.BlockCopy(BitConverter.GetBytes((float)_cmdPwmList[1]), 0, byteArray, 5, 4);
		Buffer.BlockCopy(BitConverter.GetBytes((float)_cmdPwmList[2]), 0, byteArray, 9, 4);
		//sendData = Encoding.ASCII.GetBytes("angle," + String.Join(",", _robotController.GetJointAngles()));
		ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
	}

	public void SetFilter(int value)
    {
		
		filterIndex = value;
		byteArray = new byte[2];
		byteArray[0] = 6;
		if (filterIndex == 0)
        {
			byteArray[1] = 0;

		}
		if(filterIndex == 1)
        {
			byteArray[1] = 0;
		}
		if(filterIndex == 2)
		{
			byteArray[1] = 1;
		}
		byteArray[0] = 6;
		if (_connected) ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
	}
	public void SetAverageWindowSize(float value)
	{
		if (filterIndex == 1)
		{
			windowSize = (int)value;
			count = 0;
			for (int i = 0; i < 3; i++)
			{
				sum[i] = 0;
				_filterQueue[i].Clear();
			}
		}
		if(filterIndex == 2)
		{
			byteArray = new byte[2];
			byteArray[0] = 6;
			byteArray[1] = (byte)value;
			if (_connected) ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
		}
	}
	

	// Send Calibration Data
	public void SetFeedBackCaliData(List<float> offset, List<float> scale)
	{
		byteArray = new byte[sizeof(float) * 6 + 1];
		byteArray[0] = 4;
		Buffer.BlockCopy(BitConverter.GetBytes(offset[0]), 0, byteArray, 1, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(offset[1]), 0, byteArray, 5, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(offset[2]), 0, byteArray, 9, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(scale[0]), 0, byteArray, 13, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(scale[1]), 0, byteArray, 17, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(scale[2]), 0, byteArray, 21, 4);
		//sendData = Encoding.ASCII.GetBytes("angle," + String.Join(",", _robotController.GetJointAngles()));
		ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
	}
	public void SetCmdCaliData(List<float> offset, List<float> scale)
	{
		byteArray = new byte[sizeof(float) * 6 + 1];
		byteArray[0] = 5;
		Buffer.BlockCopy(BitConverter.GetBytes(offset[0]), 0, byteArray, 1, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(offset[1]), 0, byteArray, 5, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(offset[2]), 0, byteArray, 9, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(scale[0]), 0, byteArray, 13, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(scale[1]), 0, byteArray, 17, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(scale[2]), 0, byteArray, 21, 4);
		//sendData = Encoding.ASCII.GetBytes("angle," + String.Join(",", _robotController.GetJointAngles()));
		ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
	}
	#endregion
}
