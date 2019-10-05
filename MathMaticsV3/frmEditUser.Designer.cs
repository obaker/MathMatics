namespace MathMaticsV3
{
    partial class frmEditUser
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
            this.nudSchoolYear = new System.Windows.Forms.NumericUpDown();
            this.lblLastAction = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSchoolYear)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSchoolYear
            // 
            this.nudSchoolYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSchoolYear.Location = new System.Drawing.Point(115, 213);
            this.nudSchoolYear.Margin = new System.Windows.Forms.Padding(0);
            this.nudSchoolYear.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudSchoolYear.Name = "nudSchoolYear";
            this.nudSchoolYear.Size = new System.Drawing.Size(166, 35);
            this.nudSchoolYear.TabIndex = 68;
            // 
            // lblLastAction
            // 
            this.lblLastAction.AutoSize = true;
            this.lblLastAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLastAction.Location = new System.Drawing.Point(26, 50);
            this.lblLastAction.Name = "lblLastAction";
            this.lblLastAction.Size = new System.Drawing.Size(133, 17);
            this.lblLastAction.TabIndex = 67;
            this.lblLastAction.Text = "Launched Edit User";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(29, 284);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(252, 55);
            this.btnEdit.TabIndex = 66;
            this.btnEdit.Text = "Edit User";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(26, 227);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(65, 13);
            this.lblYear.TabIndex = 65;
            this.lblYear.Text = "School Year";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 171);
            this.txtName.MinimumSize = new System.Drawing.Size(4, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 35);
            this.txtName.TabIndex = 64;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 174);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 63;
            this.lblName.Text = "Full Name";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(115, 131);
            this.txtPwd.MinimumSize = new System.Drawing.Size(4, 35);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(166, 35);
            this.txtPwd.TabIndex = 62;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(21, 134);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 13);
            this.lblPwd.TabIndex = 61;
            this.lblPwd.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(21, 87);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 60;
            this.lblUsername.Text = "Username";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.Location = new System.Drawing.Point(20, 18);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(179, 20);
            this.lblEdit.TabIndex = 59;
            this.lblEdit.Text = "Editing User as Teacher";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(115, 84);
            this.txtUser.MinimumSize = new System.Drawing.Size(4, 35);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(166, 35);
            this.txtUser.TabIndex = 58;
            // 
            // frmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.nudSchoolYear);
            this.Controls.Add(this.lblLastAction);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.txtUser);
            this.Name = "frmEditUser";
            this.Text = "Editing User";
            this.Load += new System.EventHandler(this.frmEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSchoolYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSchoolYear;
        private System.Windows.Forms.Label lblLastAction;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.TextBox txtUser;
    }
}