using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            if(usernametxt.Text == "admin")
            {
                passwordtxt.Enabled = true;
            }
            else
            {
              passwordtxt.Enabled=false;
            }
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(usernametxt.Text == "admin" && passwordtxt.Text == "admin123")
            {
                dashboard dashboard = new dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invlaid Password");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }





    }
}
