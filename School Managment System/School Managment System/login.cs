using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managment_System
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            register registerform = new register();
            registerform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(usernametxt.Text == "admin" && passwordtxt.Text  == "123")
            {
                this.Hide();
                dashboard dashboard = new dashboard();
                dashboard.Show();
            }
        }
    }
}
