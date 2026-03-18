using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection (@"Data Source=lab7pc11\SQLEXPRESS01;Initial Catalog=aptech;User ID=aptech;Password=123;");
        SqlCommand cmd;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open ();
            cmd = new SqlCommand("insert into students(name, timing, course, days) values ('" + nametxt.Text + "', '" + timingtxt.Text + "', '" + coursetxt.Text + "' , '" + daystxt.Text + "')", conn);

            cmd.ExecuteNonQuery ();
            MessageBox.Show("Student Added Successfully");
            conn.Close ();
            nametxt.Clear ();
            timingtxt.Items.Clear();
            coursetxt.Items.Clear();
            daystxt.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data_view data_View = new data_view();
            data_View.Show();
            this.Hide();        }
    }
}
