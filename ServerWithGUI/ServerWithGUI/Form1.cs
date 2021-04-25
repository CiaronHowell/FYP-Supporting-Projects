using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerWithGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _startServerButton_Click(object sender, EventArgs e)
        {
            ServerSocket server = new();
            server.ReceivedMessage += Server_ReceivedMessage;

            Thread socketServerThread = new Thread(server.StartServer);
            socketServerThread.Start();

            // Only allow to start the server once
            _startServerButton.Enabled = false;
        }

        private void Server_ReceivedMessage(string message)
        {
            this.Invoke((MethodInvoker)delegate
            {
                _messageReceivedTextBox.Text = message;
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort receiver = new(_serialComPortTextBox.Text);

            if (receiver.IsOpen)
            {
                Debug.WriteLine("Port already open RIPPPPPP");
            }

            receiver.Open();

            receiver.DataReceived += Receiver_DataReceived;

            button1.Enabled = false;
        }

        private void Receiver_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort receiver = (SerialPort)sender;

            string message = receiver.ReadExisting();
            this.Invoke((MethodInvoker)delegate
            {
                _serialMessageTextBox.Text = message;
            });
        }
    }
}
