using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = System.Convert.ToDouble(textBox1.Text);
            double b = System.Convert.ToDouble(textBox2.Text);

            switch (itemSelected)
            {
                case "+":
                    result = a + b;
                    break;

                case "-":
                    result = a - b;
                    break;

                case "*":
                    result = a * b;
                    break;

                case "/":
                    result = a / b;
                    break;
            }
            string str = a.ToString() + itemSelected + b.ToString() + "=" + result.ToString() + "\r";
            addLog(str);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sel = comboBox1.SelectedIndex;

            if (sel > -1)
            {
                this.itemSelected = comboBox1.SelectedItem as string;

            }
        }

        private string itemSelected;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')){
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = !textBox1.Visible;
        }

        void addLog(string str)
        {
            textBox3.Text += str + "\n";
        }
    }
}
