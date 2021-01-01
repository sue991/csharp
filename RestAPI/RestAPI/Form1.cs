using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RestAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            textBox1.Text = "https://jsonplaceholder.typicode.com/users";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient(textBox1.Text);
            var request = new RestRequest("1", Method.GET);
            var response = client.Get(request);

            JObject applyJObj = JObject.Parse(response.Content);
            string name = applyJObj["name"].ToString();
            string etc = applyJObj["address"]["city"].ToString();
            textBox2.Text += "name : " + name + "\r\n" + "address , city : " + etc;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
