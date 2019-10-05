using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//Allows writing to Access databases
using System.Security.Cryptography;//Enables use of the inbuilt SHA256 Hash
//MathMatics
//Oliver Baker 2019
//AQA A2 Computer Science Coursework
namespace MathMaticsV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            check_teacher_login();

        }
        private void check_User_login()
        {            
            string hashed_password = create_hash(txtPassword.Text);
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT tblUsers.User_ID FROM ((tblSchools INNER JOIN tblTeachers ON tblSchools.School_ID = tblTeachers.School_ID) INNER JOIN tblUsers ON tblSchools.School_ID = tblUsers.School_ID AND tblTeachers.Teacher_ID = tblUsers.Teacher_ID) WHERE (tblUsers.UserName = '" + txtUsername.Text.ToLower() + "') AND (tblUsers.pwdHash = '" + hashed_password + "') AND (tblSchools.School_Name = '" + txtSchool.Text.ToLower() + "')";            
            dr = dbConnector.DoSQL(sqlStr);
            if (dr.HasRows)// Checks if a student exists with that username, school and password
            {
                frmOperators frmOperator = new frmOperators(txtUsername.Text);//Shows the Operator form as the logged user
                frmOperator.ShowDialog();
                this.Close();                  
            }
            else
            {
                MessageBox.Show("Login Failed");//tells user their login failed
            }
        }      
        private void check_teacher_login()
        {
            if (txtPassword.Text == string.Empty || txtSchool.Text == string.Empty || txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Sorry,\nAll textboxes must be filled");//tells user not enough details entered
            }
            else
            {
                string hashed_password = create_hash(txtPassword.Text);//Hashes the password to check against the copy on the database
                clsDBConnector dbConnector = new clsDBConnector();
                OleDbDataReader dr;
                string sqlStr;
                dbConnector.Connect();
                sqlStr = "SELECT tblTeachers.Teacher_ID FROM (tblSchools INNER JOIN tblTeachers ON tblSchools.School_ID = tblTeachers.School_ID) WHERE (tblTeachers.UserName = '" + txtUsername.Text.ToLower() + "') AND (tblTeachers.pwdHash = '" + hashed_password + "') AND (tblSchools.School_Name = '" + txtSchool.Text.ToLower() + "')";
                dr = dbConnector.DoSQL(sqlStr);
                if (dr.HasRows)//Checks if a teacher exists with that username, school and password
                {
                    frmTeacher frmTeacher = new frmTeacher(txtUsername.Text);//Shows the teacher form as the logged teacher
                    frmTeacher.ShowDialog();
                    this.Close();
                }
                else
                {
                    check_User_login();//Checks for a student if no teachers exist with those login details
                }
            }
            
        }
        private string create_hash(string text)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(text));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                //MessageBox.Show(builder.ToString());
                return builder.ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }     
    }
}
