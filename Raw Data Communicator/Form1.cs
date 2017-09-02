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
            sendTextButton.Enabled = true;
        }

        private void sendTextButton_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.ASCII.GetBytes(textToSend.Text);
            client.GetStream().WriteAsync(data, 0, textToSend.Text.Length);
            textToSend.Text = string.Empty;
        }

        private void sendCommandButton_Click(object sender, EventArgs e)
        {
            byte[] test = new byte[30];
            byte[] command = MakeCommand("HELP", 10);
            byte[] data = MakeDataSizeFrame("", 20);
            Array.Copy(command, 0, test, 0, 10);
            Array.Copy(data, 0, test, 10, 20);
            client.GetStream().WriteAsync(test, 0, data.Length);
            //Console.WriteLine(Encoding.ASCII.GetBytes(data).ToString());
        }

        private byte[] MakeCommand(string s, int paddingSize)
        {
            int stringLen = s.Length;
            int numberOfPads = paddingSize - stringLen;
            if (numberOfPads < 0)
                throw new ArgumentOutOfRangeException();
            return Encoding.ASCII.GetBytes(s.PadRight(paddingSize));
        }
        private byte[] MakeDataSizeFrame(string s, int paddingSize)
        {
            int stringLen = s.Length.ToString().Length;
            int numberOfPads = paddingSize - stringLen;
            if (numberOfPads < 0)
                throw new ArgumentOutOfRangeException();
            return Encoding.ASCII.GetBytes(s.Length.ToString().PadLeft(paddingSize, '\0'));
        }
        //private char[] MakePaddedPacket(string s, int totalSize)
        //{
        //    if (s.Length > totalSize)
        //        throw new ArgumentOutOfRangeException("s length", "String length is greater than the total size of the packet.");
        //    char[] data = new char[totalSize];
        //    string packetSize = s.Length.ToString();
        //    int paddingLen = totalSize - packetSize.Length;
        //    //StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < paddingLen; i++)
        //        data[i] = 'x';
        //    for (int i = 0; i < packetSize.Length; i++)
        //        data[paddingLen + i] = packetSize[i];
        //    return data;
        //}
    }
}
