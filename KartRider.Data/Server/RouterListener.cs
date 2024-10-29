using System;
using System.Net;
using System.Net.Sockets;

namespace KartRider
{
	public class RouterListener
	{
		public static string sIP;

		public static int port;

		public static string forceConnect;

		public static IPEndPoint client;

		public static System.Net.IPEndPoint CurrentUDPServer { get; set; }

		public static string ForceConnect { get; set; }

		public static TcpListener Listener { get; private set; }

		public static SessionGroup MySession { get; set; }

		static RouterListener()
		{
			string str = "127.0.0.1";
			RouterListener.sIP = str;
			int str1 = 39312;
			RouterListener.port = str1;
		}

		public static int[] DataTime()
		{
			DateTime dt = DateTime.Now;
			DateTime time = new DateTime(1900, 1, 1, 0, 0, 0);
			TimeSpan t = dt.Subtract(time);
			double totalSeconds = dt.TimeOfDay.TotalSeconds / 4;
			int Month = (dt.Year - 1900) * 12;
			int MonthCount = Month + dt.Month;
			double tempResult = (double)MonthCount / 2;
			int oddMonthCount;
			if (tempResult % 1 != 0)
			{
				oddMonthCount = (int)tempResult + 1;
			}
			else
			{
				oddMonthCount = (int)tempResult;
			}
			return new int[] { t.Days, (int)totalSeconds, oddMonthCount };
		}

		public static void OnAcceptSocket(IAsyncResult ar)
		{
			try
			{
				Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				Socket clientSocket = RouterListener.Listener.EndAcceptSocket(ar);
				RouterListener.forceConnect = RouterListener.sIP;
				if ((RouterListener.ForceConnect == "" ? false : RouterListener.ForceConnect != "0.0.0.0"))
				{
					RouterListener.forceConnect = RouterListener.ForceConnect;
				}
				RouterListener.MySession = new SessionGroup(clientSocket, null);
				RouterListener.client = clientSocket.RemoteEndPoint as IPEndPoint;
				Console.WriteLine("Client: " + RouterListener.client.Address.ToString() + ":" + RouterListener.client.Port.ToString());
				GameSupport.PcFirstMessage();
			}
			catch
			{
			}
			RouterListener.Listener.BeginAcceptSocket(new AsyncCallback(RouterListener.OnAcceptSocket), null);
		}

		public static void Start()
		{
			Console.WriteLine("Load server IP : {0}:{1}", RouterListener.sIP, RouterListener.port);
			RouterListener.ForceConnect = "";
			RouterListener.Listener = new TcpListener(IPAddress.Parse(RouterListener.sIP), RouterListener.port);
			RouterListener.Listener.Start();
			RouterListener.Listener.BeginAcceptSocket(new AsyncCallback(RouterListener.OnAcceptSocket), null);
			RouterListener.CurrentUDPServer = new System.Net.IPEndPoint(IPAddress.Parse(RouterListener.sIP), 39311);
		}
	}
}