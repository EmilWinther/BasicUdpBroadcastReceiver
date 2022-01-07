using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BasicUdpBroadcastReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient client = new UdpClient(7000);
            byte[] data;

            while (true)
            {
                IPEndPoint remoteEP = null;

                data = client.Receive(ref remoteEP);

                string str = Encoding.UTF8.GetString(data);
                Console.WriteLine("Received message from user: " + str);
            }
        }
    }
}
