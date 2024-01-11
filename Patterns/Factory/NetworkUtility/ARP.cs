using System;
namespace DesignPatterns.Patterns.Factory.NetworkUtility
{
	internal class ARP
	{
        public void SendRequest(string ip, int timeSent)
        {
            Console.WriteLine("ARP request sent to : " + ip + " " + timeSent + "times");
        }
    }
}

