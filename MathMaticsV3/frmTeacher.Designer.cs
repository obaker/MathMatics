namespace MathMaticsV3
{
    partial class frmTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacher));
            this.lblTeacher = new System.Windows.Forms.Label();
            this.dbMathMaticsDataSet = new MathMaticsV3.dbMathMaticsDataSet();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new MathMaticsV3.dbMathMaticsDataSetTableAdapters.tblUsersTableAdapter();
            this.lstVStudents = new System.Windows.Forms.ListView();
            this.clnUser_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTimePlayed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnHighScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnLastScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsEditUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRemoveUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOperators = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Avgstsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classHighScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearHighScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nationwideYearHighScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classLastScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearLastScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nationwideYearLastScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dbMathMaticsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            this.cmsEditUsers.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.Location = new System.Drawing.Point(12, 45);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(271, 72);
            this.lblTeacher.TabIndex = 0;
            this.lblTeacher.Text = "Welcome to the Teacher Panel\r\nLogged in as:\r\n\r\n";
            // 
            // dbMathMaticsDataSet
            // 
            this.dbMathMaticsDataSet.DataSetName = "dbMathMaticsDataSet";
            this.dbMathMaticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.dbMathMaticsDataSet;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // lstVStudents
            // 
            this.lstVStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnUser_ID,
            this.clnName,
            this.clnTimePlayed,
            this.clnHighScore,
            this.clnLastScore});
            this.lstVStudents.ContextMenuStrip = this.cmsEditUsers;
            this.lstVStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVStudents.FullRowSelect = true;
            this.lstVStudents.GridLines = true;
            this.lstVStudents.Location = new System.Drawing.Point(50, 120);
            this.lstVStudents.Name = "lstVStudents";
            this.lstVStudents.Size = new System.Drawing.Size(701, 520);
            this.lstVStudents.TabIndex = 1;
            this.lstVStudents.UseCompatibleStateImageBehavior = false;
            this.lstVStudents.View = System.Windows.Forms.View.Details;
            this.lstVStudents.SelectedIndexChanged += new System.EventHandler(this.lstVStudents_SelectedIndexChanged);
            // 
            // clnUser_ID
            // 
            this.clnUser_ID.Text = "UserID";
            this.clnUser_ID.Width = 70;
            // 
            // clnName
            // 
            this.clnName.Text = "Name";
            this.clnName.Width = 269;
            // 
            // clnTimePlayed
            // 
            this.clnTimePlayed.Text = "Time Played";
            this.clnTimePlayed.Width = 117;
            // 
            // clnHighScore
            // 
            this.clnHighScore.Text = "High Score";
            this.clnHighScore.Width = 107;
            // 
            // clnLastScore
            // 
            this.clnLastScore.Text = "Last Score";
            this.clnLastScore.Width = 130;
            // 
            // cmsEditUsers
            // 
            this.cmsEditUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditUser,
            this.toolStripSeparator1,
            this.tsmiRemoveUser});
            this.cmsEditUsers.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.cmsEditUsers.Name = "cmsEditUsers";
            this.cmsEditUsers.Size = new System.Drawing.Size(144, 54);
            // 
            // tsmiEditUser
            // 
            this.tsmiEditUser.Name = "tsmiEditUser";
            this.tsmiEditUser.Size = new System.Drawing.Size(143, 22);
            this.tsmiEditUser.Text = "Edit User";
            this.tsmiEditUser.Click += new System.EventHandler(this.tsmiEditUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // tsmiRemoveUser
            // 
            this.tsmiRemoveUser.Name = "tsmiRemoveUser";
            this.tsmiRemoveUser.Size = new System.Drawing.Size(143, 22);
            this.tsmiRemoveUser.Text = "Remove User";
            this.tsmiRemoveUser.Click += new System.EventHandler(this.tsmiRemoveUser_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(4, 120);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(4, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add User";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(311, 48);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(182, 66);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout and quit";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnOperators
            // 
            this.btnOperators.Location = new System.Drawing.Point(499, 48);
            this.btnOperators.Name = "btnOperators";
            this.btnOperators.Size = new System.Drawing.Size(182, 66);
            this.btnOperators.TabIndex = 6;
            this.btnOperators.Text = "Play Operators game";
            this.btnOperators.UseVisualStyleBackColor = true;
            this.btnOperators.Click += new System.EventHandler(this.btnOperators_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Avgstsmi});
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.statsToolStripMenuItem.Text = "Statistics";
            // 
            // Avgstsmi
            // 
            this.Avgstsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highScoresToolStripMenuItem,
            this.lastScoresToolStripMenuItem});
            this.Avgstsmi.Name = "Avgstsmi";
            this.Avgstsmi.Size = new System.Drawing.Size(147, 22);
            this.Avgstsmi.Text = "Averages";
            // 
            // highScoresToolStripMenuItem
            // 
            this.highScoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classHighScoreToolStripMenuItem,
            this.yearHighScoreToolStripMenuItem,
            this.nationwideYearHighScoreToolStripMenuItem});
            this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.highScoresToolStripMenuItem.Text = "High Scores";
            // 
            // classHighScoreToolStripMenuItem
            // 
            this.classHighScoreToolStripMenuItem.Name = "classHighScoreToolStripMenuItem";
            this.classHighScoreToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.classHighScoreToolStripMenuItem.Text = "Class High Score";
            this.classHighScoreToolStripMenuItem.Click += new System.EventHandler(this.classHighScoreToolStripMenuItem_Click);
            // 
            // yearHighScoreToolStripMenuItem
            // 
            this.yearHighScoreToolStripMenuItem.Name = "yearHighScoreToolStripMenuItem";
            this.yearHighScoreToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.yearHighScoreToolStripMenuItem.Text = "Year High Score";
            this.yearHighScoreToolStripMenuItem.Click += new System.EventHandler(this.yearHighScoreToolStripMenuItem_Click);
            // 
            // nationwideYearHighScoreToolStripMenuItem
            // 
            this.nationwideYearHighScoreToolStripMenuItem.Name = "nationwideYearHighScoreToolStripMenuItem";
            this.nationwideYearHighScoreToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.nationwideYearHighScoreToolStripMenuItem.Text = "Nationwide Year High Score";
            this.nationwideYearHighScoreToolStripMenuItem.Click += new System.EventHandler(this.nationwideYearHighScoreToolStripMenuItem_Click);
            // 
            // lastScoresToolStripMenuItem
            // 
            this.lastScoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classLastScoreToolStripMenuItem,
            this.yearLastScoreToolStripMenuItem,
            this.nationwideYearLastScoreToolStripMenuItem});
            this.lastScoresToolStripMenuItem.Name = "lastScoresToolStripMenuItem";
            this.lastScoresToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.lastScoresToolStripMenuItem.Text = "Last Scores";
            // 
            // classLastScoreToolStripMenuItem
            // 
            this.classLastScoreToolStripMenuItem.Name = "classLastScoreToolStripMenuItem";
            this.classLastScoreToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.classLastScoreToolStripMenuItem.Text = "Class Last Score";
            this.classLastScoreToolStripMenuItem.Click += new System.EventHandler(this.classLastScoreToolStripMenuItem_Click);
            // 
            // yearLastScoreToolStripMenuItem
            // 
            this.yearLastScoreToolStripMenuItem.Name = "yearLastScoreToolStripMenuItem";
            this.yearLastScoreToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.yearLastScoreToolStripMenuItem.Text = "Year Last Score";
            this.yearLastScoreToolStripMenuItem.Click += new System.EventHandler(this.yearLastScoreToolStripMenuItem_Click);
            // 
            // nationwideYearLastScoreToolStripMenuItem
            // 
            this.nationwideYearLastScoreToolStripMenuItem.Name = "nationwideYearLastScoreToolStripMenuItem";
            this.nationwideYearLastScoreToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.nationwideYearLastScoreToolStripMenuItem.Text = "Nationwide Year Last Score";
            this.nationwideYearLastScoreToolStripMenuItem.Click += new System.EventHandler(this.nationwideYearLastScoreToolStripMenuItem_Click);
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 661);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnOperators);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstVStudents);
            this.Controls.Add(this.lblTeacher);
            this.Name = "frmTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MathMatics Teacher";
            this.Load += new System.EventHandler(this.frmTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbMathMaticsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            this.cmsEditUsers.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeacher;
        private dbMathMaticsDataSet dbMathMaticsDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private dbMathMaticsDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.ListView lstVStudents;
        private System.Windows.Forms.ColumnHeader clnName;
        private System.Windows.Forms.ColumnHeader clnTimePlayed;
        private System.Windows.Forms.ColumnHeader clnHighScore;
        private System.Windows.Forms.ColumnHeader clnLastScore;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnOperators;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Avgstsmi;
        private System.Windows.Forms.ToolStripMenuItem highScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classHighScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearHighScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classLastScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearLastScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nationwideYearHighScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nationwideYearLastScoreToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsEditUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveUser;
        private System.Windows.Forms.ColumnHeader clnUser_ID;
    }
}