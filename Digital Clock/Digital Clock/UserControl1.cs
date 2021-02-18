using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Digital_Clock
{
    public partial class UserControl1 : UserControl
    {
      
        public enum Dateformats
        {
            date12,
            date24
        }

        private Dateformats DateStyle;

        [Category("Dateformats"), Description("시간표현방식 설정"), Browsable(true)]
        public Dateformats Dateformat
        {
            get
            {
                return DateStyle;
            }
            set
            {
                DateStyle = value;
            }
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateStyle == Dateformats.date12)
            {
                label1.Text = DateTime.Now.ToString("hh:mm");
            }
            else
            {
                label1.Text = DateTime.Now.ToString("HH:mm");
            }
                label2.Text = DateTime.Now.ToString("ss");
                label3.Text = DateTime.Now.ToString("MM dd yyyy");
                label4.Text = DateTime.Now.ToString("dddd");
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }
    }
}
