using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Student_Management_System_By_Mehboob
{
    class MyData
    {
        SqlConnection con;
        SqlCommand cmd;
        String query;
        public MyData()
        {
            String conString = "";
            query = "";
            con = new SqlConnection(conString);
        }

        public Boolean insertAdminData(String name,String email,String pass)
        {
            return executeQuery("insert into [admin] ([name],[email],[password]) values ('" + name + "','" + email + "','" + pass + "')");
        }

        public Boolean updateAdminData(String email,String pass)
        {
            return executeQuery("update [admin] set [password]='" + pass + "' where [email]='" + email + "'");
        }

        public Boolean removeAdminData(String email)
        {
            return executeQuery("delete from [admin] where [email]='" + email + "'");
        }

        public ArrayList getAdminData()
        {
            ArrayList list = new ArrayList();
            query = "select [id],[name],[email],[password] from [admin]";
            cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                using(SqlDataReader reader=cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        adminClass admin = new adminClass();
                        admin.id = Convert.ToInt32(reader.GetValue(0));
                        admin.name = Convert.ToString(reader.GetValue(1));
                        admin.email = Convert.ToString(reader.GetValue(2));
                        admin.pass = Convert.ToString(reader.GetValue(3));
                        list.Add(admin);
                    }
                }
                con.Close();
            }
            catch
            {
                con.Close();
            }

            return list;
        }

        public Boolean insertTeacherData(String name,String email)
        {
            return executeQuery("insert into[teacher]([name],[email]) values('" + name + "', '" + email + "')");
        }

        private Boolean executeQuery(String query)
        {
            Boolean b = true;
            con.Open();
            cmd = new SqlCommand(query, con);
            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                b = false;
                con.Close();
            }
            return b;
        }

        public Boolean updateTeacherDataName(String name,String email)
        {
            return executeQuery("update [teacher] set [name]='" + name + "' where [email]='" + email + "'");
            
        }

        public Boolean upDateTeacherDataEmail(String name,String email)
        {
            return executeQuery("update [teacher] set [email]='" + email + "' where [name]='" + name + "'");
        }

        public Boolean removeTeacherDataName(String name)
        {
            return executeQuery("delete from [teacher] where [name]='" + name + "'");
        }

        public Boolean removeTeacherDataEmail(String email)
        {
            return executeQuery("delete from [teacher] where [email]='" + email + "'");
        }

        public ArrayList getTeacherData()
        {
            ArrayList list = new ArrayList();
            query = "select [id],[name],[email] from [teacher]";
            cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                using(SqlDataReader reader=cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        teacherClass teacher = new teacherClass();
                        teacher.id = Convert.ToInt32(reader.GetValue(0));
                        teacher.name = Convert.ToString(reader.GetValue(1));
                        teacher.email = Convert.ToString(reader.GetValue(2));
                        list.Add(teacher);
                    }
                    con.Close();
                }
            }
            catch
            {
                con.Close();
            }
            return list;
        }

        public Boolean insertSubjectData(String name,String teacherName)
        {
            return executeQuery("insert into [subject] ([name],[teacher_Name]) values ('" + name + "','" + teacherName + "')");
        }

        public Boolean updateSubjectDataName(String name,String teacherName)
        {
            return executeQuery("update [subject] set [teacher_Name]='"+teacherName+"' where [name]='"+name+"'");
        }

        public Boolean updateSubjectDataTeacherName(String newTeachername,String teacherName)
        {
            return executeQuery("update [subject] set [teacher_Name]='"+newTeachername+"' where [teacher_Name]='"+teacherName+"'");
        }

        public Boolean removeSubjectDataName(String name)
        {
            return executeQuery("delete from [subject] where [name]='" + name + "'");
        }

        public Boolean removeSubjectDataTeacherName(String teacherName)
        {
            return executeQuery("delete from [subject] where [teacher_Name]='" + teacherName + "'");
        }

        public ArrayList getSubjectData()
        {
            ArrayList list = new ArrayList();
            query = "select [id],[name],[teacher_Name] from [subject]";
            cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjectClass subject = new subjectClass();
                        subject.id = Convert.ToInt32(reader.GetValue(0));
                        subject.name = Convert.ToString(reader.GetValue(1));
                        subject.teacher_name = Convert.ToString(reader.GetValue(2));
                        list.Add(subject);
                    }
                    con.Close();
                }
            }
            catch
            {
                con.Close();
            }
            return list;
        }

        public Boolean insertClassData(String name,String sb1,String sb2,String sb3,String sb4,String sb5)
        {
            return executeQuery("insert into [class] ([name],[subject1],[subject2],[subject3],[subject4],[subject5]) values ('" + name + "','" + sb1 + "','" + sb2 + "','" + sb3 + "','" + sb4 + "','" + sb5 + "')");
        }

        public Boolean updateClassData(String name,String sb1,String sb2,String sb3,String sb4,String sb5)
        {
            return executeQuery("update [class] set [subject1]='"+sb1+"',[subject2]='"+sb2+"',[subject3]='"+sb3+"',[subject4]='"+sb4+"',[subject5]='"+sb5+"' where [name]='"+name+"'");
        }

        public Boolean updateClassName(String newname,String name)
        {
            return executeQuery("update [class] set [name]='" + newname + "' where [name]='" + name + "'");
        }

        public Boolean removeClassData(String name)
        {
            return executeQuery("delete from [class] where [name]='" + name + "'");
        }

        public ArrayList getClassData()
        {
            ArrayList list = new ArrayList();
            query = "select [id],[name],[subject1],[subject2],[subject3],[subject4],[subject5] from [class]";
            cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        classClass myclass = new classClass();
                        myclass.id = Convert.ToInt32(reader.GetValue(0));
                        myclass.name = Convert.ToString(reader.GetValue(1));
                        myclass.sb1 = Convert.ToString(reader.GetValue(2));
                        myclass.sb2 = Convert.ToString(reader.GetValue(3));
                        myclass.sb3 = Convert.ToString(reader.GetValue(4));
                        myclass.sb4 = Convert.ToString(reader.GetValue(5));
                        myclass.sb5 = Convert.ToString(reader.GetValue(6));
                        list.Add(myclass);
                    }
                    con.Close();
                }
            }
            catch
            {
                con.Close();
            }
            return list;
        }

        public Boolean insertStudentData(String name,String fname,String email,String cname)
        {
            return executeQuery("insert into [student] ([name],[Father Name],[email],[class Name])  values ('" + name + "','" + fname + "','" + email + "','" + cname + "')");
        }

        public Boolean updateStudentData(String name,String fname,String email,String cname)
        {
            return executeQuery("update [student] set [name]='" + name + "',[Father Name]='" + fname + "',[class Name]='" + cname + "' where [email]='" + email + "'");
        }

        public Boolean updateStudentEmail(String name,String fname,String email)
        {
            return executeQuery("update [student] set [email]='" + email + "' where [name]='" + name + "' and [Father Name]='" + fname + "'");
        }

        public Boolean removeStudentData(String email)
        {
            return executeQuery("delete from [student] where [email]='" + email + "'");
        }

        public ArrayList getstudentData()
        {
            ArrayList list = new ArrayList();
            query = "select [id],[name],[Father Name],[email],[class Name] from [student]";
            cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        studentClass student = new studentClass();
                        student.id = Convert.ToInt32(reader.GetValue(0));
                        student.name = Convert.ToString(reader.GetValue(1));
                        student.fname = Convert.ToString(reader.GetValue(2));
                        student.email = Convert.ToString(reader.GetValue(3));
                        student.cname = Convert.ToString(reader.GetValue(4));
                        list.Add(student);
                    }
                    con.Close();
                }
            }
            catch
            {
                con.Close();
            }
            return list;
        }
    }

    public class adminClass
    {
        public int id;
        public String name;
        public String email;
        public String pass;
    }

    public class teacherClass
    {
        public int id;
        public String name;
        public String email;
    }

    public class subjectClass
    {
        public int id;
        public String name;
        public String teacher_name;
    }

    public class studentClass
    {
        public int id;
        public String name;
        public String fname;
        public String email;
        public String cname;
    }

    public class classClass
    {
        public int id;
        public String name;
        public String sb1;
        public String sb2;
        public String sb3;
        public String sb4;
        public String sb5;
    }

}
