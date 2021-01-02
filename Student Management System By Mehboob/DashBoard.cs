using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System_By_Mehboob
{
    public partial class DashBoard : Form
    {
        Form1 f;
        String adminname;
        public DashBoard(Form1 f,String adminname)
        {
            InitializeComponent();
            this.f = f;
            this.adminname = adminname;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            this.lbladminname.Text = adminname;
        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Show();
        }
    }
}
