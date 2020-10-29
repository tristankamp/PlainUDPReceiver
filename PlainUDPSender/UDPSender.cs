using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using ModelLib;

namespace PlainUDPSender
{
    class UDPSender
    {
        public void start()
        {
            Car Car1 = new Car("Tesla","Red", "EL23400");

            UdpClient udpClient = new UdpClient(11002);
            udpClient.Connect("localhost", 11001);
            Byte[] sendBytes = Encoding.ASCII.GetBytes(Car1.ToString());
            udpClient.Send(sendBytes, sendBytes.Length);

        }
    }
}
