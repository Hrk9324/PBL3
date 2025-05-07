namespace PBL3_test
{
    partial class FrmDashboardStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboardStaff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnProfile_Staff = new System.Windows.Forms.Button();
            this.BtnPayment_Staff = new System.Windows.Forms.Button();
            this.BtnBooking_Staff = new System.Windows.Forms.Button();
            this.BtnRoomList_Staff = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlMoving = new System.Windows.Forms.Panel();
            this.uC_Profile1 = new PBL3_test.User_Control.UC_Profile();
            this.uC_Staff1 = new PBL3_test.User_Control.UC_Staff();
            this.uC_Payment1 = new PBL3_test.User_Control.UC_Payment();
            this.uC_RoomList1 = new PBL3_test.User_Control.UC_RoomList();
            this.uC_Booking1 = new PBL3_test.User_Control.UC_Booking();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnProfile_Staff);
            this.panel1.Controls.Add(this.BtnPayment_Staff);
            this.panel1.Controls.Add(this.BtnBooking_Staff);
            this.panel1.Controls.Add(this.BtnRoomList_Staff);
            this.panel1.Location = new System.Drawing.Point(53, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 86);
            this.panel1.TabIndex = 0;
            // 
            // BtnProfile_Staff
            // 
            this.BtnProfile_Staff.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProfile_Staff.Location = new System.Drawing.Point(69, 0);
            this.BtnProfile_Staff.Name = "BtnProfile_Staff";
            this.BtnProfile_Staff.Size = new System.Drawing.Size(160, 86);
            this.BtnProfile_Staff.TabIndex = 4;
            this.BtnProfile_Staff.Text = "Profile";
            this.BtnProfile_Staff.UseVisualStyleBackColor = true;
            this.BtnProfile_Staff.Click += new System.EventHandler(this.BtnProfile_Staff_Click);
            // 
            // BtnPayment_Staff
            // 
            this.BtnPayment_Staff.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPayment_Staff.Location = new System.Drawing.Point(785, 0);
            this.BtnPayment_Staff.Name = "BtnPayment_Staff";
            this.BtnPayment_Staff.Size = new System.Drawing.Size(160, 86);
            this.BtnPayment_Staff.TabIndex = 3;
            this.BtnPayment_Staff.Text = "Payment";
            this.BtnPayment_Staff.UseVisualStyleBackColor = true;
            // 
            // BtnBooking_Staff
            // 
            this.BtnBooking_Staff.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBooking_Staff.Location = new System.Drawing.Point(304, 0);
            this.BtnBooking_Staff.Name = "BtnBooking_Staff";
            this.BtnBooking_Staff.Size = new System.Drawing.Size(160, 86);
            this.BtnBooking_Staff.TabIndex = 2;
            this.BtnBooking_Staff.Text = "Booking";
            this.BtnBooking_Staff.UseVisualStyleBackColor = true;
            // 
            // BtnRoomList_Staff
            // 
            this.BtnRoomList_Staff.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoomList_Staff.Location = new System.Drawing.Point(542, 0);
            this.BtnRoomList_Staff.Name = "BtnRoomList_Staff";
            this.BtnRoomList_Staff.Size = new System.Drawing.Size(160, 86);
            this.BtnRoomList_Staff.TabIndex = 1;
            this.BtnRoomList_Staff.Text = "Room List";
            this.BtnRoomList_Staff.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Profile1);
            this.panel2.Controls.Add(this.uC_Staff1);
            this.panel2.Controls.Add(this.uC_Payment1);
            this.panel2.Controls.Add(this.uC_RoomList1);
            this.panel2.Controls.Add(this.uC_Booking1);
            this.panel2.Location = new System.Drawing.Point(12, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1098, 427);
            this.panel2.TabIndex = 1;
            // 
            // PnlMoving
            // 
            this.PnlMoving.BackColor = System.Drawing.SystemColors.Info;
            this.PnlMoving.Location = new System.Drawing.Point(122, 104);
            this.PnlMoving.Name = "PnlMoving";
            this.PnlMoving.Size = new System.Drawing.Size(160, 5);
            this.PnlMoving.TabIndex = 2;
            // 
            // uC_Profile1
            // 
            this.uC_Profile1.BackColor = System.Drawing.Color.White;
            this.uC_Profile1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Profile1.Location = new System.Drawing.Point(1, 1);
            this.uC_Profile1.Name = "uC_Profile1";
            this.uC_Profile1.Size = new System.Drawing.Size(1094, 423);
            this.uC_Profile1.TabIndex = 4;
            // 
            // uC_Staff1
            // 
            this.uC_Staff1.Location = new System.Drawing.Point(512, 66);
            this.uC_Staff1.Name = "uC_Staff1";
            this.uC_Staff1.Size = new System.Drawing.Size(8, 8);
            this.uC_Staff1.TabIndex = 3;
            // 
            // uC_Payment1
            // 
            this.uC_Payment1.BackColor = System.Drawing.Color.White;
            this.uC_Payment1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Payment1.Location = new System.Drawing.Point(0, 0);
            this.uC_Payment1.Name = "uC_Payment1";
            this.uC_Payment1.Size = new System.Drawing.Size(1098, 427);
            this.uC_Payment1.TabIndex = 2;
            // 
            // uC_RoomList1
            // 
            this.uC_RoomList1.BackColor = System.Drawing.Color.White;
            this.uC_RoomList1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_RoomList1.Location = new System.Drawing.Point(0, 0);
            this.uC_RoomList1.Name = "uC_RoomList1";
            this.uC_RoomList1.Size = new System.Drawing.Size(1098, 427);
            this.uC_RoomList1.TabIndex = 1;
            // 
            // uC_Booking1
            // 
            this.uC_Booking1.BackColor = System.Drawing.Color.White;
            this.uC_Booking1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Booking1.Location = new System.Drawing.Point(0, 0);
            this.uC_Booking1.Name = "uC_Booking1";
            this.uC_Booking1.Size = new System.Drawing.Size(1098, 427);
            this.uC_Booking1.TabIndex = 0;
            // 
            // FrmDashboardStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1122, 562);
            this.Controls.Add(this.PnlMoving);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDashboardStaff";
            this.Text = "Hatsune Miku\'s Vila";
            this.Load += new System.EventHandler(this.FrmDashboardStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlMoving;
        private System.Windows.Forms.Button BtnRoomList_Staff;
        private System.Windows.Forms.Button BtnBooking_Staff;
        private System.Windows.Forms.Button BtnPayment_Staff;
        private System.Windows.Forms.Button BtnProfile_Staff;
        private User_Control.UC_Payment uC_Payment1;
        private User_Control.UC_RoomList uC_RoomList1;
        private User_Control.UC_Booking uC_Booking1;
        private User_Control.UC_Staff uC_Staff1;
        private User_Control.UC_Profile uC_Profile1;
    }
}