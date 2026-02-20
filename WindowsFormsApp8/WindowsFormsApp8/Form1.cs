using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hrslb.Text = "00";
            minslb.Text = "00";
            secslb.Text = "00";
            msecslb.Text = "00";
            timer1.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int msecs = Convert.ToInt32(msecslb.Text);
            int secs = Convert.ToInt32(secslb.Text);
            int mins = Convert.ToInt32(minslb.Text);
            int hrs = Convert.ToInt32(hrslb.Text);


            msecs = msecs + 1;
            msecslb.Text = msecs.ToString();
            
            if(msecs >= 60){
                msecs = 0;
                msecslb.Text = msecs.ToString();
                secs = secs + 1;
                secslb.Text = secs.ToString();
            }
            else if(secs >= 60)
            {
                secs = 0;
                secslb.Text = secs.ToString();

                mins = mins + 1;
                minslb.Text = mins.ToString();
            }
            else if (mins >= 60)
            {
                mins = 0;
                minslb.Text = mins.ToString();

                hrs = hrs + 1;
                hrslb.Text = hrs.ToString();
            }

        }
    }
}
