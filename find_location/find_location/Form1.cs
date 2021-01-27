using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace find_location
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double width;
        static double length;

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\B3.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox3.Text); //1500
            int y = Convert.ToInt32(textBox4.Text); //700
            int rate_x = (int)(x / width * 500); // 3000
            int rate_y = (int)(y / length * 500); // 2000

            Graphics g = pictureBox1.CreateGraphics();
            g.FillEllipse(new SolidBrush(Color.Red),500-rate_x-15,500-rate_y-15,30,30);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            width = Convert.ToDouble(textBox1.Text);
            length = Convert.ToDouble(textBox2.Text);
        }
    }
}
