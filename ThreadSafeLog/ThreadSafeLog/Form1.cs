using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Windows.Forms;
using System.Threading;

namespace ThreadSafeLog
{
    public partial class Form1 : Form
    {
        private static ConcurrentQueue<Log> q = new ConcurrentQueue<Log>();
        private static int num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int threadCount = Convert.ToInt32(textBox1.Text);
                Thread[] t = new Thread[threadCount];
                for (int i = 0; i < threadCount; i++)
                {
                    t[i] = new Thread(threadStart);
                    t[i].Start();
                }


            }

            Thread th = new Thread(Run);
            th.Start();
           
        }

        private void updateUI(string s)
        {
            Func<int> del = delegate ()
            {
                if (listBoxLog.Items.Count > 200)
                {
                    listBoxLog.Items.RemoveAt(listBoxLog.Items.Count - 1);
                }
                listBoxLog.Items.Insert(0, s);
                return 0;
            };
            Invoke(del);
        }
        private void Run()
        {
            while (true)
            {
                if (!q.IsEmpty)
                {
                    var n = q.TryDequeue(out var item); // Race condition!
                    updateUI(item.Msg);
                    // Process(item);
                }
                else
                {
                    Thread.Sleep(50);
                }
            }
        }
        class Log
        {
            public string File { get; set; }
            public string Msg { get; set; }
        }
        public static void addLog(string logFile, string msg)
        {
            Log log = new Log()
            {
                File = logFile,
                Msg = msg
            };

            q.Enqueue(log);
        }

        private static void threadStart()
        {
            string msg = "Start" + num.ToString();
            num += 1;
            addLog("Logfile",msg);

        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
