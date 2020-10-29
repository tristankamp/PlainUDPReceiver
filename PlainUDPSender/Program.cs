using System;

namespace PlainUDPSender
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPSender ImHere = new UDPSender();
            ImHere.start();
        }
    }
}
