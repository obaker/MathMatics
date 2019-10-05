using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace MathMaticsV3
{
    public partial class frmAddUser : Form
    {
        int school = 0, teacher = 0;
        public frmAddUser(int teacher_ID, int School_ID)
        {
            InitializeComponent();
            school = School_ID;
            teacher = teacher_ID;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nudSchoolYear.Value != 0)//Checks if school year specified
            {
                if (MessageBox.Show("User will be added,\nIs that OK?", "Add User", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {                   
                    add_user(hash_password(txtPwd.Text));//Adds the user with a hashed version of the password typed in
                    lblLastAction.Text = txtName.Text + " added to database.";//Updates label saying who's been added to the database
                }
            }
            else if (nudSchoolYear.Value == 0)//Informs teacher program not continuing as school year not specified
            {
                MessageBox.Show("School Year Not Specified\n User Not Entered", "No School Year");
            }                    
        }
        private string hash_password(string text)
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

        private void add_user(string hashed_password)
        {
            clsDBConnector dbConnector = new clsDBConnector();          
            string cmdStr = "INSERT INTO tblUsers  (UserName, RealName, pwdHash, School_ID, Teacher_ID, School_Year) " +
                "VALUES ('" + txtUser.Text + "' , '" + clean_string(txtName.Text) + "' , '" + hashed_password + "' , '" + school + "' , '" + teacher+ "' , '" + nudSchoolYear.Value + "')";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.close();
        }

        private string clean_string(string strIn)//Prevents against basic SQL injection by sanitizing user input on username
        {
            try
            {
                return Regex.Replace(strIn, @"[^\w\s]", "",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }
    }
}
