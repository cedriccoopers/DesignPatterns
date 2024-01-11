using System;
namespace DesignPatterns.Patterns.Factory.NetworkUtility
{
	internal class DNS
	{
        public void SendRequest(string ip, int timeSent)
        {
            Console.WriteLine("DNS request sent to : " + ip + " " + timeSent + "times");
        }
    }
}

