using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net;

namespace SocketServer;

public class clsSocketServer
{
	public string msgee;
	public string clientip;
	public string ip;

	private Form mParentForm;
	public Form ParentForm
	{
		get { return mParentForm; }
		set { mParentForm = value; }
	}

	TcpListener listener;
	TcpClient client;
	NetworkStream stream;
	Thread thrInteraction;
	Thread thMessage;
	Thread thConnection;
	public List<TcpClient> tcpClients;

	//Boolean accept = false;

	//Class Events

	public delegate void EHConnectionReceived(string IP);
	public event EHConnectionReceived ConnectionReceived;

	public delegate void EHMessageReceived(string Message);
	public event EHMessageReceived MessageReceived;

	public delegate void EHDisconnection(string IP);
	public event EHDisconnection Disconnection;

	

	//Class Methods

	public void StartListen(string IP, int Port)
	{

		//IPHostEntry  host = Dns.GetHostEntry(Dns.GetHostName());
		//IP = host.AddressList[1].ToString();//ja coloca o endereço ip do servidor
		if (listener != null)
			return;
		
		listener = new TcpListener(System.Net.IPAddress.Any, Port);
		listener.Start();

		tcpClients = new List<TcpClient>();
	   // client = await listener.AcceptTcpClientAsync();

		ip = IP.ToString();
		
		//stream = client.GetStream

		thConnection = new Thread(CheckConnection);
		thMessage = new Thread(MessageReadSystem);
		thConnection.Start();
		thMessage.Start();

	}

	public void CheckConnection()
	{
		try {
			while (true)
			{

				if (listener.Pending())
				{
					client = listener.AcceptTcpClient();
					//thMessage.ExecutionContext.Dispose();
					tcpClients.Add(client);
					//thMessage.Start();

					if (client.Available > 0)
					{
						stream = client.GetStream();
						
					}
					clientip = client.Client.RemoteEndPoint.ToString();

					mParentForm.Invoke(ConnectionReceived, clientip);
				}
			}
        }
        catch (Exception ex)
        {
        }

    }
  
	public void StopListen()
	{
		if (thrInteraction != null)
		{
			if(thrInteraction.ThreadState == ThreadState.Running)
			
				thrInteraction.Abort();   
		}
	   
		
		if (client != null)
			client.Client.Disconnect(true);

		listener.Stop();
	    tcpClients?.Clear();

		listener = null;
	}

	public void SendMessage(string Message, string IP)
	{
		TcpClient tcpClient = tcpClients.Find(t => t.Client.RemoteEndPoint.ToString() == IP);

		if (tcpClient == null)
			return;

		stream = tcpClient.GetStream();

		//send message to client
		byte[] msg = Encoding.ASCII.GetBytes(Message);
		stream.Write(msg, 0, msg.Length);
	}

	public void MessageReadSystem()
	{
        try
        {
            while (true)
			{
				foreach (TcpClient client in tcpClients)
				{
					if (client == null || client.Available == 0)
						continue;
					var stream = client.GetStream();
					//Byte[] msg = new Byte[client.ReceiveBufferSize];
					//stream.Read(msg, 0, msg.Length);
					//string _msg = Encoding.ASCII.GetString(msg);
					Byte[] msg = new Byte[client.ReceiveBufferSize];
					int bytesReceived = stream.Read(msg);
					string data = Encoding.UTF8.GetString(msg.AsSpan(0, bytesReceived));

					mParentForm.Invoke(MessageReceived, string.Format("{0}: {1}", client.Client.RemoteEndPoint, data));
				}
			}
        }
        catch (Exception ex)
        {
			MessageReadSystem();

		}

    }


	public void CloseConnection(string IP)
	{
		client = tcpClients.Find(t => t.Client.RemoteEndPoint.ToString() == IP);

		if (client == null)
			return;

		client.Client.Disconnect(true);
		tcpClients.Remove(client);
		mParentForm.Invoke(Disconnection, ip);
	}

	public void CloseAllConnections()
	{
		foreach (TcpClient client in tcpClients)
        {
			client.Client.Disconnect(true);
			mParentForm.Invoke(Disconnection, ip);
		}
		tcpClients.Clear();	
	}
}
