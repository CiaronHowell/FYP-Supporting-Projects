using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ya Yeet");

            SocketClient client = new SocketClient();
            client.ConnectClient("127.0.0.1", 11000);
            client.SendMessage("test1234");

            Console.ReadKey();
        }

    }
}
