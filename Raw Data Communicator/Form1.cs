using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Raw_Data_Communicator
{
    public partial class Form1 : Form
    {
        TcpClient client = new TcpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async void connectButton_Click(object sender, EventArgs e)
        {
            await client.ConnectAsync("localhost", 9000);
            connectButton.Enabled = false;
            sendButton.Enabled = true;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.ASCII.GetBytes(textToSend.Text);
            client.GetStream().WriteAsync(data, 0, textToSend.Text.Length);
            textToSend.Text = string.Empty;
        }
    }
}
