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
        }

        private void showsubject()
        {
            ArrayList list = new ArrayList();
            list = myData.getSubjectData();
            showSubjectData(list);
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
        }
    }
}
