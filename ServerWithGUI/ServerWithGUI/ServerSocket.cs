using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerWithGUI
{
    public class ServerSocket
    {
        private Socket _server;

        public ServerSocket()
        {
            _server = new(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp);
        }

        public void StartServer()
        {
            _server.Start
            _server.Listen()
        }

        // TODO: Create event so GUI can latch on and display the return value

        // TODO: Call in form

    }
}
