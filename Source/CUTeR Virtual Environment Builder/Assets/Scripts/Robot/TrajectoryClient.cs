using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class TrajectoryClient : MonoBehaviour
{

	#region Variables
	[SerializeField]
	private RobotController _robotController;
	[SerializeField]
	private string _serverIP;
	[SerializeField]
	private int _serverPort;

	private bool _connected;
	private TcpClient _client;
	private Thread _clientThread;

	#endregion

	#region MonoBehaviour
	private void FixedUpdate()
	{
		if (_connected)
		{
			// send obj data
			SendMsg("objdata");
		}
	}
	#endregion

	#region Methods
	public void SetRobotIP(string value)
	{
		_serverIP = value;
	}
	public void SetRobotPort(string value)
	{
		_serverPort = int.Parse(value);
	}
	public void SetConnect(bool value)
	{
		if (value)
		{
			Connect();
		}
		else
		{
			Disconnect();
		}
	}

	/// <summary> 	
	/// Setup socket connection. 	
	/// </summary> 	
	private void Connect()
	{
		try
		{
			_client = new TcpClient(_serverIP, _serverPort);
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
		_client.Close();
		_connected = false;
		_client = null;
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
						Debug.Log("server message received as: " + serverMessage);
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
    #endregion
}
