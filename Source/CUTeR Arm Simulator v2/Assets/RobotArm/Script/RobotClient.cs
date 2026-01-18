using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.ConstrainedExecution;

public class RobotClient : MonoBehaviour
{
	#region Variables
	// Hooks
	private RobotController _robotController;
	private RobotControllerUI _robotControllerUI;
	private TMP_InputField _robotIPIF;
	private TMP_InputField _robotPortIF;
	private Text _debugText;
	private TMP_Dropdown _filterDropdown;
	private Transform _robotSettingTransform;

	// Client Variables
	[SerializeField]
	private string _robotIP = "127.0.0.1";
	[SerializeField]
	private int _robotPort = 1234;

	// Robot Variables
	private List<int> _feedbackPwmList = new() { 0, 0, 0, 0, 0, 0 };
	private List<int> _cmdPwmList = new() { 0, 0, 0, 0, 0, 0};
	private List<float> _angleListRead = new() { 0, 0, 0, 0, 0, 0 };
	private bool _connected = false;
	private Thread _receiveThread;
	private bool _unlocked = true;
	private int windowSize = 5;
	public enum FilterType
	{
		NoFilter,
		MovingAverageFilter,
		FirstOrderKalmanFilter,
		SecondOrderKalmanFilter,
	}
	private FilterType filterIndex = FilterType.NoFilter;
	private List<Queue<float>> _filterQueue = new List<Queue<float>>() { new Queue<float>(), new Queue<float>(), new Queue<float>() };
	// Filter
	int count = 0;
	float angleRead;
	float[] sum = { 0, 0, 0, 0, 0, 0};

	
	// Client Threads
	private Thread _clientThread;
	private Socket ClientSocket;
	private EndPoint ServerEndPoint;
	private List<int> robotJointPWM;
	private List<float> robotJointAngleCmd;
	private int recvLen = 0;
	private byte[] sendData;
	private byte[] recvData = new byte[2*6 + 4*6 + 2*6];
	private byte[] infoData = new byte[4*3*6*2];
	private byte[] byteArray;
	public bool SendCmd = true;
	public enum RobotType
	{
		CUTeR,
		OpenManipulatorPro,
		SOARM101,
	}

	// 0 for CUTeR; 1 for OpenManipulator Pro
	static public RobotType ROBOT_TYPE = RobotType.SOARM101;
	private int ROBOT_DOF = 3;
	private bool HAS_PWM = false;

	public bool isReceive = true;
	private float timer = 0;
	private float timer2 = 0;
	public float control_rate;


	#endregion

	#region MonoBehaviour
	private void Start(){}
    private void OnEnable()
    {
		if(ROBOT_TYPE == RobotType.CUTeR)
		{
			ROBOT_DOF = 3;
		}else if(ROBOT_TYPE == RobotType.OpenManipulatorPro)
		{
			ROBOT_DOF = 6;
		}else if(ROBOT_TYPE == RobotType.SOARM101)
		{
			ROBOT_DOF = 6;
		}
		// Get hooks
		_robotController = GetComponent<RobotController>();
		_robotControllerUI = GetComponent<RobotControllerUI>();
		_debugText = _robotController.GetRobotCanvas().transform.Find("DebugText")?.GetComponent<Text>();
		_robotSettingTransform = _robotController.GetRobotCanvas().transform.Find("RobotSettingPanel/Window/Robot");
		_robotIPIF = _robotSettingTransform.Find("RobotServer/RobotIP/InputField (TMP)")?.GetComponent<TMP_InputField>();
		_robotPortIF = _robotSettingTransform.Find("RobotServer/RobotPort/InputField (TMP)")?.GetComponent<TMP_InputField>();
		_filterDropdown = _robotSettingTransform.Find("RobotServer/Filter/Dropdown")?.GetComponent<TMP_Dropdown>();


		// Set up UIs
		_robotIPIF.onValueChanged.AddListener((value) =>{ SetRobotIP(value); });
		_robotPortIF.onValueChanged.AddListener((value) => { SetRobotPort(value); });

		_filterDropdown.ClearOptions();
		_filterDropdown.AddOptions(new List<string> { "No Filter", "Moving Average", "First Order Kalmen"});
		_filterDropdown.onValueChanged.AddListener((value) => { SetFilter((FilterType) value); });
		
		
		// _robotIPIF.text = PlayerPrefs.GetString("_robotIP", "127.0.0.1");
		_robotPortIF.text = PlayerPrefs.GetInt("_robotPort", 1234).ToString();

        _robotSettingTransform.Find("RobotServer/Robot/Connect/Toggle").gameObject.GetComponent<Toggle>().onValueChanged.AddListener((value) => SetConnect(value));
        _robotSettingTransform.Find("RobotServer/Robot/Lock/Toggle").gameObject.GetComponent<Toggle>().onValueChanged.AddListener((value) => Lock(value));
		_robotSettingTransform.Find("RobotServer/LED/Slider")?.GetComponent<Slider>().onValueChanged.AddListener((value) => { SetLED(value); });
		_robotSettingTransform.Find("RobotServer/MovingAverage/Slider")?.GetComponent<Slider>().onValueChanged.AddListener((value) => { SetAverageWindowSize(value); });
		//Time.fixedDeltaTime = 0.05f;
	}
    private void FixedUpdate()
	{
		SendToRobot();
		timer2 = timer2 + Time.fixedDeltaTime;
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
        float[] angles = new float[ROBOT_DOF];
        float A1 = _robotController.A1; // 10.18f;
        float L1 = _robotController.L1; // 19.41f;
        float A2 = _robotController.A2; // 2.91f;
        float L1_star = Mathf.Sqrt(L1 * L1 + A2 * A2);
        float L2 = _robotController.L2; // 20.2f;
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
		// if(_receiveThread == null) return;
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
                
				byteArray = new byte[2];
				byteArray[0] = 0;
				byteArray[1] = 1;
				ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
				if(ROBOT_TYPE == RobotType.CUTeR){
					recvLen = ClientSocket.ReceiveFrom(infoData, ref ServerEndPoint);
				}
				// Debug.Log(BitConverter.ToInt16(recvData, 4));
				SetFilter(filterIndex);
				_receiveThread = new Thread(new ThreadStart(ClientThread));
				_receiveThread.Start();
				_connected = true;
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
			if (_receiveThread != null)
				_receiveThread.Abort();
			if(ClientSocket != null){
				byteArray = new byte[2];
				byteArray[0] = 0;
				byteArray[1] = 0;
				ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
				ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
				ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
			}
			_connected = false;
			//Disconnect();
		}
    }
	public bool IsConnected() { return _connected; }
	
	// Get Robot Status
	public List<int> GetFeedbackPWM() { return _feedbackPwmList; }
	public List<int> GetCmdPWM() { return _cmdPwmList; }

	// Client Functions
	void SendToRobot(){
		if (!_connected) return;

		robotJointPWM = _robotController.GetSendPWM();
		robotJointAngleCmd = _robotController.GetCmdJointAngles();
		//SendMsg("post," + String.Join(",", robotJointAngles) + ",end");

		try // todo: make the logic more clear
		{
			//Debug.Log("" + robotJointAngles[0] + "," + robotJointAngles[1] + "," + robotJointAngles[2]);

			if ((_unlocked || !SendCmd || (ROBOT_TYPE == RobotType.OpenManipulatorPro && isReceive)) && !_robotControllerUI.isUserInterect)
			{
				if (_unlocked || (ROBOT_TYPE == RobotType.OpenManipulatorPro && isReceive) )
				{
					// put here because only main thread can change the angle of the robot
					_robotController.SetCmdJointAngles(_angleListRead, true);
					_robotController.SetTransparentCmdJointAngles(_angleListRead);
				}
			}
			else if(SendCmd)
			{
				if(ROBOT_TYPE == RobotType.CUTeR){
					byteArray = new byte[sizeof(float) * ROBOT_DOF + 1];
					byteArray[0] = 3;
					// Debug.Log(robotJointAngleCmd[0]);
					for(int i = 0; i < ROBOT_DOF; i++){
						Buffer.BlockCopy(BitConverter.GetBytes(robotJointAngleCmd[i]), 0, byteArray, 1 + i * 4, 4);
					}
					ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
					Debug.Log("Angles: " + string.Join(",", _robotController.GetJointAngles()));
				}

					
				else if(ROBOT_TYPE == RobotType.OpenManipulatorPro){
					float path_time = 0.05f;
					timer = timer + Time.fixedDeltaTime;
					if(timer > 0.05){
						byteArray = new byte[sizeof(float) * ROBOT_DOF + 1];
						byteArray[0] = 2;
						for(int i = 0; i < ROBOT_DOF; i++){
							Buffer.BlockCopy(BitConverter.GetBytes(robotJointAngleCmd[i]), 0, byteArray, 1 + i * 4, 4);
						}
						Buffer.BlockCopy(BitConverter.GetBytes(path_time), 0, byteArray, 1 + ROBOT_DOF * 4, 4);
						ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
						Debug.Log("Angles: " + String.Join(",", _robotController.GetJointAngles()));
						timer = 0;
					}
				}
				else if(ROBOT_TYPE == RobotType.SOARM101){
					byteArray = new byte[sizeof(float) * ROBOT_DOF + 1];
					byteArray[0] = 2;
					for(int i = 0; i < ROBOT_DOF; i++){
						Buffer.BlockCopy(BitConverter.GetBytes(robotJointAngleCmd[i]), 0, byteArray, 1 + i * 4, 4);
					}
					ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
					Debug.Log("Angles: " + string.Join(",", _robotController.GetJointAngles()));
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
	public void SendJointCmdDirect(List<float> joint_list, float path_time){
		Debug.Log("Sending joint command to robot with dof: " + ROBOT_DOF);
		if(ROBOT_TYPE == RobotType.CUTeR){
			byteArray = new byte[sizeof(float) * ROBOT_DOF + 1];
			byteArray[0] = 3;
			for(int i = 0; i < ROBOT_DOF; i++){
				Buffer.BlockCopy(BitConverter.GetBytes(joint_list[i]), 0, byteArray, 1 + i * 4, 4);
			}
		}
		else if(ROBOT_TYPE == RobotType.OpenManipulatorPro){
			byteArray = new byte[sizeof(float) * ROBOT_DOF + 4 + 1];
			byteArray[0] = 2;
			for(int i = 0; i < ROBOT_DOF; i++){
				Buffer.BlockCopy(BitConverter.GetBytes(joint_list[i]), 0, byteArray, 1 + i * 4, 4);
			}
			Buffer.BlockCopy(BitConverter.GetBytes(path_time), 0, byteArray, 1 + ROBOT_DOF * 4, 4);
		}else if(ROBOT_TYPE == RobotType.SOARM101){
			byteArray = new byte[sizeof(float) * ROBOT_DOF + 1];
			byteArray[0] = 2;
			for(int i = 0; i < ROBOT_DOF; i++){
				Buffer.BlockCopy(BitConverter.GetBytes(joint_list[i]), 0, byteArray, 1 + i * 4, 4);
			}
		}
		ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
		Debug.Log("Angles: " + string.Join(",", _robotController.GetJointAngles()));
		Debug.Log("Byte Array Length: " + byteArray.Length);
	}

	void ClientThread()
	{
		while (true)
        {

			try
			{
                if (_unlocked || (ROBOT_TYPE == RobotType.OpenManipulatorPro && isReceive))
				{
					recvLen = ClientSocket.ReceiveFrom(recvData, ref ServerEndPoint);
					ParsePWMByte(recvData);
					//ParsePWM(Encoding.ASCII.GetString(recvData));
				}
			}
			catch (Exception e)
			{
				Debug.Log(e);
                if (_connected)
				{
					Debug.Log("Resend connecting request");
					byteArray = new byte[2];
					byteArray[0] = 0;
					byteArray[1] = 1;
					ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
					
					if(ROBOT_TYPE == RobotType.CUTeR){
						recvLen = ClientSocket.ReceiveFrom(infoData, ref ServerEndPoint);
					}				
				}
				
			}
		}

    }
	private void ParsePWMByte(byte[] byteArray)
	{
		// Debug.Log("Parsing");
		ROBOT_DOF = BitConverter.ToInt16(byteArray, 0);
		HAS_PWM = BitConverter.ToInt16(byteArray, 2) == 1;
		for (int i = 0; i < ROBOT_DOF; i++)
		{
			if (HAS_PWM)
			{
				_feedbackPwmList[i] = BitConverter.ToInt16(byteArray, 4 + ROBOT_DOF * 4 + i * 2);
			}			//Debug.Log(BitConverter.ToInt16(byteArray, i * 2));
		}
		//Debug.Log(_feedbackPwmList[0] + " " + _feedbackPwmList[1] + " " + _feedbackPwmList[2] + " ");
		
		// Filter
		for (int i = 0; i < ROBOT_DOF; i++)
		{
			angleRead = BitConverter.ToSingle(byteArray, 4 + i * 4);
			if (filterIndex == FilterType.MovingAverageFilter)
			{
				if (count <= windowSize)
				{
					count++;
					sum[i] += angleRead;
					_filterQueue[i].Enqueue(angleRead);
					_angleListRead[i] = sum[i] / count;
					//Debug.Log(tail[i].Count);
				}
                else
				{
					sum[i] += angleRead;
					_filterQueue[i].Enqueue(angleRead);
					sum[i] -= _filterQueue[i].Dequeue();
					//Debug.Log(tail[i].Count);
					_angleListRead[i] = sum[i] / windowSize;
				}
            }
            else if(filterIndex == FilterType.NoFilter || filterIndex == FilterType.FirstOrderKalmanFilter)
			{
				_angleListRead[i] = angleRead;
			}
			//Debug.Log(BitConverter.ToInt16(byteArray, ROBOT_DOF * 2 + i * 4));
		}
        // Debug.Log(" " + _angleListRead[0] + " " + _angleListRead[1] + " " + _angleListRead[2] + " ");
        // Debug.Log(" " + _angleListRead[3] + " " + _angleListRead[4] + " " + _angleListRead[5] + " ");
        if (SendCmd)
		{
			for (int i = 0; i < ROBOT_DOF; i++)
			{
				_cmdPwmList[i] = BitConverter.ToInt16(byteArray, ROBOT_DOF * 2 + ROBOT_DOF * 4 + i * 2);
				//Debug.Log(BitConverter.ToInt16(byteArray, ROBOT_DOF * 2 + ROBOT_DOF * 4 + i * 2));
			}
			//Debug.Log(_cmdPwmList[0] + " " + _cmdPwmList[1] + " " + _cmdPwmList[2] + " ");
		}
	}
	private void ParsePWM(string str)
    {
        try
		{
			string[] vs = str.Split(',');
			for (int i = 0; i < ROBOT_DOF; i++)
			{
				_feedbackPwmList[i - 0] = int.Parse(vs[i]);
			}
			for (int i = ROBOT_DOF; i < 6; i++)
			{
				_angleListRead[i - ROBOT_DOF] = float.Parse(vs[i]);
			}
            
            
		}
		catch(Exception e)
        {
			Debug.Log(str);
			Debug.LogError(e);
        }
    }
	
	// Set Robot Status
	public void Lock(bool value)
    {
		if(value){
			Debug.Log("Locking robot");
			_unlocked = false;
			//sendData = Encoding.ASCII.GetBytes("unlock,false,end");
			//ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
			byteArray = new byte[2];
			byteArray[0] = 1;
			byteArray[1] = 1;
			ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
			Thread.Sleep(100);
		}else{
			Debug.Log("Unlocking robot");
			_unlocked = true;
			//sendData = Encoding.ASCII.GetBytes("unlock,true,end");
			//ClientSocket.SendTo(sendData, sendData.Length, SocketFlags.None, ServerEndPoint);
			byteArray = new byte[2];
			byteArray[0] = 1;
			byteArray[1] = 0;
			ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
			Thread.Sleep(100);
		}
	}
	public void SendPWMCmd(int index, int pwm)
	{
		_cmdPwmList[index] = pwm;
		byteArray = new byte[sizeof(float) * ROBOT_DOF + 1];
		byteArray[0] = 3;
		for(int i = 0; i < ROBOT_DOF; i++){
			Buffer.BlockCopy(BitConverter.GetBytes((float)_cmdPwmList[i]), 0, byteArray, 1 + i * 4, 4);
		}
		//sendData = Encoding.ASCII.GetBytes("angle," + String.Join(",", _robotController.GetJointAngles()));
		ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
	}

	public void SetFilter(FilterType value)
    {
		_robotSettingTransform.Find("RobotServer/MovingAverage/Slider")?.gameObject.SetActive(false);
		filterIndex = value;
		byteArray = new byte[2];
		byteArray[0] = 6;
		if(filterIndex == FilterType.NoFilter)
        {
			// No filter
			byteArray[1] = 0;
		}
		if(filterIndex == FilterType.MovingAverageFilter)
        {
			// Moving Average
			byteArray[1] = 0;
			_robotSettingTransform.Find("RobotServer/MovingAverage/Slider")?.gameObject.SetActive(true);
		}
		if(filterIndex == FilterType.FirstOrderKalmanFilter)
        {
			// first order Kalmen
			byteArray[1] = 1;
		}
		if(filterIndex == FilterType.SecondOrderKalmanFilter)
		{
			// second order Kalmen
			byteArray[1] = 2;
		}
		if (_connected) ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
	}
	public void SetAverageWindowSize(float value)
	{
		if (filterIndex == FilterType.MovingAverageFilter)
		{
			windowSize = (int)value;
			count = 0;
			for (int i = 0; i < ROBOT_DOF; i++)
			{
				sum[i] = 0;
				_filterQueue[i].Clear();
			}
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
		Buffer.BlockCopy(BitConverter.GetBytes(offset[0]), 0, infoData, 0, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(offset[1]), 0, infoData, 4, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(offset[2]), 0, infoData, 8, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(scale[0]), 0, infoData, 12, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(scale[1]), 0, infoData, 16, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(scale[2]), 0, infoData, 20, 4);

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
		Buffer.BlockCopy(BitConverter.GetBytes(offset[0]), 0, infoData, 24, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(offset[1]), 0, infoData, 28, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(offset[2]), 0, infoData, 32, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(scale[0]), 0, infoData, 36, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(scale[1]), 0, infoData, 40, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(scale[2]), 0, infoData, 44, 4);
		
		ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
	}
	public List<float> GetFeedbackOffset()
	{
		return new List<float> { BitConverter.ToSingle(infoData, 0), BitConverter.ToSingle(infoData, 4), BitConverter.ToSingle(infoData, 8) };
	}
	public List<float> GetFeedbackScale()
	{
		return new List<float> { BitConverter.ToSingle(infoData, 12), BitConverter.ToSingle(infoData, 16), BitConverter.ToSingle(infoData, 20) };
	}
	public List<float> GetCmdOffset()
	{
		return new List<float> { BitConverter.ToSingle(infoData, 24), BitConverter.ToSingle(infoData, 28), BitConverter.ToSingle(infoData, 32) };
	}
	public List<float> GetCmdScale()
	{
		return new List<float> { BitConverter.ToSingle(infoData, 36), BitConverter.ToSingle(infoData, 40), BitConverter.ToSingle(infoData, 44) };
	}
	public void SetLED(float brightness){
		byteArray = new byte[sizeof(float) + 1];
		byteArray[0] = 7;
		Buffer.BlockCopy(BitConverter.GetBytes(brightness/2), 0, byteArray, 1, 4);
		ClientSocket.SendTo(byteArray, byteArray.Length, SocketFlags.None, ServerEndPoint);
	}
	#endregion
}
