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
    public partial class DashBoard : Form
    {
        Form1 f;
        String adminname;
        MyData myData;
        public DashBoard(Form1 f,String adminname)
        {
            InitializeComponent();
            this.f = f;
            this.adminname = adminname;
            myData = new MyData();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            this.lbladminname.Text = adminname;
            showteacher();
            showsubject();
            showClass();
            showStudent();
        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Show();
        }

        private void showteacher()
        {
            ArrayList list = new ArrayList();
            list = myData.getTeacherData();
            showTeacherData(list);
            showteacherlist();
        }

        private void showteacherlist()
        {
            ArrayList list = new ArrayList();
            list = myData.getTeacherData();
            txtsbtsnameadd.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                txtsbtsnameadd.Items.Add(((teacherClass)list[i]).name);
            }
        }

        private void showsubject()
        {
            ArrayList list = new ArrayList();
            list = myData.getSubjectData();
            showSubjectData(list);
            showsubjectlist();
        }

        private void showsubjectlist()
        {
            ArrayList list = new ArrayList();
            list = myData.getSubjectData();
            txtclasssb1add.Items.Clear();
            txtclasssb2add.Items.Clear();
            txtclasssb3add.Items.Clear();
            txtclasssb4add.Items.Clear();
            txtclasssb5add.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                txtclasssb1add.Items.Add(((subjectClass)list[i]).name);
                txtclasssb2add.Items.Add(((subjectClass)list[i]).name);
                txtclasssb3add.Items.Add(((subjectClass)list[i]).name);
                txtclasssb4add.Items.Add(((subjectClass)list[i]).name);
                txtclasssb5add.Items.Add(((subjectClass)list[i]).name);
            }
        }

        private void showClass()
        {
            ArrayList list = new ArrayList();
            list = myData.getClassData();
            showClassData(list);
        }

        private void showStudent()
        {
            ArrayList list = new ArrayList();
            list = myData.getstudentData();
            showStudentData(list);
        }

        private void showTeacherData(ArrayList list)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("E-Mail");
            for(int i=0;i<list.Count;i++)
            {
                table.Rows.Add(
                    ((teacherClass)list[i]).id,
                    ((teacherClass)list[i]).name,
                    ((teacherClass)list[i]).email
                    );
            }
            dataGridViewTeacher.DataSource = table;
            dataGridViewTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTeacher.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTeacher.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTeacher.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(0, 190, 120);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void showSubjectData(ArrayList list)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Teacher Name");
            for (int i = 0; i < list.Count; i++)
            {
                table.Rows.Add(
                    ((subjectClass)list[i]).id,
                    ((subjectClass)list[i]).name,
                    ((subjectClass)list[i]).teacher_name
                    );
            }
            dataGridViewSubject.DataSource = table;
            dataGridViewSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSubject.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSubject.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSubject.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(0, 190, 120);
        }

        private void showClassData(ArrayList list)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Subject 1");
            table.Columns.Add("Subject 2");
            table.Columns.Add("Subject 3");
            table.Columns.Add("Subject 4");
            table.Columns.Add("Subject 5");
            for (int i = 0; i < list.Count; i++)
            {
                table.Rows.Add(
                    ((classClass)list[i]).id,
                    ((classClass)list[i]).name,
                    ((classClass)list[i]).sb1,
                    ((classClass)list[i]).sb2,
                    ((classClass)list[i]).sb3,
                    ((classClass)list[i]).sb4,
                    ((classClass)list[i]).sb5
                    );
            }
            dataGridViewClass.DataSource = table;
            dataGridViewClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClass.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewClass.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewClass.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(0, 190, 120);
        }

        private void showStudentData(ArrayList list)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Father Name");
            table.Columns.Add("E-Mail");
            table.Columns.Add("Class");
            for (int i = 0; i < list.Count; i++)
            {
                table.Rows.Add(
                    ((studentClass)list[i]).id,
                    ((studentClass)list[i]).name,
                    ((studentClass)list[i]).fname,
                    ((studentClass)list[i]).email,
                    ((studentClass)list[i]).cname
                    );
            }
            dataGridViewStudent.DataSource = table;
            dataGridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewStudent.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewStudent.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(0, 190, 120);
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            Boolean b = false;
            lblinfo.Visible = false;
            ername.Visible = false;
            eremail.Visible = false;
            if(txtname.Text==String.Empty)
            {
                ername.Visible = true;
                lblinfo.Text = "Data Error !!!";
                lblinfo.Visible = true;
                b = true;
            }
            if(txtemail.Text==String.Empty)
            {
                eremail.Visible = true;
                lblinfo.Text = "Data Error !!!";
                lblinfo.Visible = true;
                b = true;
            }
            if(b)
            {
                return;
            }

            ArrayList list = new ArrayList();
            list = myData.getTeacherData();
            for(int i=0;i<list.Count;i++)
            {
                if(((teacherClass)list[i]).name.ToLower().Equals(txtname.Text.ToLower()))
                {
                    lblinfo.Text = "Teacher Name Already Exist !!!";
                    lblinfo.Visible = true;
                    ername.Visible = true;
                    return;
                }
                if(((teacherClass)list[i]).email.Equals(txtemail.Text))
                {
                    lblinfo.Text = "Email Already Registered !!!";
                    lblinfo.Visible = true;
                    eremail.Visible = true;
                    return;
                }
            }

            if(!(myData.insertTeacherData(txtname.Text,txtemail.Text)))
            {
                lblinfo.Text = "System Error !!!";
                lblinfo.Visible = true;
                return;
            }
            else
            {
                lblinfo.Text = "Data Added SuccessFully !!!";
                lblinfo.Visible = true;
                txtname.Text = "";
                txtemail.Text = "";
                showteacher();
            }

        }

        private void btsbadd_Click(object sender, EventArgs e)
        {
            Boolean b =
            ernamesbadd.Visible =
                ertsnamesbadd.Visible =
                lblinfosbadd.Visible = false;
            if (txtsbnameadd.Text == String.Empty)
            {
                lblinfosbadd.Text = "Data Error !!!";
                lblinfosbadd.Visible =
                    ernamesbadd.Visible =
                    b = true;
            }
            if(txtsbtsnameadd.Text==String.Empty)
            {
                lblinfosbadd.Text = "Data Error !!!";
                lblinfosbadd.Visible =
                    ertsnamesbadd.Visible =
                    b = true;
            }
            if(b)
            {
                return;
            }
            ArrayList list = new ArrayList();
            list = myData.getSubjectData();
            for(int i=0;i<list.Count;i++)
            {
                if(((subjectClass)list[i]).name.ToLower().Equals(txtsbnameadd.Text.ToLower()))
                {
                    lblinfosbadd.Text = "Subject Already Registered !!!";
                    lblinfosbadd.Visible =
                        ernamesbadd.Visible = true;
                    return;
                }
            }
            if(!(myData.insertSubjectData(txtsbnameadd.Text,txtsbtsnameadd.Text)))
            {
                lblinfosbadd.Text = "System Error !!!";
                lblinfosbadd.Visible = true;
            }
            else
            {
                lblinfosbadd.Text = "Data Added Successfully !!!";
                lblinfosbadd.Visible = true;
                txtsbnameadd.Text = "";
                showteacherlist();
                showsubject();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtclasssb1add_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = txtclasssb1add.Text;
            txtclasssb1add.Enabled = false;
            if(txtclasssb2add.Enabled)
            {
                txtclasssb2add.Items.Remove(name);
            }
            if(txtclasssb3add.Enabled)
            {
                txtclasssb3add.Items.Remove(name);
            }
            if(txtclasssb4add.Enabled)
            {
                txtclasssb4add.Items.Remove(name);
            }
            if(txtclasssb5add.Enabled)
            {
                txtclasssb5add.Items.Remove(name);
            }
        }

        private void txtclasssb2add_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = txtclasssb2add.Text;
            txtclasssb2add.Enabled = false;
            if (txtclasssb1add.Enabled)
            {
                txtclasssb1add.Items.Remove(name);
            }
            if (txtclasssb3add.Enabled)
            {
                txtclasssb3add.Items.Remove(name);
            }
            if (txtclasssb4add.Enabled)
            {
                txtclasssb4add.Items.Remove(name);
            }
            if (txtclasssb5add.Enabled)
            {
                txtclasssb5add.Items.Remove(name);
            }
        }

        private void txtclasssb3add_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = txtclasssb3add.Text;
            txtclasssb3add.Enabled = false;
            if (txtclasssb1add.Enabled)
            {
                txtclasssb1add.Items.Remove(name);
            }
            if (txtclasssb2add.Enabled)
            {
                txtclasssb2add.Items.Remove(name);
            }
            if (txtclasssb4add.Enabled)
            {
                txtclasssb4add.Items.Remove(name);
            }
            if (txtclasssb5add.Enabled)
            {
                txtclasssb5add.Items.Remove(name);
            }
        }

        private void txtclasssb4add_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = txtclasssb4add.Text;
            txtclasssb4add.Enabled = false;
            if (txtclasssb1add.Enabled)
            {
                txtclasssb1add.Items.Remove(name);
            }
            if (txtclasssb2add.Enabled)
            {
                txtclasssb2add.Items.Remove(name);
            }
            if (txtclasssb3add.Enabled)
            {
                txtclasssb3add.Items.Remove(name);
            }
            if (txtclasssb5add.Enabled)
            {
                txtclasssb5add.Items.Remove(name);
            }
        }

        private void txtclasssb5add_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = txtclasssb5add.Text;
            txtclasssb5add.Enabled = false;
            if (txtclasssb1add.Enabled)
            {
                txtclasssb1add.Items.Remove(name);
            }
            if (txtclasssb2add.Enabled)
            {
                txtclasssb2add.Items.Remove(name);
            }
            if (txtclasssb3add.Enabled)
            {
                txtclasssb3add.Items.Remove(name);
            }
            if (txtclasssb4add.Enabled)
            {
                txtclasssb4add.Items.Remove(name);
            }
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            txtclasssb1add.Enabled =
                txtclasssb2add.Enabled =
                txtclasssb3add.Enabled =
                txtclasssb4add.Enabled =
                txtclasssb5add.Enabled = true;
            showsubjectlist();
        }

        private void btclassadd_Click(object sender, EventArgs e)
        {
            Boolean b = false;
            lblinfoclassadd.Visible =
                erclassnameadd.Visible =
                erclasssbadd.Visible = false;
            if(txtclassnameadd.Text==String.Empty)
            {
                lblinfoclassadd.Text = "Please Enter Class Name !!!";
                lblinfoclassadd.Visible = true;
                erclassnameadd.Visible = true;
                return;
            }
            if(txtclasssb1add.Text==String.Empty&&
                txtclasssb2add.Text==String.Empty&&
                txtclasssb3add.Text==String.Empty&&
                txtclasssb4add.Text==String.Empty&&
                txtclasssb5add.Text==String.Empty
                )
            {
                lblinfoclassadd.Text = "Please Choose At least 1 Subject !!!";
                lblinfoclassadd.Visible = true;
                erclasssbadd.Visible = true;
                return;
            }
            ArrayList list = new ArrayList();
            list = myData.getClassData();
            for(int i=0;i<list.Count;i++)
            {
                if(((classClass)list[i]).name.ToLower().Equals(txtclassnameadd.Text.ToLower()))
                {
                    lblinfoclassadd.Text = "Class Already Exist !!!";
                    lblinfoclassadd.Visible = true;
                    return;
                }
            }
            if(!(myData.insertClassData(txtclassnameadd.Text,txtclasssb1add.Text,txtclasssb2add.Text,txtclasssb3add.Text,txtclasssb4add.Text,txtclasssb5add.Text)))
            {
                lblinfoclassadd.Text = "System Error !!!";
                lblinfoclassadd.Visible = true;
                return;
            }
            else
            {
                lblinfoclassadd.Text = "Data Added Successfully !!!";
                lblinfoclassadd.Visible = true;
                txtclassnameadd.Text = "";
                showsubjectlist();
                showClass();
            }
        }
    }
}
