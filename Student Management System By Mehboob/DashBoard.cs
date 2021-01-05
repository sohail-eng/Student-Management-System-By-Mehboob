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
            txtsubjecturteacher.Items.Clear();
            txtteacherurid.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                txtsbtsnameadd.Items.Add(((teacherClass)list[i]).name);
                txtteacherurid.Items.Add(((teacherClass)list[i]).id);
                txtsubjecturteacher.Items.Add(((teacherClass)list[i]).name);
            }
        }

        private void showsubject()
        {
            ArrayList list = new ArrayList();
            list = myData.getSubjectData();
            showSubjectData(list);
            showsubjectlist();
            sb1show(list);
            sb2show(list);
            sb3show(list);
            sb4show(list);
            sb5show(list);
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
            txtsubjecturid.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                txtclasssb1add.Items.Add(((subjectClass)list[i]).name);
                txtclasssb2add.Items.Add(((subjectClass)list[i]).name);
                txtclasssb3add.Items.Add(((subjectClass)list[i]).name);
                txtclasssb4add.Items.Add(((subjectClass)list[i]).name);
                txtclasssb5add.Items.Add(((subjectClass)list[i]).name);
                txtsubjecturid.Items.Add(((subjectClass)list[i]).id);
            }
        }

        private void showClass()
        {
            ArrayList list = new ArrayList();
            list = myData.getClassData();
            showClassData(list);
            showclasslist();
        }

        private void showclasslist()
        {
            ArrayList list = new ArrayList();
            list = myData.getClassData();
            txtstudentaddclass.Items.Clear();
            txtclassurid.Items.Clear();
            txtstudenturclass.Items.Clear();
            for (int i=0;i<list.Count;i++)
            {
                txtstudentaddclass.Items.Add(((classClass)list[i]).name);
                txtclassurid.Items.Add(((classClass)list[i]).id);
                txtstudenturclass.Items.Add(((classClass)list[i]).name);
            }
        }

        private void showStudent()
        {
            ArrayList list = new ArrayList();
            list = myData.getstudentData();
            showStudentData(list);
            showstudentlist();
        }

        private void showstudentlist()
        {
            ArrayList list = new ArrayList();
            list = myData.getstudentData();
            txtstudenturid.Items.Clear();
            for(int i=0;i<list.Count;i++)
            {
                txtstudenturid.Items.Add(((studentClass)list[i]).id);
            }
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

        private void btstudentadd_Click(object sender, EventArgs e)
        {
            Boolean b = false;
            lblinfostudentadd.Visible =
                erstudentaddname.Visible =
                erstudentaddfname.Visible =
                erstudentaddemail.Visible =
                erstudentaddclass.Visible = false;
            lblinfostudentadd.Text = "Data Error !!!";
            if(txtstudentaddname.Text==String.Empty)
            {
                lblinfostudentadd.Visible =
                    erstudentaddname.Visible =
                    b = true;
            }
            if(txtstudentaddfname.Text==String.Empty)
            {
                lblinfostudentadd.Visible =
                    erstudentaddfname.Visible =
                    b = true;
            }
            if(txtstudentaddemail.Text==String.Empty)
            {
                lblinfostudentadd.Visible =
                    erstudentaddemail.Visible =
                    b = true;
            }
            if(txtstudentaddclass.Text==String.Empty)
            {
                lblinfostudentadd.Visible =
                    erstudentaddclass.Visible =
                    b = true;
            }
            if(b)
            {
                return;
            }

            ArrayList list = new ArrayList();
            list = myData.getstudentData();
            for(int i=0;i<list.Count;i++)
            {
                if(((studentClass)list[i]).name.ToLower().Equals(txtstudentaddname.Text.ToLower())
                    &&
                    ((studentClass)list[i]).fname.ToLower().Equals(txtstudentaddfname.Text.ToLower())
                    )
                {
                    lblinfostudentadd.Text = "Student Already Available !!!";
                    lblinfostudentadd.Visible =
                    erstudentaddname.Visible =
                    erstudentaddfname.Visible = true;
                    return;
                }
                if(((studentClass)list[i]).email.Equals(txtstudentaddemail.Text))
                {
                    lblinfostudentadd.Text = "E-Mail Already Registered !!!";
                    lblinfostudentadd.Visible =
                        erstudentaddemail.Visible = true;
                    return;
                }
            }

            if(!(myData.insertStudentData(txtstudentaddname.Text,txtstudentaddfname.Text,txtstudentaddemail.Text,txtstudentaddclass.Text)))
            {
                lblinfostudentadd.Text = "System Error !!!";
                lblinfostudentadd.Visible = true;
                return;
            }
            else
            {
                lblinfostudentadd.Text = "Data Added Successfully !!!";
                lblinfostudentadd.Visible = true;
                txtstudentaddname.Text =
                    txtstudentaddfname.Text =
                    txtstudentaddemail.Text = "";
                showclasslist();
                showStudent();
            }

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtteacherurid_SelectedIndexChanged(object sender, EventArgs e)
        {
            String id = txtteacherurid.Text;
            ArrayList list = new ArrayList();
            list = myData.getTeacherData();
            for(int i=0;i<list.Count;i++)
            {
                if(((teacherClass)list[i]).id.Equals(Convert.ToInt32(id)))
                {
                    lblteacherurhelp.Text=
                    txtteacherurname.Text = ((teacherClass)list[i]).name;
                    txtteacheruremail.Text = ((teacherClass)list[i]).email;
                }
            }
        }

        private void btteacherremove_Click(object sender, EventArgs e)
        {
            lblinfoteacherur.Visible =
                erteacherurid.Visible =
                erteacherurname.Visible =
                erteacheruremail.Visible = false;
            if(txtteacherurid.Text==String.Empty)
            {
                lblinfoteacherur.Text = "Please Select ID";
                lblinfoteacherur.Visible =
                    erteacherurid.Visible = true;
                return;
            }
            ArrayList list = new ArrayList();
            list = myData.getTeacherData();
            String id = "";
            String name = "";
            for(int i=0;i<list.Count;i++)
            {
                if(((teacherClass)list[i]).id.ToString().Equals(txtteacherurid.Text))
                {
                    id = txtteacherurid.Text;
                    name = ((teacherClass)list[i]).name;
                }
            }
            if (!(myData.updateSubjectteacher("",name)))
            {
                lblinfoteacherur.Text = "System Error !!!";
                lblinfoteacherur.Visible = true;
                return;
            }
            else
            {
                myData.removeTeacher(id);
                lblinfoteacherur.Text = "Data Removed Successfully !!!";
                lblinfoteacherur.Visible = true;
                txtteacherurname.Text =
                    txtteacheruremail.Text = "";
                showteacher();
                showsubject();
            }
        }

        private void btteacherupdate_Click(object sender, EventArgs e)
        {
            Boolean b = false;
            lblinfoteacherur.Visible =
                erteacherurid.Visible =
                erteacherurname.Visible =
                erteacheruremail.Visible = false;
            if (txtteacherurid.Text == String.Empty)
            {
                lblinfoteacherur.Text = "Please Select ID";
                lblinfoteacherur.Visible =
                    erteacherurid.Visible = true;
                return;
            }
            ArrayList list = new ArrayList();
            list = myData.getTeacherData();
            for(int i=0;i<list.Count;i++)
            {
                if(!(((teacherClass)list[i]).id.ToString().Equals(txtteacherurid.Text)))
                {
                    if(((teacherClass)list[i]).name.ToLower().Equals(txtteacherurname.Text.ToLower()))
                    {
                        lblinfoteacherur.Text = "Name Already Exist !!!";
                        lblinfoteacherur.Visible = true;
                        erteacherurname.Visible = true;
                        return;
                    }
                }
            }
            String id = txtteacherurid.Text;
            String name = txtteacherurname.Text;
            if (!(myData.updateSubjectteacher(name, lblteacherurhelp.Text)))
            {
                lblinfoteacherur.Text = "System Error !!!";
                lblinfoteacherur.Visible = true;
                return;
            }
            else
            {
                myData.updateteacher(id,txtteacherurname.Text,txtteacheruremail.Text);
                lblinfoteacherur.Text = "Data Updated Successfully !!!";
                lblinfoteacherur.Visible = true;
                txtteacherurname.Text =
                    txtteacheruremail.Text = "";
                showteacher();
                showsubject();
            }
        }

        private void txtsubjecturid_SelectedIndexChanged(object sender, EventArgs e)
        {
            String id = txtsubjecturid.Text;
            ArrayList list = new ArrayList();
            list = myData.getSubjectData();
            for(int i=0;i<list.Count;i++)
            {
                if(((subjectClass)list[i]).id.ToString().Equals(id))
                {
                    txtsubjecturname.Text = ((subjectClass)list[i]).name;
                    lblsubjecturhelp.Text = ((subjectClass)list[i]).name;
                    if(txtsubjecturteacher.Items.Contains(((subjectClass)list[i]).teacher_name))
                    {
                        txtsubjecturteacher.SelectedItem = ((subjectClass)list[i]).teacher_name;
                    }
                    else
                    {
                        showteacherlist();
                    }
                }
            }
        }

        private void btsubjecturremove_Click(object sender, EventArgs e)
        {
                ersubjecturid.Visible =
                ersubjecturname.Visible =
                ersubjecturteacher.Visible =
                lblinfosubjectur.Visible = false;
            if(txtsubjecturid.Text==String.Empty)
            {
                lblinfosubjectur.Text = "Please Select ID !!!";
                lblinfosubjectur.Visible = 
                ersubjecturid.Visible = true;
                return;
            }
            if(!(myData.removeSubject(txtsubjecturid.Text)))
            {
                lblinfosubjectur.Text = "System Error !!!";
                lblinfosubjectur.Visible = true;
                return;
            }
            else
            {
                myData.updateclasssubjectname("", lblsubjecturhelp.Text);
                lblinfosubjectur.Text = "Data Removed Successfully !!!";
                lblinfosubjectur.Visible = true;
                showsubject();
                showteacherlist();
                showClass();
                txtsubjecturname.Text = "";
            }
        }

        private void btsubjecturupdate_Click(object sender, EventArgs e)
        {
            Boolean b =
                lblinfosubjectur.Visible =
                ersubjecturid.Visible =
                ersubjecturname.Visible =
                ersubjecturteacher.Visible = false;
            if(txtsubjecturid.Text==String.Empty)
            {
                lblinfosubjectur.Text = "Please Select ID !!!";
                lblinfosubjectur.Visible =
                    ersubjecturid.Visible = true;
                return;
            }
            if(txtsubjecturname.Text==String.Empty)
            {
                lblinfosubjectur.Text = "Data Error !!!";
                lblinfosubjectur.Visible =
                    ersubjecturname.Visible =
                    b = true;
            }
            if(txtsubjecturteacher.Text==String.Empty)
            {
                lblinfosubjectur.Text = "Data Error !!!";
                b =
                    lblinfosubjectur.Visible =
                    ersubjecturteacher.Visible = true;
            }
            if(b)
            {
                return;
            }

            ArrayList list = new ArrayList();
            list = myData.getSubjectData();
            for(int i=0;i<list.Count;i++)
            {
                if(!(((subjectClass)list[i]).id.ToString().Equals(txtsubjecturid.Text)))
                {
                    if (((subjectClass)list[i]).name.ToLower().Equals(txtsubjecturname.Text.ToLower()))
                    {
                        lblinfosubjectur.Text = "Class Name Already Exist !!!";
                        lblinfosubjectur.Visible = true;
                        ersubjecturname.Visible = true;
                        return;
                    }
                }
            }

            if(!(myData.updateSubject(txtsubjecturid.Text,txtsubjecturname.Text,txtsubjecturteacher.Text)))
            {
                lblinfosubjectur.Text = "System Error !!!";
                lblinfosubjectur.Visible = true;
                return;
            }
            else
            {
                myData.updateclasssubjectname(txtsubjecturname.Text, lblsubjecturhelp.Text);
                lblinfosubjectur.Text = "Data Updated Successfully !!!";
                lblinfosubjectur.Visible = true;
                showsubject();
                showteacherlist();
                showClass();
                txtsubjecturname.Text = "";
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtclassurid_SelectedIndexChanged(object sender, EventArgs e)
        {
            String id = txtclassurid.Text;
            ArrayList list = new ArrayList();
            list = myData.getClassData();
            for(int i=0;i<list.Count;i++)
            {
                if(((classClass)list[i]).id.ToString().Equals(txtclassurid.Text))
                {
                    ArrayList listsb = new ArrayList();
                    listsb = myData.getSubjectData();
                    txtclassurname.Text = ((classClass)list[i]).name;
                    lblclassurhelp.Text = ((classClass)list[i]).name;
                    if (txtclassursb1add.Items.Contains(((classClass)list[i]).sb1))
                    {
                        txtclassursb1add.SelectedItem = ((classClass)list[i]).sb1;
                    }
                    else
                    {
                        sb1show(listsb);
                    }
                    if(txtclassursb2add.Items.Contains(((classClass)list[i]).sb2))
                    {
                        txtclassursb2add.SelectedItem = ((classClass)list[i]).sb2;
                    }
                    else
                    {
                        sb2show(listsb);
                    }
                    if(txtclassursb3add.Items.Contains(((classClass)list[i]).sb3))
                    {
                        txtclassursb3add.SelectedItem = ((classClass)list[i]).sb3;
                    }
                    else
                    {
                        sb3show(listsb);
                    }
                    if(txtclassursb4add.Items.Contains(((classClass)list[i]).sb4))
                    {
                        txtclassursb4add.SelectedItem = ((classClass)list[i]).sb4;
                    }
                    else
                    {
                        sb4show(listsb);
                    }
                    if(txtclassursb5add.Items.Contains(((classClass)list[i]).sb5))
                    {
                        txtclassursb5add.SelectedItem = ((classClass)list[i]).sb5;
                    }
                    else
                    {
                        sb5show(listsb);
                    }

                    txtclassursb1add.Enabled =
                        txtclassursb2add.Enabled =
                        txtclassursb3add.Enabled =
                        txtclassursb4add.Enabled =
                        txtclassursb5add.Enabled = false;
                }
            }
        }

        private void sb1show(ArrayList list)
        {
            txtclassursb1add.Items.Clear();
            for(int i=0;i<list.Count;i++)
            {
                txtclassursb1add.Items.Add(((subjectClass)list[i]).name);
            }
        }

        private void sb2show(ArrayList list)
        {
            txtclassursb2add.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                txtclassursb2add.Items.Add(((subjectClass)list[i]).name);
            }
        }

        private void sb3show(ArrayList list)
        {
            txtclassursb3add.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                txtclassursb3add.Items.Add(((subjectClass)list[i]).name);
            }
        }

        private void sb4show(ArrayList list)
        {
            txtclassursb4add.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                txtclassursb4add.Items.Add(((subjectClass)list[i]).name);
            }
        }

        private void sb5show(ArrayList list)
        {
            txtclassursb5add.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                txtclassursb5add.Items.Add(((subjectClass)list[i]).name);
            }
        }

        private void btclassurrefreh_Click(object sender, EventArgs e)
        {
            txtclassursb1add.Enabled =
                        txtclassursb2add.Enabled =
                        txtclassursb3add.Enabled =
                        txtclassursb4add.Enabled =
                        txtclassursb5add.Enabled = true;

            showsubject();
        }

        private void txtclassursb1add_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = txtclassursb1add.Text;
            txtclassursb1add.Enabled = false;
            if (txtclassursb2add.Enabled)
            {
                txtclassursb2add.Items.Remove(name);
            }
            if (txtclassursb3add.Enabled)
            {
                txtclassursb3add.Items.Remove(name);
            }
            if (txtclassursb4add.Enabled)
            {
                txtclassursb4add.Items.Remove(name);
            }
            if (txtclassursb5add.Enabled)
            {
                txtclassursb5add.Items.Remove(name);
            }
        }

        private void txtclassursb2add_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = txtclassursb2add.Text;
            txtclassursb2add.Enabled = false;
            if (txtclassursb1add.Enabled)
            {
                txtclassursb1add.Items.Remove(name);
            }
            if (txtclassursb3add.Enabled)
            {
                txtclassursb3add.Items.Remove(name);
            }
            if (txtclassursb4add.Enabled)
            {
                txtclassursb4add.Items.Remove(name);
            }
            if (txtclassursb5add.Enabled)
            {
                txtclassursb5add.Items.Remove(name);
            }
        }

        private void txtclassursb3add_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = txtclassursb3add.Text;
            txtclassursb3add.Enabled = false;
            if (txtclassursb2add.Enabled)
            {
                txtclassursb2add.Items.Remove(name);
            }
            if (txtclassursb1add.Enabled)
            {
                txtclassursb1add.Items.Remove(name);
            }
            if (txtclassursb4add.Enabled)
            {
                txtclassursb4add.Items.Remove(name);
            }
            if (txtclassursb5add.Enabled)
            {
                txtclassursb5add.Items.Remove(name);
            }
        }

        private void txtclassursb4add_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = txtclassursb4add.Text;
            txtclassursb4add.Enabled = false;
            if (txtclassursb2add.Enabled)
            {
                txtclassursb2add.Items.Remove(name);
            }
            if (txtclassursb3add.Enabled)
            {
                txtclassursb3add.Items.Remove(name);
            }
            if (txtclassursb1add.Enabled)
            {
                txtclassursb1add.Items.Remove(name);
            }
            if (txtclassursb5add.Enabled)
            {
                txtclassursb5add.Items.Remove(name);
            }
        }

        private void txtclassursb5add_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = txtclassursb5add.Text;
            txtclassursb5add.Enabled = false;
            if (txtclassursb2add.Enabled)
            {
                txtclassursb2add.Items.Remove(name);
            }
            if (txtclassursb3add.Enabled)
            {
                txtclassursb3add.Items.Remove(name);
            }
            if (txtclassursb4add.Enabled)
            {
                txtclassursb4add.Items.Remove(name);
            }
            if (txtclassursb1add.Enabled)
            {
                txtclassursb1add.Items.Remove(name);
            }
        }

        private void btclassurremove_Click(object sender, EventArgs e)
        {
            lblinfoclassur.Visible =
                erclassurid.Visible =
                erclassurname.Visible =
                erclassursubject.Visible = false;
            if(txtclassurid.Text==String.Empty)
            {
                lblinfoclassur.Text = "Please Select ID";
                lblinfoclassur.Visible =
                    erclassurid.Visible = true;
                return;
            }
            
            if(!(myData.removeClass(txtclassurid.Text)))
            {
                lblinfoclassur.Text = "System Error !!!";
                lblinfoclassur.Visible = true;
                return;
            }
            else
            {
                myData.updateStudentclass(lblclassurhelp.Text, "");
                lblinfoclassur.Text = "Data Removed Successfully !!!";
                lblinfoclassur.Visible = true;

                showClass();
                showsubjectlist();
                showStudent();
                txtclassurname.Text = "";
            }
        }

        private void btclassurupdate_Click(object sender, EventArgs e)
        {
            Boolean b =
                lblinfoclassur.Visible =
                erclassurid.Visible =
                erclassurname.Visible =
                erclassursubject.Visible = false;
            if(txtclassurid.Text==String.Empty)
            {
                lblinfoclassur.Text = "Please Select ID !!!";
                lblinfoclassur.Visible =
                    b =
                    erclassurid.Visible = true;
                return;
            }
            if(txtclassurname.Text==String.Empty)
            {
                lblinfoclassur.Text = "Data Error !!!";
                b =
                    lblinfoclassur.Visible =
                    erclassurname.Visible = true;
            }
            if(txtclassursb1add.Text == String.Empty &&
                txtclassursb2add.Text == String.Empty &&
                txtclassursb3add.Text == String.Empty &&
                txtclassursb4add.Text == String.Empty &&
                txtclassursb5add.Text == String.Empty)
            {
                lblinfoclassur.Text = "Data Error !!!";
                b =
                    lblinfoclassur.Visible =
                    erclassursubject.Visible = true;
            }
            if(b)
            {
                return;
            }

            ArrayList list = new ArrayList();
            list = myData.getClassData();
            for(int i=0;i<list.Count;i++)
            {
                if(!(((classClass)list[i]).id.ToString().Equals(txtclassurid.Text)))
                {
                    if(((classClass)list[i]).name.ToLower().Equals(txtclassurname.Text.ToLower()))
                    {
                        lblinfoclassur.Text = "Class Already Exist !!!";
                        lblinfoclassur.Visible =
                            erclassurname.Visible = true;
                        return;
                    }
                }
            }
           if(!(myData.updateclass(txtclassurid.Text,txtclassurname.Text,txtclassursb1add.Text,txtclassursb2add.Text,txtclassursb3add.Text,txtclassursb4add.Text,txtclassursb5add.Text)))
            {
                lblinfoclassur.Text = "System Error !!!";
                lblinfoclassur.Visible = true;
                return;
            }
           else
            {
                myData.updateStudentclass(lblclassurhelp.Text, txtclassurname.Text);
                lblinfoclassur.Text = "Data Updated Successfully !!!";
                lblinfoclassur.Visible = true;
                showClass();
                showsubjectlist();
                showStudent();
                txtclassurname.Text = "";
            }
        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }

        private void txtstudenturid_SelectedIndexChanged(object sender, EventArgs e)
        {
            String id = txtstudenturid.Text;
            ArrayList list = new ArrayList();
            list = myData.getstudentData();
            for(int i=0;i<list.Count;i++)
            {
                if(((studentClass)list[i]).id.ToString().Equals(txtstudenturid.Text))
                {
                    txtstudenturname.Text = ((studentClass)list[i]).name;
                    txtstudenturfname.Text = ((studentClass)list[i]).fname;
                    txtstudenturemail.Text = ((studentClass)list[i]).email;
                    if(txtstudenturclass.Items.Contains(((studentClass)list[i]).cname))
                    {
                        txtstudenturclass.SelectedItem = ((studentClass)list[i]).cname;
                    }
                    else
                    {
                        showclasslist();
                    }
                }
            }
        }

        private void btstudenturremove_Click(object sender, EventArgs e)
        {
            lblinfostudentur.Visible =
                erstudenturid.Visible =
                erstudenturname.Visible =
                erstudenturfname.Visible =
                erstudenturemail.Visible =
                erstudenturclass.Visible = false;
            if(txtstudenturid.Text==String.Empty)
            {
                lblinfostudentur.Text = "Please Select ID !!!";
                lblinfostudentur.Visible =
                    erstudenturid.Visible = true;
                return;
            }
            if(!(myData.removeStudent(txtstudenturid.Text)))
            {
                lblinfostudentur.Text = "System Error !!!";
                lblinfostudentur.Visible = true;
                return;
            }
            else
            {
                lblinfostudentur.Text = "Data Removed Successfully !!!";
                lblinfostudentur.Visible = true;
                showStudent();
                showclasslist();
                txtstudenturname.Text = "";
                txtstudenturfname.Text = "";
                txtstudenturemail.Text = "";
            }
        }

        private void btstudenturupdate_Click(object sender, EventArgs e)
        {
            Boolean b =
                lblinfostudentur.Visible =
                erstudenturid.Visible =
                erstudenturname.Visible =
                erstudenturfname.Visible =
                erstudenturemail.Visible =
                erstudenturclass.Visible = false;
            if(txtstudenturid.Text==String.Empty)
            {
                lblinfostudentur.Text = "Please Select ID !!!";
                lblinfostudentur.Visible =
                    erstudenturid.Visible = true;
                return;
            }
            if(txtstudenturname.Text==String.Empty)
            {
                lblinfostudentur.Text = "Data Error !!!";
                lblinfostudentur.Visible =
                    b =
                    erstudenturname.Visible = true;
            }
            if(txtstudenturfname.Text==String.Empty)
            {
                lblinfostudentur.Text = "Data Error !!!";
                b =
                    lblinfostudentur.Visible =
                    erstudenturfname.Visible = true;
            }
            if(txtstudenturemail.Text==String.Empty)
            {
                lblinfostudentur.Text = "Data Error !!!";
                b =
                    lblinfostudentur.Visible =
                    erstudenturemail.Visible = true;
            }
            if(txtstudenturclass.Text==String.Empty)
            {
                lblinfostudentur.Text = "Data Error !!!";
                b =
                    lblinfostudentur.Visible =
                    erstudenturclass.Visible = true;
            }
            if(b)
            {
                return;
            }
            ArrayList list = new ArrayList();
            list = myData.getstudentData();
            for(int i=0;i<list.Count;i++)
            {
                if(((studentClass)list[i]).name.ToLower().Equals(txtstudenturname.Text)
                    &&
                    ((studentClass)list[i]).fname.ToLower().Equals(txtstudenturfname.Text))
                {
                    lblinfostudentur.Text = "Student Name Already Exist !!!";
                    lblinfostudentur.Visible =
                        erstudenturfname.Visible=
                        erstudenturname.Visible = true;
                    return;
                }
                if(((studentClass)list[i]).email.Equals(txtstudenturemail.Text))
                {
                    lblinfostudentur.Text = "Email Already Exist !!!";
                    lblinfostudentur.Visible =
                        erstudenturemail.Visible = true;
                }
            }

            if(!(myData.updateStudent(txtstudenturid.Text,txtstudenturname.Text,txtstudenturfname.Text,txtstudenturemail.Text,txtstudenturclass.Text)))
            {
                lblinfostudentur.Text = "System Error !!!";
                lblinfostudentur.Visible = true;
                return;
            }
            else
            {
                lblinfostudentur.Text = "Data Updated SuccessFully !!!";
                lblinfostudentur.Visible = true;
                showStudent();
                showclasslist();
                txtstudenturname.Text = "";
                txtstudenturfname.Text = "";
                txtstudenturemail.Text = "";
            }
        }
    }
}