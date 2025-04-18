namespace PBL3_test.User_Control
{
    partial class UC_Staff
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
            this.components = new System.ComponentModel.Container();
            this.Staff = new System.Windows.Forms.Label();
            this.PnlStaffInfomation = new System.Windows.Forms.Panel();
            this.LblStaffPhone = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblStaffName = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtStaffName = new System.Windows.Forms.TextBox();
            this.TxtStaffPhone = new System.Windows.Forms.TextBox();
            this.TxtStaffID = new System.Windows.Forms.TextBox();
            this.LblStaffID = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LblSex = new System.Windows.Forms.Label();
            this.PnlSex = new System.Windows.Forms.Panel();
            this.RadMale = new System.Windows.Forms.RadioButton();
            this.RadFemale = new System.Windows.Forms.RadioButton();
            this.BtnSave = new System.Windows.Forms.Button();
            this.DgvStaffInfomationList = new System.Windows.Forms.DataGridView();
            this.PnlStaffInfomation.SuspendLayout();
            this.PnlSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStaffInfomationList)).BeginInit();
            this.SuspendLayout();
            // 
            // Staff
            // 
            this.Staff.AutoSize = true;
            this.Staff.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff.Location = new System.Drawing.Point(19, 14);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(119, 57);
            this.Staff.TabIndex = 0;
            this.Staff.Text = "Staff";
            // 
            // PnlStaffInfomation
            // 
            this.PnlStaffInfomation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlStaffInfomation.Controls.Add(this.BtnSave);
            this.PnlStaffInfomation.Controls.Add(this.PnlSex);
            this.PnlStaffInfomation.Controls.Add(this.LblStaffPhone);
            this.PnlStaffInfomation.Controls.Add(this.LblUsername);
            this.PnlStaffInfomation.Controls.Add(this.LblStaffName);
            this.PnlStaffInfomation.Controls.Add(this.LblSex);
            this.PnlStaffInfomation.Controls.Add(this.LblPassword);
            this.PnlStaffInfomation.Controls.Add(this.TxtPassword);
            this.PnlStaffInfomation.Controls.Add(this.TxtUsername);
            this.PnlStaffInfomation.Controls.Add(this.TxtStaffName);
            this.PnlStaffInfomation.Controls.Add(this.TxtStaffPhone);
            this.PnlStaffInfomation.Controls.Add(this.TxtStaffID);
            this.PnlStaffInfomation.Controls.Add(this.LblStaffID);
            this.PnlStaffInfomation.Location = new System.Drawing.Point(513, 86);
            this.PnlStaffInfomation.Name = "PnlStaffInfomation";
            this.PnlStaffInfomation.Size = new System.Drawing.Size(549, 314);
            this.PnlStaffInfomation.TabIndex = 2;
            // 
            // LblStaffPhone
            // 
            this.LblStaffPhone.AutoSize = true;
            this.LblStaffPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStaffPhone.Location = new System.Drawing.Point(64, 113);
            this.LblStaffPhone.Name = "LblStaffPhone";
            this.LblStaffPhone.Size = new System.Drawing.Size(100, 22);
            this.LblStaffPhone.TabIndex = 0;
            this.LblStaffPhone.Text = "Staff Phone";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(64, 149);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(88, 22);
            this.LblUsername.TabIndex = 0;
            this.LblUsername.Text = "Username";
            // 
            // LblStaffName
            // 
            this.LblStaffName.AutoSize = true;
            this.LblStaffName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStaffName.Location = new System.Drawing.Point(64, 77);
            this.LblStaffName.Name = "LblStaffName";
            this.LblStaffName.Size = new System.Drawing.Size(98, 22);
            this.LblStaffName.TabIndex = 0;
            this.LblStaffName.Text = "Staff Name";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(64, 185);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(88, 22);
            this.LblPassword.TabIndex = 0;
            this.LblPassword.Text = "Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(199, 177);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(289, 30);
            this.TxtPassword.TabIndex = 1;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(199, 141);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(289, 30);
            this.TxtUsername.TabIndex = 1;
            // 
            // TxtStaffName
            // 
            this.TxtStaffName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStaffName.Location = new System.Drawing.Point(199, 69);
            this.TxtStaffName.Name = "TxtStaffName";
            this.TxtStaffName.Size = new System.Drawing.Size(289, 30);
            this.TxtStaffName.TabIndex = 1;
            // 
            // TxtStaffPhone
            // 
            this.TxtStaffPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStaffPhone.Location = new System.Drawing.Point(199, 105);
            this.TxtStaffPhone.Name = "TxtStaffPhone";
            this.TxtStaffPhone.Size = new System.Drawing.Size(289, 30);
            this.TxtStaffPhone.TabIndex = 1;
            // 
            // TxtStaffID
            // 
            this.TxtStaffID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStaffID.Location = new System.Drawing.Point(199, 33);
            this.TxtStaffID.Name = "TxtStaffID";
            this.TxtStaffID.Size = new System.Drawing.Size(289, 30);
            this.TxtStaffID.TabIndex = 1;
            // 
            // LblStaffID
            // 
            this.LblStaffID.AutoSize = true;
            this.LblStaffID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStaffID.Location = new System.Drawing.Point(64, 41);
            this.LblStaffID.Name = "LblStaffID";
            this.LblStaffID.Size = new System.Drawing.Size(72, 22);
            this.LblStaffID.TabIndex = 0;
            this.LblStaffID.Text = "Staff ID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LblSex
            // 
            this.LblSex.AutoSize = true;
            this.LblSex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSex.Location = new System.Drawing.Point(64, 223);
            this.LblSex.Name = "LblSex";
            this.LblSex.Size = new System.Drawing.Size(39, 22);
            this.LblSex.TabIndex = 0;
            this.LblSex.Text = "Sex";
            // 
            // PnlSex
            // 
            this.PnlSex.Controls.Add(this.RadFemale);
            this.PnlSex.Controls.Add(this.RadMale);
            this.PnlSex.Location = new System.Drawing.Point(199, 223);
            this.PnlSex.Name = "PnlSex";
            this.PnlSex.Size = new System.Drawing.Size(94, 63);
            this.PnlSex.TabIndex = 2;
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
            // RadFemale
            // 
            this.RadFemale.AutoSize = true;
            this.RadFemale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadFemale.Location = new System.Drawing.Point(3, 35);
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Size = new System.Drawing.Size(89, 26);
            this.RadFemale.TabIndex = 1;
            this.RadFemale.TabStop = true;
            this.RadFemale.Text = "Female";
            this.RadFemale.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.BtnSave.Location = new System.Drawing.Point(369, 231);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(107, 55);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // DgvStaffInfomationList
            // 
            this.DgvStaffInfomationList.BackgroundColor = System.Drawing.Color.White;
            this.DgvStaffInfomationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStaffInfomationList.Location = new System.Drawing.Point(29, 86);
            this.DgvStaffInfomationList.Name = "DgvStaffInfomationList";
            this.DgvStaffInfomationList.RowHeadersWidth = 51;
            this.DgvStaffInfomationList.RowTemplate.Height = 24;
            this.DgvStaffInfomationList.Size = new System.Drawing.Size(437, 314);
            this.DgvStaffInfomationList.TabIndex = 3;
            // 
            // UC_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DgvStaffInfomationList);
            this.Controls.Add(this.PnlStaffInfomation);
            this.Controls.Add(this.Staff);
            this.Name = "UC_Staff";
            this.Size = new System.Drawing.Size(1098, 427);
            this.PnlStaffInfomation.ResumeLayout(false);
            this.PnlStaffInfomation.PerformLayout();
            this.PnlSex.ResumeLayout(false);
            this.PnlSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStaffInfomationList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Staff;
        private System.Windows.Forms.Panel PnlStaffInfomation;
        private System.Windows.Forms.Label LblStaffID;
        private System.Windows.Forms.TextBox TxtStaffID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label LblStaffPhone;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblStaffName;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtStaffName;
        private System.Windows.Forms.TextBox TxtStaffPhone;
        private System.Windows.Forms.Label LblSex;
        private System.Windows.Forms.Panel PnlSex;
        private System.Windows.Forms.RadioButton RadFemale;
        private System.Windows.Forms.RadioButton RadMale;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridView DgvStaffInfomationList;
    }
}
