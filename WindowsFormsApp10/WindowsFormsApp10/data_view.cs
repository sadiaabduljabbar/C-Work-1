using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class data_view : Form
    {
        public data_view()
        {
            InitializeComponent();
        }

        private void data_view_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aptechDataSet1.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.aptechDataSet1.students);

        }
    }
}
