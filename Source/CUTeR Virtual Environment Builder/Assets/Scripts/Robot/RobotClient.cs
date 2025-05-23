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
    private RobotController _robotController;
	private InputField _robotIPIF;
	private InputField _robotPortIF;
	public Text _debugText;
	private Text _sliderText;
	private Slider _filterParamSlider;



	[SerializeField]
	private string _robotIP = "192.168.4.1";
	[SerializeField]
	private int _robotPort = 1234;

	private List<int> _feedbackPwmList = new List<int>() { 0, 0, 0 };
	private List<int> _cmdPwmList = new List<int>() { 0, 0, 0 };
	private List<float> _angleListRead = new List<float>() { 0, 0, 0 };

	private bool _connected = false;
	private bool _unlocked = true;
	private bool _isESP32 = true;
	private TcpClient _client;
	private Thread _clientThread;
	private Thread _receiveThread;
	List<int> robotJointPWM;
	List<float> robotJointAngleCmd;
	byte[] sendData;
	byte[] recvData = new byte[2*3 + 4*3 + 2*3];
	byte[] byteArray;
	int recvLen;

	public bool SendCmd = true;

	Socket ClientSocket;
	EndPoint ServerEndPoint;
	
	int windowSize = 5;
	int count = 0;
	float tmp;
	float[] sum = { 0, 0, 0 };
	List<Queue<float>> tail;
	int filterIndex = 0;
	// int frameIndex = 0;

	#endregion

	#region MonoBehaviour
	private void Start()
    {
		//_robotIP = PlayerPrefs.GetString("_robotIP");
		//_robotPort = PlayerPrefs.GetInt("_robotPort");
		//_robotIPIF.text = _robotIP;
		//_robotPortIF.text = _robotPort.ToString();
		//Connect();
		//Time.fixedDeltaTime = 0.05f;
		tail = new List<Queue<float>>() { new Queue<float>(), new Queue<float>(), new Queue<float>() };
	}
    private void OnEnable()
    {
        _robotController = GetComponent<RobotController>();
		_debugText = _robotController.GetRobotCanvas().transform.Find("DebugText").GetComponent<Text>();
		Transform robotSettingTransform = _robotController.GetRobotCanvas().transform.Find("RobotSettingPanel/Window/Robot");
		//_robotIPIF = robotSettingTransform.Find("RobotServer/RobotIP/InputField").GetComponent<InputField>();
		//_robotPortIF = robotSettingTransform.Find("RobotServer/RobotPort/InputField").GetComponent<InputField>();
		_sliderText = robotSettingTransform.Find("Filter/SliderText").GetComponent<Text>();
		_filterParamSlider = robotSettingTransform.Find("Filter/Slider").GetComponent<Slider>();
		//Time.fixedDeltaTime = 0.05f;
	}
    private void FixedUpdate()
	{
		if (_connected)
		{
			robotJointPWM = _robotController.GetSendPWM();
			//robotJointAngle = _robotController.GetJointAngles();
			robotJointAngleCmd = _robotController.GetCmdJointAngles();
			//SendMsg("post," + String.Join(",", robotJointAngles) + ",end");

			try
			{
				//Debug.Log("" + robotJointAngles[0] + "," + robotJointAngles[1] + "," + robotJointAngles[2]);


				if (_unlocked || !SendCmd)
				{
					if (_unlocked)
					{
						//_robotController.SetModelJointAngles(_angleListRead);
						for (int i = 0; i < 3; i++)
						{
							_robotController.GetJoystickController().SetAngleSliderValue(i, _angleListRead[i], false);
						}
					}
					
					
                }
                else if(SendCmd)
				{
					if (_isESP32)
					{

						// frameIndex = 0;
						byteArray = new byte[sizeof(float) * 3 + 1];
						byteArray[0] = 2;
						Debug.Log(robotJointAngleCmd[0]);
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
	}
    private void OnApplicationQuit()
	{
		if(_receiveThread != null)
			_receiveThread.Abort();
		if(_clientThread != null)
			_clientThread.Abort();
    }
    #endregion

    #region Methods
    public void SetRobotIP(string value)
    {
        _robotIP = value;
		PlayerPrefs.SetString("_robotIP", _robotIP);
		PlayerPrefs.Save();
		Debug.Log(value);
	}
    public void SetRobotPort(string value)
    {
        _robotPort = int.Parse(value);
		PlayerPrefs.SetInt("_robotPort", _robotPort);
		PlayerPrefs.Save();
		Debug.Log(value);
	}
    public void SetConnect(bool value)
    {
        if (value)
		{
            try
            {

				ServerEndPoint = new IPEndPoint(IPAddress.Parse(_robotIP), _robotPort);
				ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
				ClientSocket.SendTimeout = 1000;
				ClientSocket.ReceiveTimeout = 1000;
				_receiveThread = new Thread(new ThreadStart(ClientThread));
				_connected = true;
				_receiveThread.Start();
				//sendData = Encoding.ASCII.GetBytes("connect");
				//ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
				//byteArray = new byte[2];
				//byteArray[0] = 0;
				//byteArray[1] = 1;
				//ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
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
			//sendData = Encoding.ASCII.GetBytes("disconnect");
			//ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
			byteArray = new byte[2];
			byteArray[0] = 0;
			byteArray[1] = 0;
			ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
			//Disconnect();
		}
    }
	public bool IsConnected() { return _connected; }
	void ClientThread()
	{
		while (true)
        {

			try
			{
                if (_unlocked)
				{
					recvLen = ClientSocket.ReceiveFrom(recvData, ref ServerEndPoint);
					//Debug.Log(BitConverter.ToInt16(recvData, 4));
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
					tail[i].Enqueue(tmp);
					_angleListRead[i] = sum[i] / count;
					//Debug.Log(tail[i].Count);
				}
                else
				{
					sum[i] += tmp;
					tail[i].Enqueue(tmp);
					sum[i] -= tail[i].Dequeue();
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
            if (_isESP32)
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
	public List<int> GetFeedbackPWM() { return _feedbackPwmList; }
	public List<int> GetCmdPWM() { return _cmdPwmList; }
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
	public bool IsUnLocked()
    {
		return _unlocked;
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
	private void SetFilterContent(bool interactable, int minValue = 1, int maxValue = 10, int defaultValue = 1)
	{
		_filterParamSlider.interactable = interactable;
        if (_filterParamSlider.interactable)
        {
			_filterParamSlider.minValue = minValue;
			_filterParamSlider.maxValue = maxValue;
			_filterParamSlider.value = defaultValue;
        }
	}
	public void SetFilter(int value)
    {
		filterIndex = value;
		byteArray = new byte[2];
		byteArray[0] = 6;
		if (filterIndex == 0)
        {
			SetFilterContent(false);
			byteArray[1] = 0;

		}
		if(filterIndex == 1)
        {
			SetFilterContent(true, 1, 10, 5);
			byteArray[1] = 0;
		}
		if(filterIndex == 2)
		{
			SetFilterContent(true, 1, 2, 1);
			byteArray[1] = 1;
		}
		byteArray[0] = 6;
		if (_connected) ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
	}
	public void SetAverageWindowSize(float value)
	{
		_sliderText.text = value.ToString();
		if (filterIndex == 1)
		{
			windowSize = (int)value;
			count = 0;
			for (int i = 0; i < 3; i++)
			{
				sum[i] = 0;
				tail[i].Clear();
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
	#endregion
}
