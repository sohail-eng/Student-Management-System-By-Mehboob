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
    public partial class Signup : Form
    {
        MyData myData;
        Form1 f;
        ProductKey p;
        public Signup(Form1 f,ProductKey p)
        {
            InitializeComponent();
            this.f = f;
            this.p = p;
            myData = new MyData();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            p.Close();
            f.Show();
            f.loadData();
        }

        private void btsignup_Click(object sender, EventArgs e)
        {
            Boolean b = false;
            lblinfo.Text = "Data Error";
            lblinfo.Visible = false;
            erusername.Visible = false;
            eremail.Visible = false;
            erpass.Visible = false;
            ercpass.Visible = false;
            if (txtusername.Text==String.Empty)
            {
                lblinfo.Visible = true;
                erusername.Visible = true;
                b = true;
            }
            if(txtemail.Text==String.Empty)
            {
                lblinfo.Visible = true;
                eremail.Visible = true;
                b = true;
            }
            if(txtpassword.Text==String.Empty)
            {
                lblinfo.Visible = true;
                erpass.Visible = true;
                b = true;
            }
            if(txtcpassword.Text==String.Empty)
            {
                lblinfo.Visible = true;
                ercpass.Visible = true;
                b = true;
            }
            if(b)
            {
                return;
            }
            ArrayList list = new ArrayList();
            list = myData.getAdminData();
            for(int i=0;i<list.Count;i++)
            {
                if((((adminClass)list[i]).name.Equals(txtusername.Text)))
                {
                    lblinfo.Text = "User Name Already Available !!!";
                    lblinfo.Visible = true;
                    erusername.Visible = true;
                    return;
                }
                if((((adminClass)list[i]).email.Equals(txtemail.Text)))
                {
                    lblinfo.Text = "E-Mail Already Available !!!";
                    lblinfo.Visible = true;
                    eremail.Visible = true;
                    return;
                }
            }
            if(!(txtpassword.Text.Equals(txtcpassword.Text)))
            {
                lblinfo.Text = "Password Does Not Match !!!";
                lblinfo.Visible = true;
                erpass.Visible = true;
                ercpass.Visible = true;
                return;
            }
            if(!(myData.insertAdminData(txtusername.Text,txtemail.Text,txtpassword.Text)))
            {
                lblinfo.Text = "System Error !!!";
                lblinfo.Visible = true;
            }
            else
            {
                lblinfo.Text = "Data Added Successfully !!!";
                lblinfo.Visible = true;
                txtusername.Text = "";
                txtemail.Text = "";
                txtpassword.Text = "";
                txtcpassword.Text = "";
            }
        }
    }
}
