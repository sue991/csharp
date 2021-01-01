using Hik.Communication.Scs.Client;
using Hik.Communication.Scs.Communication.EndPoints.Tcp;
using Hik.Communication.Scs.Communication.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testclient
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        IScsClient client;

        private void btn_connect_Click(object sender, EventArgs e) {
            btn_connect.Enabled = false;

            client = ScsClientFactory.CreateClient(new ScsTcpEndPoint(txtHost.Text, Convert.ToInt32(txtPort.Text)));
            client.MessageReceived += Client_MessageReceived;

            client.Connected += Client_Connected;
            client.Connect();

           
        }

        private void Client_Connected(object sender, EventArgs e)
        {
            Console.WriteLine("connected");
            btn_send.Enabled = true;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            var messageText = textBox1.Text; 
            client.SendMessage(new ScsTextMessage(messageText));

             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHost.Text = "127.0.0.1";
            txtPort.Text = "10085";

        }

        private void Client_MessageReceived(object sender, MessageEventArgs e)
        {
            var message = e.Message as ScsTextMessage;
            if (message == null)
            {
                return;
            }
            Console.WriteLine("Server sent a message: " + message.Text);

            textBox2.Invoke((MethodInvoker)delegate ()
            {
                textBox2.Text += "server : " + message.Text + '\n';

            });
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
