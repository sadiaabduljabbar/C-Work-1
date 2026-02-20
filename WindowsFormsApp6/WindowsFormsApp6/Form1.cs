using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Subject Varaiables
            int bio = Convert.ToInt32(biotxt.Text);

            int chem = Convert.ToInt32(chemtxt.Text);

            int phy = Convert.ToInt32(phytxt.Text);

            int math = Convert.ToInt32(mathtxt.Text);

            int eng = Convert.ToInt32(engtxt.Text);

            int urdu = Convert.ToInt32(urdutxt.Text);

            int isl = Convert.ToInt32(isltxt.Text);

            int pst = Convert.ToInt32(psttxt.Text);


            // Total marks calculation

            totalnotxt.Text = "800";


            //Obtained Marks Calculation

            int obtno = bio + chem + phy + math + eng  + urdu + isl + pst;
            obtnotxt.Text = obtno.ToString();



            //Perecntage Calculation

            float per = obtno * 100 / 800;
            
            pertxt.Text = per.ToString();


            //Grade Calculation


            if(per >= 90)
            {
                gradetxt.Text = "A+";
            }
            else if(per >= 80)
            {
                gradetxt.Text = "A";
            }
            else if (per >= 70)
            {
                gradetxt.Text = "B";
            }

            else if (per >= 60)
            {
                gradetxt.Text = "C";
            }

            else if (per >= 50)
            {
                gradetxt.Text = "D";
            }

            else if (per >= 40)
            {
                gradetxt.Text = "E";
            }
            else
            {
                gradetxt.Text = "F";
            }








        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
