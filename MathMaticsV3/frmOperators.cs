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
    public partial class frmOperators : Form
    {
        DateTime startTime;
        DateTime stopTime;
        int user_ID = 0;
        int teacher_ID = 0;
        int gamemode = 0;
        string username = "";
        Random random = new Random();
        public frmOperators(string Student_name)
        {
            InitializeComponent();
            username = Student_name;

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Label[] lblOperations = new Label[] { lblOperation1, lblOperation2, lblOperation3, lblOperation4, lblOperation5, lblOperation6, lblOperation7, lblOperation8, lblOperation9, lblOperation10, lblOperation11, lblOperation12 };
            //creates a label array so the program can loop through the operations labels more easily
            btnStart.Enabled = false;
            btnCheck.Enabled = true;
            btnStop.Enabled = true;//enables and disables relevent buttons so new games are started by accident
            int operators = check_operators();//checks the number of selected operators in the checkbox
            //operators = 1;
            if (operators == 0)//Checks at least one operation is actually selected
            {
                MessageBox.Show("You must select at least one type of sums to attempt", "Invalid Choice");//
            }
            if (operators == 1)//chooses the operation used based on only one being selected
            {
                if (clbxOperators.GetItemCheckState(0) == CheckState.Checked)
                {
                    for (int i = 0; i < lblOperations.Length; i++)
                    {
                        lblOperations[i].Text = "+";
                    }
                    gamemode = 1;
                    start_game(gamemode);
                }
                if (clbxOperators.GetItemCheckState(1) == CheckState.Checked)
                {
                    for (int i = 0; i < lblOperations.Length; i++)
                    {
                        lblOperations[i].Text = "-";
                    }
                    gamemode = 2;
                    start_game(gamemode);
                }
                if (clbxOperators.GetItemCheckState(2) == CheckState.Checked)
                {
                    for (int i = 0; i < lblOperations.Length; i++)
                    {
                        lblOperations[i].Text = "x";
                    }
                    gamemode = 3;
                    start_game(gamemode);
                }
                if (clbxOperators.GetItemCheckState(3) == CheckState.Checked)
                {
                    for (int i = 0; i < lblOperations.Length; i++)
                    {
                        lblOperations[i].Text = "÷";
                    }
                    gamemode = 4;
                    start_game(gamemode);
                }                
            }
            if (operators == 2)//Chooses the operations based on two being selected
            {
                if (clbxOperators.GetItemCheckState(0) == CheckState.Checked)
                {                                      
                    if (clbxOperators.GetItemCheckState(1) == CheckState.Checked)
                    {
                        for (int i = 0; i < lblOperations.Length; i = i + 1)
                        {
                            if (i % 2 == 0)
                            {
                                lblOperations[i].Text = "+";
                            }
                            if (i % 2 == 1)
                            {
                                lblOperations[i].Text = "-";
                            }
                        }
                        gamemode = 5;
                        start_game(gamemode);
                    }
                    if (clbxOperators.GetItemCheckState(2) == CheckState.Checked)
                    {
                        for (int i = 0; i < lblOperations.Length; i = i + 1)
                        {
                            if (i % 2 == 0)
                            {
                                lblOperations[i].Text = "x";
                            }
                            if (i % 2 == 1)
                            {
                                lblOperations[i].Text = "+";
                            }
                        }
                        gamemode = 6;
                        start_game(gamemode);
                    }
                    if (clbxOperators.GetItemCheckState(3) == CheckState.Checked)
                    {
                        for (int i = 0; i < lblOperations.Length; i = i + 1)
                        {
                            lblOperations[i].Text = "+";
                            if (i % 2 == 1)
                            {
                                lblOperations[i].Text = "÷";
                            }
                        }
                        gamemode = 7;
                        start_game(gamemode);
                    }
                }
                if (clbxOperators.GetItemCheckState(1) == CheckState.Checked)
                {                   
                    if (clbxOperators.GetItemCheckState(2) == CheckState.Checked)
                    {
                        for (int i = 0; i < lblOperations.Length; i = i + 1)
                        {
                            if (i % 2 == 1)
                            {
                                lblOperations[i].Text = "-";
                            }
                            if (i % 2 == 0)
                            {
                                lblOperations[i].Text = "x";
                            }
                        }
                        gamemode = 8;
                        start_game(gamemode);
                    }
                    if (clbxOperators.GetItemCheckState(3) == CheckState.Checked)
                    {
                            for (int i = 0; i < lblOperations.Length; i = i + 1)
                            {
                                lblOperations[i].Text = "-";
                                if (i % 2 == 1)
                                {
                                    lblOperations[i].Text = "÷";
                                }
                            }
                        gamemode = 9;
                        start_game(gamemode);
                    }
                }
                if (clbxOperators.GetItemCheckState(2) == CheckState.Checked)
                {
                    if (clbxOperators.GetItemCheckState(3) == CheckState.Checked)
                    {
                        for (int i = 0; i < lblOperations.Length; i = i + 1)
                        {
                            lblOperations[i].Text = "x";
                            if (i % 2 == 1)
                            {
                                lblOperations[i].Text = "÷";
                            }
                        }
                    }
                    gamemode = 10;
                    start_game(gamemode);
                }

            }
            if (operators == 3)//Chooses the operations based on three being selected
            {
                if (clbxOperators.GetItemCheckState(0) != CheckState.Checked)
                {
                    for (int i = 0; i < lblOperations.Length; i = i + 1)
                    {
                        lblOperations[i].Text = "-";
                        if (i % 3 == 1)
                        {
                            lblOperations[i].Text = "x";
                        }
                        if (i % 3 == 2)
                        {
                            lblOperations[i].Text = "÷";

                        }
                    }
                    gamemode = 11;
                    start_game(gamemode);
                }
                if (clbxOperators.GetItemCheckState(1) != CheckState.Checked)
                {
                    for (int i = 0; i < lblOperations.Length; i = i + 1)
                    {
                        lblOperations[i].Text = "+";
                        if (i % 3 == 1)
                        {
                            lblOperations[i].Text = "x";
                        }
                        if (i % 3 == 2)
                        {
                            lblOperations[i].Text = "÷";

                        }
                    }
                    gamemode = 12;
                    start_game(gamemode);
                }
                if (clbxOperators.GetItemCheckState(2) != CheckState.Checked)
                {
                    for (int i = 0; i < lblOperations.Length; i = i + 1)
                    {
                        lblOperations[i].Text = "+";
                        if (i % 3 == 1)
                        {
                            lblOperations[i].Text = "-";
                        }
                        if (i % 3 == 2)
                        {
                            lblOperations[i].Text = "÷";

                        }
                    }
                    gamemode = 13;
                    start_game(gamemode);
                }
                if (clbxOperators.GetItemCheckState(3) != CheckState.Checked)
                {
                    for (int i = 0; i < lblOperations.Length; i = i + 1)
                    {
                        lblOperations[i].Text = "-";
                        if (i % 3 == 1)
                        {
                            lblOperations[i].Text = "X";
                        }
                        if (i % 3 == 2)
                        {
                            lblOperations[i].Text = "+";

                        }
                    }
                    gamemode = 14;
                    start_game(gamemode);
                }
            }
            if (operators == 4)//Sets the labels as all boxes in the checkbox must be checked
            {                               
                for (int i = 0; i < lblOperations.Length; i = i + 1)
                {
                    lblOperations[i].Text = "+";
                    if (i % 4 == 1)
                    {
                        lblOperations[i].Text = "-";
                    }
                    if (i % 4 == 2)
                    {
                        lblOperations[i].Text = "x";

                    }
                    if (i % 4 == 3)
                    {
                        lblOperations[i].Text = "÷";
                    }
                }
                gamemode = 15;
                start_game(gamemode);
            }
        }

        private void start_game(int gamemode)//starts the game using settings saved in gamemode
        {
            NumericUpDown[] nudOperands = new NumericUpDown[] { nudOperand1, nudOperand2, nudOperand3, nudOperand4, nudOperand5, nudOperand6, nudOperand7, nudOperand8, nudOperand9, nudOperand10, nudOperand11, nudOperand12, nudOperand13, nudOperand14, nudOperand15, nudOperand16, nudOperand17, nudOperand18, nudOperand19, nudOperand20, nudOperand21, nudOperand22, nudOperand23, nudOperand24 };
            //NumericUpDown Array to allow operands to be looped when being given their values
            if (gamemode == 1)//Sets the game to only use additon
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    int x = 0, y = 0;
                    gen_add(ref x, ref y);
                    nudOperands[i].Value = x;
                    nudOperands[i+ 1].Value = y;
                }
            }
            if (gamemode == 2)//Sets the game to only use subtraction
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    int x = 0, y = 0;
                    gen_subtract(ref x, ref y);
                    nudOperands[i].Value = x;
                    nudOperands[i + 1].Value = y;
                }
            }
            if (gamemode == 3)//Sets the game to only use multiplication
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    int x = 0, y = 0;
                    gen_multiply(ref x, ref y);
                    nudOperands[i].Value = x;
                    nudOperands[i + 1].Value = y;
                }               
            }
            if (gamemode == 4)//Sets the game to only use division
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    int x = 0, y = 0;
                    gen_divide(ref x,ref y);
                    nudOperands[i].Value = x;
                    nudOperands[i + 1].Value = y;
                }
            }
            if (gamemode == 5)//Sets the game to only use addition and subtraction
            {
                int count = 0;
                for (int i = 0; i < 24; i = i + 2)
                {
                    int x = 0, y = 0;
                    if (count % 2 == 0)
                    {
                        gen_add(ref x, ref y);
                    }
                    if (count % 2 == 1)
                    {
                        gen_subtract(ref x, ref y);
                    }
                    nudOperands[i].Value = x;
                    nudOperands[i + 1].Value = y;
                    count++;
                }
            }
            if (gamemode == 6)
            {
                int count = 0;
                for (int i = 0; i < 24; i = i + 2)
                {
                    int x = 0, y = 0;
                    if (count % 2 == 0)
                    {
                        gen_add(ref x, ref y);
                    }
                    if (count % 2 == 1)
                    {
                        gen_multiply(ref x, ref y);
                    }
                    nudOperands[i].Value = x;
                    nudOperands[i + 1].Value = y;
                    count++;
                }

            }
            if (gamemode == 7)
            {
                int count = 0;
                for (int i = 0; i < 24; i = i + 2)
                {
                    int x = 0, y = 0;
                    if (count % 2 == 0)
                    {
                        gen_add(ref x, ref y);
                    }
                    if (count % 2 == 1)
                    {
                        gen_divide(ref x, ref y);
                    }
                    nudOperands[i].Value = x;
                    nudOperands[i + 1].Value = y;
                    count++;
                }
            }
            if (gamemode == 8)
            {
                int count = 0;
                for (int i = 0; i < 24; i = i + 2)
                {
                    int x = 0, y = 0;
                    if (count % 2 == 1)
                    {
                        gen_subtract(ref x, ref y);
                    }
                    if (count % 2 == 0)
                    {
                        gen_multiply(ref x, ref y);
                    }
                    nudOperands[i].Value = x;
                    nudOperands[i + 1].Value = y;
                    count++;
                }
            }
            if (gamemode == 9)
            {
                int count = 0;
                for (int i = 0; i < 24; i = i + 2)
                {
                    int x = 0, y = 0;
                    if (count % 2 == 0)
                    {
                        gen_subtract(ref x, ref y);
                    }
                    if (count % 2 == 1)
                    {
                        gen_divide(ref x, ref y);
                    }
                    nudOperands[i].Value = x;
                    nudOperands[i + 1].Value = y;
                    count++;
                }
            }
            if (gamemode == 10)
            {
                int count = 0;
                for (int i = 0; i < 24; i = i + 2)
                {
                    int x = 0, y = 0;
                    if (count % 2 == 0)
                    {
                        gen_multiply(ref x, ref y);
                    }
                    if (count % 2 == 1)
                    {
                        gen_divide(ref x, ref y);
                    }
                    nudOperands[i].Value = x;
                    nudOperands[i + 1].Value = y;
                    count++;
                }
            }
            if (gamemode == 11)
            {
                int count = 0;
                for (int i = 0; i < 24; i = i + 2)
                {
                    int x = 0, y = 0;
                    if (count % 3 == 0)
                    {
                        gen_subtract(ref x, ref y);
                    }
                    if (count % 3 == 1)
                    {
                        gen_multiply(ref x, ref y);
                    }
                    if (count % 3 == 2)
                    {
                        gen_divide(ref x, ref y);
                    }
                    nudOperands[i].Value = x;
                    nudOperands[i + 1].Value = y;
                    count++;
                }
            }
            if (gamemode == 12)
            {
                int count = 0;
                for (int i = 0; i < 24; i = i + 2)
                {
                    int x = 0, y = 0;
                    if (count % 3 == 0)
                    {
                        gen_add(ref x, ref y);
                    }
                    if (count % 3 == 1)
                    {
                        gen_multiply(ref x, ref y);
                    }
                    if (count % 3 == 2)
                    {
                        gen_divide(ref x, ref y);
                    }
                    nudOperands[i].Value = x;
                    nudOperands[i + 1].Value = y;
                    count++;
                }
            }
            if (gamemode == 13)
            {
                int count = 0;
                for (int i = 0; i < 24; i = i + 2)
                {
                    int x = 0, y = 0;
                    if (count % 3 == 0)
                    {
                        gen_add(ref x, ref y);
                    }
                    if (count % 3 == 1)
                    {
                        gen_subtract(ref x, ref y);
                    }
                    if (count % 3 == 2)
                    {
                        gen_divide(ref x, ref y);
                    }
                    nudOperands[i].Value = x;
                    nudOperands[i + 1].Value = y;
                    count++;
                }
            }
            if (gamemode == 14)
            {
                int count = 0;
                for (int i = 0; i < 24; i = i + 2)
                {
                    int x = 0, y = 0;
                    if (count % 3 == 0)
                    {
                        gen_subtract(ref x, ref y);

                    }
                    if (count % 3 == 1)
                    {
                        gen_multiply(ref x, ref y);
                    }
                    if (count % 3 == 2)
                    {
                        gen_add(ref x, ref y);

                    }
                    nudOperands[i].Value = x;
                    nudOperands[i + 1].Value = y;
                    count++;
                }
            }
            if (gamemode == 15)
            {
                int count = 0;
                for (int i = 0; i < 24; i = i + 2)
                {
                    int x = 0, y = 0;
                    if (count % 4 == 0)
                    {
                        gen_add(ref x, ref y);
                    }
                    if (count % 4 == 1)
                    {
                        gen_subtract(ref x, ref y);
                    }
                    if (count % 4 == 2)
                    {
                        gen_multiply(ref x, ref y);
                    }
                    if (count % 4 == 3)
                    {
                        gen_divide(ref x, ref y);
                    }
                    nudOperands[i].Value = x;
                    nudOperands[i + 1].Value = y;
                    count++;
                }
            }
            startTime = DateTime.Now;
        }
        private void gen_add(ref int x, ref int y)//Generates 2 values for addition questions
        {
            x = random.Next(1, 150);
            y = random.Next(1, 150);
        }
        private void gen_subtract(ref int x, ref int y)//Generates 2 values for subtraction questions
        {
            x = random.Next(2, 149);           
            y = random.Next(1, x - 1);
        }
        private void gen_multiply(ref int x, ref int y)//Generates 2 values for multiplication questions
        {
            x = random.Next(2, 12);
            y = random.Next(2, 12);                          
        }
        private void gen_divide(ref int x,ref int y)//Generates 2 values for Division questions
        {
            x = random.Next(12, 144);
            y = random.Next(2, 12);
            while (x % y != 0 || x - (y * 12) > 0)
            {
                if (x % 3 == 0 || x % 2 == 0 || x % 5 == 0 || x % 7 == 0)
                {                   
                    y = random.Next(2, 12);
                }
                if (x - (y * 12) > 0)
                {
                    x = random.Next(12, (y * 12));
                }
                else if (x % 3 != 0 && x % 2 != 0 && x % 5 != 0 && x % 7 != 0)
                {
                    x = random.Next(12, 144);
                }
            }
        }
        private int check_operators()//Checks the number of operators chosen to be used from the checkbox
        {
            int i;
            int count = 0;
            for (i = 0; i <= (clbxOperators.Items.Count - 1); i++)
            {
                if (clbxOperators.GetItemChecked(i))
                {
                    count = count + 1;
                }
            }
            return count;        
        }
        private void frmOperators_Load(object sender, EventArgs e)
        {
            get_userIDs();
            lblIntro.Text = " Welcome back to MathMatics "+username;//Uses the logged users username to welcome them back
        }

        private void get_userIDs()//Gets the needed IDs of the logged user
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT User_ID, Teacher_ID FROM tblUsers WHERE (UserName = '" + username + "')";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                user_ID = Convert.ToInt32(dr[0]);
                teacher_ID = Convert.ToInt32(dr[1]);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)//Quits the program if a user logs out
        {
            this.Close();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            stopTime = DateTime.Now;
            string elapsed;
            Double elapsedSecs = ((TimeSpan)(stopTime - startTime)).TotalSeconds;
            elapsed = elapsedSecs.ToString("N0");
            NumericUpDown[] nudOperands = new NumericUpDown[] { nudOperand1, nudOperand2, nudOperand3, nudOperand4, nudOperand5, nudOperand6, nudOperand7, nudOperand8, nudOperand9, nudOperand10, nudOperand11, nudOperand12, nudOperand13, nudOperand14, nudOperand15, nudOperand16, nudOperand17, nudOperand18, nudOperand19, nudOperand20, nudOperand21, nudOperand22, nudOperand23, nudOperand24 };
            NumericUpDown[] nudAns = new NumericUpDown[] { nudAns1, nudAns2, nudAns3, nudAns4, nudAns5, nudAns6, nudAns7, nudAns8, nudAns9, nudAns10, nudAns11, nudAns12 };
            //Two NumericUpDown Arrays created to allow the program to mark the sums
            int correct = check_answers(gamemode);//Generates a correct value
            btnCheck.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            MessageBox.Show("You got " + correct + " right out of 12\nIt took you "+elapsed +" seconds\nThat gives you a score of " + gen_score(correct, Convert.ToInt32(elapsed)).ToString() , "Quiz finished");//Gives the user their final score
            update_Score(gen_score(correct, Convert.ToInt32(elapsed)));//updates the score on the backend database
            clear_nud(nudOperands);
            clear_nud(nudAns);//clears the selected numericupdown array removing previous values
        }

        private void update_Score(int score)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = "UPDATE tblUsers " +
                            "SET last_score =" + score +
                            "\nWHERE (User_ID = " + user_ID + ")";//Sets the last score to equal the score

            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.close();
            int high_score = get_HighScore();//gets the users current high score
            if (score > high_score)//checks if the new score is greater than current high score
            {
                MessageBox.Show("You got a new High Score Your new score is "+score + "Your old score was "+high_score, "New High Score!");
                update_highScore(score);//updates the highscore on the database               
            }
        }
        private void update_highScore(int score)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = "UPDATE tblUsers " +
                                "SET Hi_Score =" + score +
                                "\nWHERE (User_ID = " + user_ID + ")";

            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.close();
        }

        private int get_HighScore()
        {
            int score = 0;
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT Hi_Score" +
                " FROM tblUsers" +
                " WHERE User_ID = " + user_ID;
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                score = Convert.ToInt32(dr[0]);
            }
            return score;//Returns the current high score of the logged user
        }

        private int gen_score(int correct, int time)//Applies the correct difficulty bonus and any applicable time bonus
        {
            int time_bonus = 0;
            int score = 0;
            if (gamemode <= 2)
            {
                score = correct;
            }
            if (3 <= gamemode && gamemode <= 5)
            {
                score = 2 * correct;
            }
            if (6 <= gamemode && gamemode <= 9)
            {
                score = 3 * correct;
            }
            if (10 <= gamemode && gamemode <= 14)
            {
                score = 4 * correct;
            }
            if (gamemode == 15)
            {
                score = 5 * correct;
            }
            if (time > 110)
            {
                time_bonus = 0;
            }
            else if (time > 100)
            {
                time_bonus = 4;
            }
            else if (time > 90)
            {
                time_bonus = 10;
            }
            else if (time > 80)
            {
                time_bonus = 16;
            }
            else if (time > 76)
            {
                time_bonus = 20;
            }
            else if (time > 74)
            {
                time_bonus = 22;
            }
            else if (time > 72)
            {
                time_bonus = 24;
            }
            else if (time > 70)
            {
                time_bonus = 28;
            }
            else if (time > 60)
            {
                time_bonus = 30;
            }
            else if (time > 55)
            {
                time_bonus = 40;
            }
            else if (time > 50)
            {
                time_bonus = 44;
            }
            else if (time > 45)
            {
                time_bonus = 50;
            }
            else if (time > 40)
            {
                time_bonus = 56;
            }
            else if (time > 30)
            {
                time_bonus = 60;
            }
            else if (time > 20)
            {
                time_bonus = 66;
            }
            else if (time <= 20)
            {
                time_bonus = 70;
            }
            if (5 <= correct && correct <= 9)
            {
                time_bonus = time_bonus / 2;
            }
            else if (correct < 5)
            {
                time_bonus = 0;
            }
            score = score + time_bonus;
            return score;
        }
        private void clear_nud(NumericUpDown[] nud)
        {
            for (int i = 0; i < nud.Length; i++)//Loops through a numeric up down array setting each value back to 0
            {
                nud[i].Value = 0;
            }
        }

        private int check_answers(int gamemode)
        {
            int correct = 0;
            NumericUpDown[] nudOperands = new NumericUpDown[] { nudOperand1, nudOperand2, nudOperand3, nudOperand4, nudOperand5, nudOperand6, nudOperand7, nudOperand8, nudOperand9, nudOperand10, nudOperand11, nudOperand12, nudOperand13, nudOperand14, nudOperand15, nudOperand16, nudOperand17, nudOperand18, nudOperand19, nudOperand20, nudOperand21, nudOperand22, nudOperand23, nudOperand24 };
            NumericUpDown[] nudAns = new NumericUpDown[] { nudAns1, nudAns2, nudAns3, nudAns4, nudAns5, nudAns6, nudAns7, nudAns8, nudAns9, nudAns10, nudAns11, nudAns12};
            //Creates two Numeric Up Down Arrays so they can be more easily looped
            Decimal x = 0, y = 0, ans = 0;
            int count = 0;
            //marks the quiz according to the selected gamemode
            if (gamemode == 1)
            {
                for (int i = 0; i < 24; i = i + 2)
                {                    
                    x = nudOperands[i].Value;
                    y = nudOperands[i + 1].Value;
                    ans = nudAns[count].Value;
                    if (check_add(x, y, ans) == true)
                    {
                        correct = correct + 1;
                    }                    
                    count = count + 1;
                }
            }
            if (gamemode == 2)
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    x = nudOperands[i].Value;
                    y = nudOperands[i + 1].Value;
                    ans = nudAns[count].Value;
                    if (check_minus(x, y, ans) == true)
                    {
                        correct = correct + 1;
                    }
                    count = count + 1;
                }
            }
            if (gamemode == 3)
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    x = nudOperands[i].Value;
                    y = nudOperands[i + 1].Value;
                    ans = nudAns[count].Value;
                    if (check_times(x, y, ans) == true)
                    {
                        correct = correct + 1;
                    }
                    count = count + 1;
                }
            }
            if (gamemode == 4)
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    x = nudOperands[i].Value;
                    y = nudOperands[i + 1].Value;
                    ans = nudAns[count].Value;
                    if (check_divide(x, y, ans) == true)
                    {
                        correct = correct + 1;
                    }
                    count = count + 1;
                }
            }
            if (gamemode == 5)
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    x = nudOperands[i].Value;
                    y = nudOperands[i + 1].Value;
                    ans = nudAns[count].Value;
                    if (count % 2 == 0)
                    {
                        if (check_add(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    if (count % 2 == 1)
                    {
                        if (check_minus(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }                   
                    count = count + 1;
                }
            }
            if (gamemode == 6)
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    x = nudOperands[i].Value;
                    y = nudOperands[i + 1].Value;
                    ans = nudAns[count].Value;
                    if (count % 2 == 0)
                    {
                        if (check_add(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    if (count % 2 == 1)
                    {
                        if (check_times(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                        
                    }
                    count = count + 1;
                }

            }
            if (gamemode == 7)
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    x = nudOperands[i].Value;
                    y = nudOperands[i + 1].Value;
                    ans = nudAns[count].Value;
                    if (count % 2 == 0)
                    {
                        if (check_add(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    if (count % 2 == 1)
                    {
                        if (check_divide(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }

                    }
                    count = count + 1;
                }
            }
            if (gamemode == 8)
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    x = nudOperands[i].Value;
                    y = nudOperands[i + 1].Value;
                    ans = nudAns[count].Value;
                    if (count % 2 == 0)
                    {
                        if (check_minus(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    if (count % 2 == 1)
                    {
                        if (check_times(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    count = count + 1;
                }
            }
            if (gamemode == 9)
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    x = nudOperands[i].Value;
                    y = nudOperands[i + 1].Value;
                    ans = nudAns[count].Value;
                    if (count % 2 == 0)
                    {
                        if (check_minus(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    if (count % 2 == 1)
                    {
                        if (check_divide(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }

                    }
                    count = count + 1;
                }
            }
            if (gamemode == 10)
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    x = nudOperands[i].Value;
                    y = nudOperands[i + 1].Value;
                    ans = nudAns[count].Value;
                    if (count % 2 == 0)
                    {
                        if (check_times(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    if (count % 2 == 1)
                    {
                        if (check_divide(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }

                    }
                    count = count + 1;
                }
            }
            if (gamemode == 11)
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    x = nudOperands[i].Value;
                    y = nudOperands[i + 1].Value;
                    ans = nudAns[count].Value;
                    if (count % 3 == 0)
                    {
                        if (check_minus(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    if (count % 3 == 1)
                    {
                        if (check_times(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }

                    }
                    if (count % 3 == 2)
                    {
                        if (check_divide(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    count = count + 1;
                }
            }
            if (gamemode == 12)
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    x = nudOperands[i].Value;
                    y = nudOperands[i + 1].Value;
                    ans = nudAns[count].Value;
                    if (count % 3 == 0)
                    {
                        if (check_add(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    if (count % 3 == 1)
                    {
                        if (check_times(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }

                    }
                    if (count % 3 == 2)
                    {
                        if (check_divide(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    count = count + 1;
                }
            }
            if (gamemode == 13)
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    x = nudOperands[i].Value;
                    y = nudOperands[i + 1].Value;
                    ans = nudAns[count].Value;
                    if (count % 3 == 0)
                    {
                        if (check_add(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    if (count % 3 == 1)
                    {
                        if (check_minus(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }

                    }
                    if (count % 3 == 2)
                    {
                        if (check_divide(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    count = count + 1;
                }
            }
            if (gamemode == 14)
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    x = nudOperands[i].Value;
                    y = nudOperands[i + 1].Value;
                    ans = nudAns[count].Value;
                    if (count % 3 == 0)
                    {
                        if (check_minus(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    if (count % 3 == 1)
                    {
                        if (check_times(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }

                    }
                    if (count % 3 == 2)
                    {
                        if (check_add(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    count = count + 1;
                }
            }
            if (gamemode == 15)
            {
                for (int i = 0; i < 24; i = i + 2)
                {
                    x = nudOperands[i].Value;
                    y = nudOperands[i + 1].Value;
                    ans = nudAns[count].Value;
                    if (count % 4 == 0)
                    {
                        if (check_add(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    if (count % 4 == 1)
                    {
                        if (check_minus(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }

                    }
                    if (count % 4 == 2)
                    {
                        if (check_times(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    if (count % 4 == 3)
                    {
                        if (check_divide(x, y, ans) == true)
                        {
                            correct = correct + 1;
                        }
                    }
                    count = count + 1;
                }
            }
            return correct;
        }
        private bool check_add(decimal x, decimal y, decimal ans)
        {
            //Checks if an addition is true, receives two operands (x,y) and compares to an answer(ans)
            //Outputs true if correct and false if not
            if (x + y == ans)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool check_minus(decimal x, decimal y, decimal ans)
        {
            //Checks if an subtraction is true, receives two operands (x,y) and compares to an answer(ans)
            //Outputs true if correct and false if not
            if (x - y == ans)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool check_times(decimal x, decimal y, decimal ans)
        {
            //Checks if an multiplication is true, receives two operands (x,y) and compares to an answer(ans)
            //Outputs true if correct and false if not
            if (x * y == ans)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool check_divide(decimal x, decimal y, decimal ans)
        {
            //Checks if an division is true, receives two operands (x,y) and compares to an answer(ans)
            //Outputs true if correct and false if not
            if (x / y == ans)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            NumericUpDown[] nudOperands = new NumericUpDown[] { nudOperand1, nudOperand2, nudOperand3, nudOperand4, nudOperand5, nudOperand6, nudOperand7, nudOperand8, nudOperand9, nudOperand10, nudOperand11, nudOperand12, nudOperand13, nudOperand14, nudOperand15, nudOperand16, nudOperand17, nudOperand18, nudOperand19, nudOperand20, nudOperand21, nudOperand22, nudOperand23, nudOperand24 };
            NumericUpDown[] nudAns = new NumericUpDown[] { nudAns1, nudAns2, nudAns3, nudAns4, nudAns5, nudAns6, nudAns7, nudAns8, nudAns9, nudAns10, nudAns11, nudAns12 };
            btnCheck.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            clear_nud(nudOperands);
            clear_nud(nudAns);
            //Enables the correct buttons and clears all numeric up down controls, setting their values back to 0;
        }
    }
}
