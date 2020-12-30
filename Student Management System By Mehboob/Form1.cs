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
    public partial class Form1 : Form
    {
        MyData myData;
        public Form1()
        {
            InitializeComponent();
            myData = new MyData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            ArrayList list = new ArrayList();
            list = myData.getAdminData();
            boxname.Items.Clear();
            for(int i=0;i<list.Count;i++)
            {
                boxname.Items.Add(((adminClass)list[i]).name);
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            erorname.Visible = false;
            errorpass.Visible = false ;
            ArrayList list = new ArrayList();
            list = myData.getAdminData();
            for(int i=0;i<list.Count;i++)
            {
                if(((adminClass)list[i]).name.Equals(boxname.Text))
                {
                    if(((adminClass)list[i]).pass.Equals(txtpass.Text))
                    {
                        MessageBox.Show("Login Successfully !!!");
                        return;
                    }
                    else
                    {
                        errorpass.Visible = true;
                        MessageBox.Show("Wrong Password !!!");
                        return;
                    }
                }
            }
            erorname.Visible = true;
            MessageBox.Show("Please Select User Name  !!!");
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forgetpassword f = new forgetpassword(this);
            this.Hide();
            f.Show();
        }
    }
}
