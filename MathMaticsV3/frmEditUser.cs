using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathMaticsV3
{
    public partial class frmEditUser : Form
    {
        int editing_ID;
        public frmEditUser(int user_ID)
        {
            InitializeComponent();
            editing_ID = user_ID;
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            get_info(editing_ID);//Gets current infomation of the student being edited
        }

        private void get_info(int editing_ID)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT UserName, RealName, School_Year" +
                " FROM tblUsers" +
                " WHERE User_ID = " + editing_ID;
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                txtUser.Text = dr[0].ToString();
                txtName.Text = dr[1].ToString();
                nudSchoolYear.Value = Convert.ToInt32(dr[2]);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text == string.Empty)//doesn't set the password to blank if no new password specified
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = "UPDATE tblUsers " +
                                "SET UserName ='" + txtUser.Text +
                                "', RealName ='" + txtName.Text  +
                                 "', School_Year = " + nudSchoolYear.Value +
                                "\nWHERE (User_ID = " + editing_ID + ")";//makes sure only the details of the student being edited are changed
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.close();
            }
            else if (txtPwd.Text != string.Empty) // password reset as well as new password is specified
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = "UPDATE tblUsers " +
                                "SET UserName ='" + txtUser.Text+
                                "', RealName ='" + txtName.Text  +
                                 "', pwdHash ='" + hash_password(txtPwd.Text) +//Hashes the password before it is sent to the database
                                 "', School_Year = " + nudSchoolYear.Value + " " +
                                "\nWHERE (User_ID = " + editing_ID + ")";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.close();
            }
            lblLastAction.Text = "User:" + txtName.Text + " edited";


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
    }
}
