using System;
using System.Threading;

namespace PlainUDPReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UDPReceiver IsThereAnybodyOutThere = new UDPReceiver();
            IsThereAnybodyOutThere.start();
        }
    }
}
