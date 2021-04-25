using System;
using System.IO.Ports;

namespace SerialClient
{
    public class SerialClient
    {
        private SerialPort _client;

        public SerialClient()
        {
        }

        public void ConnectClient(string port)
        {
            // Make sure we close the previous connection
            _client?.Close();

            _client = new(port);

            _client.Open();
        }

        public void SendMessage(string message)
        {
            if (_client == null || !_client.IsOpen)
            {
                Console.WriteLine("Client is either null or port is not open");
                return;
            }

            _client.WriteLine(message);
        }
    }
}
