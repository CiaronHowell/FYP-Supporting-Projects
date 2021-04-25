using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SocketClient
{
    public class SocketClient
    {
        private Socket _socketClient;

        private static ManualResetEvent Connected = new ManualResetEvent(false);

        public SocketClient()
        {
            Console.WriteLine("Creating socket");
            _socketClient = new(
                AddressFamily.InterNetwork, 
                SocketType.Stream, 
                ProtocolType.Tcp);
        }

        public void ConnectClient(string unparsedIp, int port)
        {
            string[] addresses = unparsedIp.Split('.');
            byte[] parsedIpAddress = new byte[4];
            for (int subnet = 0; subnet < parsedIpAddress.Length; subnet++)
            {
                parsedIpAddress[subnet] = byte.Parse(addresses[subnet]);
            }

            IPAddress ip = new(parsedIpAddress);
            IPEndPoint remoteEndPoint = new(ip, port);
            _socketClient.BeginConnect(
                remoteEndPoint, 
                new AsyncCallback(OnConnect), 
                _socketClient);
        }

        private void OnConnect(IAsyncResult connection)
        {
            Socket client = (Socket)connection.AsyncState;
            client.EndConnect(connection);

            Console.WriteLine($"Connected to {client.RemoteEndPoint}");
            Connected.Set();
        }

        public void SendMessage(string message)
        {
            if (_socketClient == null)
            {
                Debug.WriteLine("Socket client hasn't been initialized");
                return;
            }

            Connected.WaitOne();

            byte[] messageBytes = Encoding.ASCII.GetBytes(message);
            _socketClient.BeginSend(
                messageBytes,
                0,
                messageBytes.Length,
                0,
                new AsyncCallback(OnSent),
                _socketClient);

        }

        private void OnSent(IAsyncResult sent)
        {
            Socket client = (Socket)sent.AsyncState;
            client.EndSend(sent);
        }

    }
}
