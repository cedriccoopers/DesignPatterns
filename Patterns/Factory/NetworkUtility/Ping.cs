using System;
namespace DesignPatterns.Patterns.Factory.NetworkUtility
{
	internal class Ping
	{
		public void SendRequest(string ip, int timeSent)
		{
			Console.WriteLine("Ping request sent to : " + ip + " " + timeSent + "times");
		}
	}
}

