namespace PBL3_test.User_Control
{
    partial class UC_EditRoom
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
            this.LblEdit = new System.Windows.Forms.Label();
            this.DgvEditRoom = new System.Windows.Forms.DataGridView();
            this.LblRoomNumber = new System.Windows.Forms.Label();
            this.TxtRoomNumber = new System.Windows.Forms.TextBox();
            this.CboRoomType = new System.Windows.Forms.ComboBox();
            this.LblRoomType = new System.Windows.Forms.Label();
            this.LblRoomRate = new System.Windows.Forms.Label();
            this.TxtRoomRate = new System.Windows.Forms.TextBox();
            this.LblRoomAvailability = new System.Windows.Forms.Label();
            this.CboRoomAvailability = new System.Windows.Forms.ComboBox();
            this.BtnSaveEditRoom = new System.Windows.Forms.Button();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEditRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // LblEdit
            // 
            this.LblEdit.AutoSize = true;
            this.LblEdit.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdit.Location = new System.Drawing.Point(18, 12);
            this.LblEdit.Name = "LblEdit";
            this.LblEdit.Size = new System.Drawing.Size(243, 57);
            this.LblEdit.TabIndex = 0;
            this.LblEdit.Text = "Edit Room";
            // 
            // DgvEditRoom
            // 
            this.DgvEditRoom.BackgroundColor = System.Drawing.Color.White;
            this.DgvEditRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEditRoom.Location = new System.Drawing.Point(28, 92);
            this.DgvEditRoom.Name = "DgvEditRoom";
            this.DgvEditRoom.RowHeadersWidth = 51;
            this.DgvEditRoom.RowTemplate.Height = 24;
            this.DgvEditRoom.Size = new System.Drawing.Size(510, 320);
            this.DgvEditRoom.TabIndex = 1;
            // 
            // LblRoomNumber
            // 
            this.LblRoomNumber.AutoSize = true;
            this.LblRoomNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRoomNumber.Location = new System.Drawing.Point(571, 116);
            this.LblRoomNumber.Name = "LblRoomNumber";
            this.LblRoomNumber.Size = new System.Drawing.Size(125, 22);
            this.LblRoomNumber.TabIndex = 2;
            this.LblRoomNumber.Text = "Room Number";
            // 
            // TxtRoomNumber
            // 
            this.TxtRoomNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRoomNumber.Location = new System.Drawing.Point(574, 144);
            this.TxtRoomNumber.Name = "TxtRoomNumber";
            this.TxtRoomNumber.Size = new System.Drawing.Size(220, 30);
            this.TxtRoomNumber.TabIndex = 3;
            // 
            // CboRoomType
            // 
            this.CboRoomType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboRoomType.FormattingEnabled = true;
            this.CboRoomType.Location = new System.Drawing.Point(843, 144);
            this.CboRoomType.Name = "CboRoomType";
            this.CboRoomType.Size = new System.Drawing.Size(220, 30);
            this.CboRoomType.TabIndex = 4;
            // 
            // LblRoomType
            // 
            this.LblRoomType.AutoSize = true;
            this.LblRoomType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRoomType.Location = new System.Drawing.Point(840, 116);
            this.LblRoomType.Name = "LblRoomType";
            this.LblRoomType.Size = new System.Drawing.Size(101, 22);
            this.LblRoomType.TabIndex = 2;
            this.LblRoomType.Text = "Room Type";
            // 
            // LblRoomRate
            // 
            this.LblRoomRate.AutoSize = true;
            this.LblRoomRate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRoomRate.Location = new System.Drawing.Point(572, 266);
            this.LblRoomRate.Name = "LblRoomRate";
            this.LblRoomRate.Size = new System.Drawing.Size(98, 22);
            this.LblRoomRate.TabIndex = 2;
            this.LblRoomRate.Text = "Room Rate";
            // 
            // TxtRoomRate
            // 
            this.TxtRoomRate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRoomRate.Location = new System.Drawing.Point(575, 296);
            this.TxtRoomRate.Name = "TxtRoomRate";
            this.TxtRoomRate.Size = new System.Drawing.Size(220, 30);
            this.TxtRoomRate.TabIndex = 3;
            // 
            // LblRoomAvailability
            // 
            this.LblRoomAvailability.AutoSize = true;
            this.LblRoomAvailability.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRoomAvailability.Location = new System.Drawing.Point(572, 199);
            this.LblRoomAvailability.Name = "LblRoomAvailability";
            this.LblRoomAvailability.Size = new System.Drawing.Size(156, 22);
            this.LblRoomAvailability.TabIndex = 2;
            this.LblRoomAvailability.Text = "Room Availability";
            // 
            // CboRoomAvailability
            // 
            this.CboRoomAvailability.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboRoomAvailability.FormattingEnabled = true;
            this.CboRoomAvailability.Location = new System.Drawing.Point(575, 228);
            this.CboRoomAvailability.Name = "CboRoomAvailability";
            this.CboRoomAvailability.Size = new System.Drawing.Size(220, 30);
            this.CboRoomAvailability.TabIndex = 4;
            // 
            // BtnSaveEditRoom
            // 
            this.BtnSaveEditRoom.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveEditRoom.Location = new System.Drawing.Point(903, 316);
            this.BtnSaveEditRoom.Name = "BtnSaveEditRoom";
            this.BtnSaveEditRoom.Size = new System.Drawing.Size(109, 63);
            this.BtnSaveEditRoom.TabIndex = 5;
            this.BtnSaveEditRoom.Text = "Save";
            this.BtnSaveEditRoom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(840, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Room Description";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(844, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 30);
            this.textBox1.TabIndex = 7;
            // 
            // UC_EditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSaveEditRoom);
            this.Controls.Add(this.CboRoomAvailability);
            this.Controls.Add(this.CboRoomType);
            this.Controls.Add(this.TxtRoomRate);
            this.Controls.Add(this.TxtRoomNumber);
            this.Controls.Add(this.LblRoomAvailability);
            this.Controls.Add(this.LblRoomRate);
            this.Controls.Add(this.LblRoomType);
            this.Controls.Add(this.LblRoomNumber);
            this.Controls.Add(this.DgvEditRoom);
            this.Controls.Add(this.LblEdit);
            this.Name = "UC_EditRoom";
            this.Size = new System.Drawing.Size(1098, 427);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEditRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEdit;
        private System.Windows.Forms.DataGridView DgvEditRoom;
        private System.Windows.Forms.Label LblRoomNumber;
        private System.Windows.Forms.TextBox TxtRoomNumber;
        private System.Windows.Forms.ComboBox CboRoomType;
        private System.Windows.Forms.Label LblRoomType;
        private System.Windows.Forms.Label LblRoomRate;
        private System.Windows.Forms.TextBox TxtRoomRate;
        private System.Windows.Forms.Label LblRoomAvailability;
        private System.Windows.Forms.ComboBox CboRoomAvailability;
        private System.Windows.Forms.Button BtnSaveEditRoom;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
