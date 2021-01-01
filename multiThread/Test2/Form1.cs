using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread td1 = new Thread(new ThreadStart(Run1));
            td1.Start();

            Thread td2 = new Thread(new ThreadStart(Run2));
            td2.Start();
        }



        private void Run1()
        {
            for (int i = 1; i <= 20; i++)
            {
                updateTextBox(i.ToString());
                Thread.Sleep(100);
            }
        }

        private void Run2()
        {
            for (int i = 10; i <= 200; i += 10)
            {
                updateTextBox2(i.ToString());
                Thread.Sleep(100);

            }
        }


        private void updateTextBox(string data) {
            if (textBox1.InvokeRequired)
            {
                textBox1.BeginInvoke(new Action(() => textBox1.Text += data+'\r'+'\n'));
            }
            else
            {
                textBox1.Text += (data + '\n');
            }
        }

        private void updateTextBox2(string data)
        {
            if (textBox2.InvokeRequired)
            {
                textBox2.BeginInvoke(new Action(() => textBox2.Text += data + '\r' + '\n'));
            }
            else
            {
                textBox2.Text += (data + '\n');
            }
        }
    }
}
