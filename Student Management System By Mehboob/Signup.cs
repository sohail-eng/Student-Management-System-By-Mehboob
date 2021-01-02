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
    public partial class Signup : Form
    {
        Form1 f;
        ProductKey p;
        public Signup(Form1 f,ProductKey p)
        {
            InitializeComponent();
            this.f = f;
            this.p = p;
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            p.Close();
            f.Show();
        }
    }
}
