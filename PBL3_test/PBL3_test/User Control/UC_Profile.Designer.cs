namespace PBL3_test.User_Control
{
    partial class UC_Profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblProfile = new System.Windows.Forms.Label();
            this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            this.PnlProfile = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PnlSex = new System.Windows.Forms.Panel();
            this.RadFemale = new System.Windows.Forms.RadioButton();
            this.RadMale = new System.Windows.Forms.RadioButton();
            this.LblStaffID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblStaffPhone = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtStaffID = new System.Windows.Forms.TextBox();
            this.LblStaffName = new System.Windows.Forms.Label();
            this.LblSex = new System.Windows.Forms.Label();
            this.TxtStaffPhone = new System.Windows.Forms.TextBox();
            this.TxtStaffName = new System.Windows.Forms.TextBox();
            this.PnlProfile.SuspendLayout();
            this.PnlSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblProfile
            // 
            this.LblProfile.AutoSize = true;
            this.LblProfile.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfile.Location = new System.Drawing.Point(13, 10);
            this.LblProfile.Name = "LblProfile";
            this.LblProfile.Size = new System.Drawing.Size(157, 57);
            this.LblProfile.TabIndex = 0;
            this.LblProfile.Text = "Profile";
            // 
            // PnlProfile
            // 
            this.PnlProfile.BackColor = System.Drawing.Color.White;
            this.PnlProfile.Controls.Add(this.BtnSave);
            this.PnlProfile.Controls.Add(this.PnlSex);
            this.PnlProfile.Controls.Add(this.LblStaffID);
            this.PnlProfile.Controls.Add(this.textBox1);
            this.PnlProfile.Controls.Add(this.label2);
            this.PnlProfile.Controls.Add(this.TxtPassword);
            this.PnlProfile.Controls.Add(this.LblPassword);
            this.PnlProfile.Controls.Add(this.LblUsername);
            this.PnlProfile.Controls.Add(this.LblStaffPhone);
            this.PnlProfile.Controls.Add(this.TxtUsername);
            this.PnlProfile.Controls.Add(this.TxtStaffID);
            this.PnlProfile.Controls.Add(this.LblStaffName);
            this.PnlProfile.Controls.Add(this.LblSex);
            this.PnlProfile.Controls.Add(this.TxtStaffPhone);
            this.PnlProfile.Controls.Add(this.TxtStaffName);
            this.PnlProfile.Location = new System.Drawing.Point(23, 70);
            this.PnlProfile.Name = "PnlProfile";
            this.PnlProfile.Size = new System.Drawing.Size(1022, 331);
            this.PnlProfile.TabIndex = 2;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(859, 206);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(116, 69);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // PnlSex
            // 
            this.PnlSex.Controls.Add(this.RadFemale);
            this.PnlSex.Controls.Add(this.RadMale);
            this.PnlSex.Location = new System.Drawing.Point(859, 63);
            this.PnlSex.Name = "PnlSex";
            this.PnlSex.Size = new System.Drawing.Size(94, 63);
            this.PnlSex.TabIndex = 14;
            // 
            // RadFemale
            // 
            this.RadFemale.AutoSize = true;
            this.RadFemale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadFemale.Location = new System.Drawing.Point(3, 34);
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Size = new System.Drawing.Size(89, 26);
            this.RadFemale.TabIndex = 1;
            this.RadFemale.TabStop = true;
            this.RadFemale.Text = "Female";
            this.RadFemale.UseVisualStyleBackColor = true;
            // 
            // RadMale
            // 
            this.RadMale.AutoSize = true;
            this.RadMale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadMale.Location = new System.Drawing.Point(3, 3);
            this.RadMale.Name = "RadMale";
            this.RadMale.Size = new System.Drawing.Size(72, 26);
            this.RadMale.TabIndex = 0;
            this.RadMale.TabStop = true;
            this.RadMale.Text = "Male";
            this.RadMale.UseVisualStyleBackColor = true;
            // 
            // LblStaffID
            // 
            this.LblStaffID.AutoSize = true;
            this.LblStaffID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStaffID.Location = new System.Drawing.Point(88, 38);
            this.LblStaffID.Name = "LblStaffID";
            this.LblStaffID.Size = new System.Drawing.Size(72, 22);
            this.LblStaffID.TabIndex = 8;
            this.LblStaffID.Text = "Staff ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(506, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 30);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(506, 169);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(289, 30);
            this.TxtPassword.TabIndex = 9;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(502, 128);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(88, 22);
            this.LblPassword.TabIndex = 7;
            this.LblPassword.Text = "Password";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(502, 38);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(88, 22);
            this.LblUsername.TabIndex = 4;
            this.LblUsername.Text = "Username";
            // 
            // LblStaffPhone
            // 
            this.LblStaffPhone.AutoSize = true;
            this.LblStaffPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStaffPhone.Location = new System.Drawing.Point(88, 228);
            this.LblStaffPhone.Name = "LblStaffPhone";
            this.LblStaffPhone.Size = new System.Drawing.Size(100, 22);
            this.LblStaffPhone.TabIndex = 3;
            this.LblStaffPhone.Text = "Staff Phone";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(506, 76);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(289, 30);
            this.TxtUsername.TabIndex = 10;
            // 
            // TxtStaffID
            // 
            this.TxtStaffID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStaffID.Location = new System.Drawing.Point(92, 76);
            this.TxtStaffID.Name = "TxtStaffID";
            this.TxtStaffID.Size = new System.Drawing.Size(289, 30);
            this.TxtStaffID.TabIndex = 13;
            // 
            // LblStaffName
            // 
            this.LblStaffName.AutoSize = true;
            this.LblStaffName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStaffName.Location = new System.Drawing.Point(88, 128);
            this.LblStaffName.Name = "LblStaffName";
            this.LblStaffName.Size = new System.Drawing.Size(98, 22);
            this.LblStaffName.TabIndex = 5;
            this.LblStaffName.Text = "Staff Name";
            // 
            // LblSex
            // 
            this.LblSex.AutoSize = true;
            this.LblSex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSex.Location = new System.Drawing.Point(855, 38);
            this.LblSex.Name = "LblSex";
            this.LblSex.Size = new System.Drawing.Size(39, 22);
            this.LblSex.TabIndex = 6;
            this.LblSex.Text = "Sex";
            // 
            // TxtStaffPhone
            // 
            this.TxtStaffPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStaffPhone.Location = new System.Drawing.Point(92, 273);
            this.TxtStaffPhone.Name = "TxtStaffPhone";
            this.TxtStaffPhone.Size = new System.Drawing.Size(289, 30);
            this.TxtStaffPhone.TabIndex = 12;
            // 
            // TxtStaffName
            // 
            this.TxtStaffName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStaffName.Location = new System.Drawing.Point(92, 169);
            this.TxtStaffName.Name = "TxtStaffName";
            this.TxtStaffName.Size = new System.Drawing.Size(289, 30);
            this.TxtStaffName.TabIndex = 11;
            // 
            // UC_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.PnlProfile);
            this.Controls.Add(this.LblProfile);
            this.Name = "UC_Profile";
            this.Size = new System.Drawing.Size(1094, 423);
            this.Load += new System.EventHandler(this.UC_Profile_Load);
            this.PnlProfile.ResumeLayout(false);
            this.PnlProfile.PerformLayout();
            this.PnlSex.ResumeLayout(false);
            this.PnlSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProfile;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.Panel PnlProfile;
        private System.Windows.Forms.Label LblStaffID;
        private System.Windows.Forms.Panel PnlSex;
        private System.Windows.Forms.RadioButton RadFemale;
        private System.Windows.Forms.RadioButton RadMale;
        private System.Windows.Forms.Label LblStaffPhone;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblStaffName;
        private System.Windows.Forms.Label LblSex;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtStaffName;
        private System.Windows.Forms.TextBox TxtStaffPhone;
        private System.Windows.Forms.TextBox TxtStaffID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSave;
    }
}
