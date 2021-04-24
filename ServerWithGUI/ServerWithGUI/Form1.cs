using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            server.StartServer();

            server.ReceivedMessage += Server_ReceivedMessage;

            // Only allow to start the server once
            _startServerButton.Enabled = false;
        }

        private void Server_ReceivedMessage(string message)
        {
            _messageReceivedTextBox.Text = message;
        }
    }
}
