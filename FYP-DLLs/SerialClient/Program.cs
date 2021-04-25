using System;

namespace SerialClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialClient client = new();
            client.ConnectClient("COM3");
            client.SendMessage("Yeeeeeeet");
        }
    }
}
