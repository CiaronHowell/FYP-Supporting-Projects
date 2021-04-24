using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerWithGUI
{
    public class ServerSocket
    {
        public byte[] IP { get; } = { 127, 0, 0, 1 };

        public int Port { get; } = 11000;

        public event ReceivedMessageHandler ReceivedMessage;

        public ServerSocket()
        {
            
        }

        public void StartServer()
        {
            Socket server = new(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp);

            IPEndPoint endPoint = new(new IPAddress(IP), Port);

            server.Bind(endPoint);

            server.Listen(5);

            //while (true)
            //{
            Debug.WriteLine("Waiting for connection");
                server.BeginAccept(
                    new AsyncCallback(ConnectionCallback), 
                    server);
            //}
        }

        public void ConnectionCallback(IAsyncResult connection)
        {
            Socket server = (Socket)connection.AsyncState;
            Socket connectionHandler = server.EndAccept(connection);

            StateObject state = new();
            state.workSocket = server;

            connectionHandler.BeginReceive(
                state.buffer, 
                0, 
                StateObject.BufferSize, 
                0, 
                new AsyncCallback(GetMessageCallback), 
                state);
        }

        public void GetMessageCallback(IAsyncResult result)
        {
            StateObject state = (StateObject)result.AsyncState;
            Socket connectionHandler = state.workSocket;

            int bytesRead = connectionHandler.EndReceive(result);
            if (bytesRead > 0)
            {
                state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                OnMessageReceived(state.sb.ToString());
            }

        }

        private void OnMessageReceived(string message)
        {
            ReceivedMessage?.Invoke(message);
        }
    }

    public delegate void ReceivedMessageHandler(string message);

    public class StateObject
    {
        // Size of receive buffer.  
        public const int BufferSize = 1024;

        // Receive buffer.  
        public byte[] buffer = new byte[BufferSize];

        // Received data string.
        public StringBuilder sb = new StringBuilder();

        // Client socket.
        public Socket workSocket = null;
    }
}
