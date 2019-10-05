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

namespace MathMaticsV3
{
    public partial class frmTeacher : Form
    {
        int teacher_ID = 0;
        int School_ID = 0;
        int School_Year = 0;
        string username = "";
        public frmTeacher(string teacher_Name)
        {
            InitializeComponent();
            username = teacher_Name;
        }
        private void frmTeacher_Load(object sender, EventArgs e)
        {
            lblTeacher.Text = "Welcome to the Teacher Panel \nLogged in as: " + username; //sets a label to say who is logged in
            teacher_ID = get_teacherID();
            School_ID = get_schoolID();
            School_Year = get_schoolYear();// sets teacherID, SchoolID and School Year to their true values for the logged teacher
            load_Students();
        }
        private int get_teacherID()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT Teacher_ID FROM tblTeachers WHERE (UserName = '"+username+"')";//Selects the teacherID for the logged teacher
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                teacher_ID = Convert.ToInt32(dr[0]);
            }
            return teacher_ID;
        }
        private int get_schoolYear()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT Year_Taught FROM tblTeachers WHERE (UserName = '" + username + "')";//Selects the YearTaught for the logged teacher
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                School_Year = Convert.ToInt32(dr[0]);
            }
            return School_Year;
        }
        private void load_Students()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT User_ID, RealName, TimePlayed, Hi_Score, last_score FROM tblUsers WHERE (Teacher_ID = "+teacher_ID+")"; //Selects all users with the teacherID set to the logged teacher
            dr = dbConnector.DoSQL(sqlStr);
            lstVStudents.Items.Clear();
            while (dr.Read())
            {
                lstVStudents.Items.Add(dr[0].ToString());
                lstVStudents.Items[lstVStudents.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstVStudents.Items[lstVStudents.Items.Count - 1].SubItems.Add(dr[2].ToString());
                lstVStudents.Items[lstVStudents.Items.Count - 1].SubItems.Add(dr[3].ToString());
                lstVStudents.Items[lstVStudents.Items.Count - 1].SubItems.Add(dr[4].ToString());

            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_Students(); //Loads the new student list whenever the refresh button is pressed

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUser frmAddUser = new frmAddUser(get_schoolID(), get_teacherID()); //Launches the adduser form with the school ID and teacher ID of the logged teacher
            frmAddUser.ShowDialog();
        }

        private int get_schoolID()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT School_ID FROM tblTeachers WHERE (UserName = '" + username + "')";//Selects the SchoolID for the logged teacher
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                School_ID = Convert.ToInt32(dr[0]);
            }
            return School_ID;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the program when the logout button is pressed
        }      
        private void btnOperators_Click(object sender, EventArgs e)
        {
            frmOperators frmOperators = new frmOperators("teacher");
            frmOperators.ShowDialog();
        }    
        private void calculateAverageLateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void yearLastScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            string avg_Score_string = "0";
            dbConnector.Connect();
            sqlStr = " SELECT        AVG(last_score) AS last_scoreAVG" +
                     " FROM tblUsers" +
                     " WHERE School_Year = " + School_Year + "" +
                     " AND School_ID = " + School_ID + ""; //finds the average last score for the year at the logged teachers school
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                avg_Score_string = (dr[0].ToString());
            }
            double avg_score = Convert.ToDouble(avg_Score_string);
            avg_Score_string = avg_score.ToString("N0");
            string caption = "Average";//displays the average calculated to 0 decimal places in a messagebox
            string message = "The average last Score is " + avg_Score_string + " points."; 
            DialogResult result;
            result = MessageBox.Show(message, caption);
        }

        

        private void classHighScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            string avg_Score_string = "0";
            dbConnector.Connect();
            sqlStr = " SELECT        AVG(Hi_Score) AS Hi_ScoreAVG" +
                     " FROM tblUsers" +
                     " WHERE Teacher_ID = " + 1 + ""; //finds the average last score for the year in the logged teachers class
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                avg_Score_string = (dr[0].ToString());
            }
            double avg_score = Convert.ToDouble(avg_Score_string);
            avg_Score_string = avg_score.ToString("N0");
            string caption = "Average";//displays the average calculated to 0 decimal places in a messagebox
            string message = "The average high Score is " + avg_Score_string + " points.";
            DialogResult result;
            result = MessageBox.Show(message, caption);
        }

        private void yearHighScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            string avg_Score_string = "0";
            dbConnector.Connect();
            sqlStr = " SELECT        AVG(Hi_Score) AS Hi_ScoreAVG" +
                     " FROM tblUsers" +
                     " WHERE School_Year = " + School_Year + ""+
                     " AND School_ID = " + School_ID + "";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                avg_Score_string = (dr[0].ToString());
            }
            double avg_score = Convert.ToDouble(avg_Score_string);
            avg_Score_string = avg_score.ToString("N0");
            string caption = "Average";//displays the average calculated to 0 decimal places in a messagebox
            string message = "The average high Score is " + avg_Score_string + " points.";
            DialogResult result;
            result = MessageBox.Show(message, caption);
        }

        private void nationwideYearHighScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            string avg_Score_string = "0";
            dbConnector.Connect();
            sqlStr = " SELECT        AVG(Hi_Score) AS Hi_ScoreAVG" +
                     " FROM tblUsers" +
                     " WHERE School_Year = " + School_Year + "";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                avg_Score_string = (dr[0].ToString());
            }
            double avg_score = Convert.ToDouble(avg_Score_string);
            avg_Score_string = avg_score.ToString("N0");
            string caption = "Average";//displays the average calculated to 0 decimal places in a messagebox
            string message = "The average high Score is " + avg_Score_string + " points.";
            DialogResult result;
            result = MessageBox.Show(message, caption);
        }

        private void classLastScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            string avg_Score_string = "0";
            dbConnector.Connect();
            sqlStr = " SELECT        AVG(last_score) AS last_scoreAVG" +
                     " FROM tblUsers" +
                     " WHERE Teacher_ID = " + 1 + "";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                avg_Score_string = (dr[0].ToString());
            }
            double avg_score = Convert.ToDouble(avg_Score_string);
            avg_Score_string = avg_score.ToString("N0");
            string caption = "Average";//displays the average calculated to 0 decimal places in a messagebox
            string message = "The average last Score is " + avg_Score_string + " points.";
            DialogResult result;
            result = MessageBox.Show(message, caption);
        }

        private void nationwideYearLastScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            string avg_Score_string = "0";
            dbConnector.Connect();
            sqlStr = " SELECT        AVG(last_score) AS last_scoreAVG" +
                     " FROM tblUsers" +
                     " WHERE School_Year = " + School_Year + "";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                avg_Score_string = (dr[0].ToString());
            }
            double avg_score = Convert.ToDouble(avg_Score_string);
            avg_Score_string = avg_score.ToString("N0");
            string caption = "Average";//displays the average calculated to 0 decimal places in a messagebox
            string message = "The average last Score is " + avg_Score_string + " points.";
            DialogResult result;
            result = MessageBox.Show(message, caption);
        }

        private void tsmiEditUser_Click(object sender, EventArgs e)
        {
            List<int> Editing_ID = new List<int>();
            int count = 0;
            foreach (var item in lstVStudents.SelectedItems)
            {
                Editing_ID.Add(Convert.ToInt32(lstVStudents.SelectedItems[count].Text));
                count++;
            }
            if (Editing_ID.Count > 1)//stops teacher from trying to edit multiple users
            {
                MessageBox.Show("You can't edit more than one user at once.\n .", "More than one User Selected, ");
            }
            else if (Editing_ID.Count == 1)//launches the edit user form
            {
                frmEditUser frmEditUser = new frmEditUser(Editing_ID[0]);
                frmEditUser.ShowDialog();
            }
            else //informs teacher that no user has been selected
            {
                MessageBox.Show("You haven't selected a User\n So you can't edit them.", "No User Selected, ");
            }
        }

        private void lstVStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsmiRemoveUser_Click(object sender, EventArgs e)
        {
            List<int> removing_ID = new List<int>();
            int count = 0;
            foreach (var item in lstVStudents.SelectedItems)
            {
                removing_ID.Add(Convert.ToInt32(lstVStudents.SelectedItems[count].Text));//generates an ID for all students to be removed
                count++;
            }
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            dbConnector.Connect();
            List<string> removing_Names = new List<string>();
            foreach (var ID in removing_ID)//Gets the real names for every selected user
            {
                string sqlStr = "SELECT RealName FROM tblUsers WHERE (User_ID = " + ID + ")";
                dr = dbConnector.DoSQL(sqlStr);
                while (dr.Read())
                {
                    removing_Names.Add(Convert.ToString(dr[0]));
                }
            }
            string message = "";
            //string message = string.Join(", ", removing_Names, ", ",removing_ID);
            int counter = 0;
            foreach (var item in removing_ID)//generates a string telling the teacher what users will be removed with their names and IDs
            {
                message += removing_Names[counter];
                message += " (";
                message += removing_ID[counter];
                message += ")\n";
                counter++;
            }
            if (MessageBox.Show("The following users will be removed\n" + message + "\nThis cannot be undone?", "REMOVE USERS", MessageBoxButtons.OKCancel) == DialogResult.OK)//Makes sure the teacher only deletes users if they want to
            {
                count = 0;
                foreach (var IDs in removing_ID)//Removes each ID selected 1 after another
                {
                    removeUser(IDs);
                }              
                MessageBox.Show("Users Deleted");//Tells the teacher the process was succesful
            }
            else 
            {
                MessageBox.Show("No changes made");//Tells the teacher they succesfully cancelled the remove action
            }
        }
        private void removeUser(int ID)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = "DELETE FROM tblUsers " +//Deletes a user specified as ID
                    "WHERE (User_ID = " + ID + ")";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.close();
        }
    }
}
