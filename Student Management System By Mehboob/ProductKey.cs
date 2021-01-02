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
    public partial class ProductKey : Form
    {
        Form1 f;
        public ProductKey(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void btregister_Click(object sender, EventArgs e)
        {
            lblinfo.Visible = false;
            erpkey.Visible = false;
            if(txtregister.Text==String.Empty)
            {
                erpkey.Visible = true;
                lblinfo.Visible = true;
                return;
            }
            if(!(txtregister.Text.Equals("Love")))
            {
                erpkey.Visible = true;
                lblinfo.Visible = true;
                return;
            }
            Signup s = new Signup(f,this);
            this.Hide();
            s.Show();
        }

        private void ProductKey_Load(object sender, EventArgs e)
        {

        }

        private void ProductKey_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Show();
        }
    }
}
