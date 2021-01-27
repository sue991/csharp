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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox3.Text); //1500
            int y = Convert.ToInt32(textBox4.Text); //700
            int rate_x = (int)(x / width * 500); // 3000
            int rate_y = (int)(y / length * 500); // 2000

            Graphics g = pictureBox1.CreateGraphics();
            g.FillEllipse(new SolidBrush(Color.Red),rate_x-10,rate_y-10,20,20);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string image_file = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                image_file = dialog.FileName;
            }
            else if(dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            pictureBox1.Image = Bitmap.FromFile(image_file);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            width = Convert.ToDouble(textBox1.Text);
            length = Convert.ToDouble(textBox2.Text);
        }
    }
}
