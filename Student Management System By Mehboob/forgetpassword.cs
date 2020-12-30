using System;
using System.Collections;
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
    
    public partial class forgetpassword : Form
    {
        Form1 f;
        MyData myData;
        public forgetpassword(Form1 f)
        {
            InitializeComponent();
            this.f = f;
            myData = new MyData();
        }

        private void forgetpassword_Load(object sender, EventArgs e)
        {

        }

        private void forgetpassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.loadData();
            f.Show();
        }

        private void btfind_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list = myData.getAdminData();
            for(int i=0;i<list.Count;i++)
            {
                if(((adminClass)list[i]).email.Equals(txtemail.Text))
                {
                    onfind();
                    lblusername.Text = ((adminClass)list[i]).name;
                    lblpass.Text = ((adminClass)list[i]).pass;
                    txtusername.Text = ((adminClass)list[i]).name;
                    txtpassword.Text = ((adminClass)list[i]).pass;
                    return;
                }
            }
            MessageBox.Show("Wrong E-Mail !!!");
        }

        private void onfind()
        {
            txtemail.Enabled = false;
            btfind.Enabled = false;
            btreset.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            lblusername.Visible = true;
            lblpass.Visible = true;
            btedit.Visible = true;
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            btedit.Visible = false;
            txtusername.Visible = true;
            txtpassword.Visible = true;
            lblusername.Visible = false;
            lblpass.Visible = false;
            btcancel.Visible = true;
            btsave.Visible = true;
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            btedit.Visible = true;
            lblusername.Visible = true;
            lblpass.Visible = true;
            txtusername.Visible = false;
            txtpassword.Visible = false;
            btcancel.Visible = false;
            btsave.Visible = false;
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            myData.updateAdminData(txtusername.Text, txtemail.Text, txtpassword.Text);
            lblusername.Text = txtusername.Text;
            lblpass.Text = txtpassword.Text;
            btedit.Visible = true;
            lblusername.Visible = true;
            lblpass.Visible = true;
            txtusername.Visible = false;
            txtpassword.Visible = false;
            btcancel.Visible = false;
            btsave.Visible = false;
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            txtemail.Enabled = true;
            btfind.Enabled = true;
            btreset.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            lblpass.Visible = false;
            lblusername.Visible = false;
            txtpassword.Visible = false;
            txtusername.Visible = false;
            btsave.Visible = false;
            btcancel.Visible = false;
            btedit.Visible = false;
        }
    }
}
