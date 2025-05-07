namespace PBL3_test
{
    partial class FrmDashBoardManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashBoardManager));
            this.PnlMoving = new System.Windows.Forms.Panel();
            this.PnlDashBoard_Manager = new System.Windows.Forms.Panel();
            this.BtnStaff_Manager = new System.Windows.Forms.Button();
            this.BtnEditRoom_Manager = new System.Windows.Forms.Button();
            this.BtnRoomList_Manager = new System.Windows.Forms.Button();
            this.BtnRevenue_Manager = new System.Windows.Forms.Button();
            this.BtnPayment_Manager = new System.Windows.Forms.Button();
            this.BtnBooking_Manager = new System.Windows.Forms.Button();
            this.PnlUC_Manager = new System.Windows.Forms.Panel();
            this.uC_EditRoom1 = new PBL3_test.User_Control.UC_EditRoom();
            this.uC_RoomList2 = new PBL3_test.User_Control.UC_RoomList();
            this.uC_Booking1 = new PBL3_test.User_Control.UC_Booking();
            this.uC_Payment1 = new PBL3_test.User_Control.UC_Payment();
            this.uC_Revenue1 = new PBL3_test.User_Control.UC_Revenue();
            this.uC_Staff1 = new PBL3_test.User_Control.UC_Staff();
            this.uC_RoomList1 = new PBL3_test.User_Control.UC_RoomList();
            this.PnlDashBoard_Manager.SuspendLayout();
            this.PnlUC_Manager.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMoving
            // 
            this.PnlMoving.BackColor = System.Drawing.SystemColors.Info;
            this.PnlMoving.Location = new System.Drawing.Point(67, 102);
            this.PnlMoving.Name = "PnlMoving";
            this.PnlMoving.Size = new System.Drawing.Size(160, 5);
            this.PnlMoving.TabIndex = 1;
            // 
            // PnlDashBoard_Manager
            // 
            this.PnlDashBoard_Manager.Controls.Add(this.BtnStaff_Manager);
            this.PnlDashBoard_Manager.Controls.Add(this.BtnEditRoom_Manager);
            this.PnlDashBoard_Manager.Controls.Add(this.BtnRoomList_Manager);
            this.PnlDashBoard_Manager.Controls.Add(this.BtnRevenue_Manager);
            this.PnlDashBoard_Manager.Controls.Add(this.BtnPayment_Manager);
            this.PnlDashBoard_Manager.Controls.Add(this.BtnBooking_Manager);
            this.PnlDashBoard_Manager.Location = new System.Drawing.Point(53, 12);
            this.PnlDashBoard_Manager.Name = "PnlDashBoard_Manager";
            this.PnlDashBoard_Manager.Size = new System.Drawing.Size(1025, 86);
            this.PnlDashBoard_Manager.TabIndex = 3;
            // 
            // BtnStaff_Manager
            // 
            this.BtnStaff_Manager.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStaff_Manager.Location = new System.Drawing.Point(848, 0);
            this.BtnStaff_Manager.Name = "BtnStaff_Manager";
            this.BtnStaff_Manager.Size = new System.Drawing.Size(160, 86);
            this.BtnStaff_Manager.TabIndex = 0;
            this.BtnStaff_Manager.Text = "Staff";
            this.BtnStaff_Manager.UseVisualStyleBackColor = true;
            this.BtnStaff_Manager.Click += new System.EventHandler(this.BtnStaff_Click);
            // 
            // BtnEditRoom_Manager
            // 
            this.BtnEditRoom_Manager.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditRoom_Manager.Location = new System.Drawing.Point(14, 0);
            this.BtnEditRoom_Manager.Name = "BtnEditRoom_Manager";
            this.BtnEditRoom_Manager.Size = new System.Drawing.Size(160, 86);
            this.BtnEditRoom_Manager.TabIndex = 0;
            this.BtnEditRoom_Manager.Text = "Edit Room";
            this.BtnEditRoom_Manager.UseVisualStyleBackColor = true;
            this.BtnEditRoom_Manager.Click += new System.EventHandler(this.BtnEditRoom_Click);
            // 
            // BtnRoomList_Manager
            // 
            this.BtnRoomList_Manager.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoomList_Manager.Location = new System.Drawing.Point(180, 0);
            this.BtnRoomList_Manager.Name = "BtnRoomList_Manager";
            this.BtnRoomList_Manager.Size = new System.Drawing.Size(160, 86);
            this.BtnRoomList_Manager.TabIndex = 0;
            this.BtnRoomList_Manager.Text = "Room List";
            this.BtnRoomList_Manager.UseVisualStyleBackColor = true;
            this.BtnRoomList_Manager.Click += new System.EventHandler(this.BtnRoomList_Click);
            // 
            // BtnRevenue_Manager
            // 
            this.BtnRevenue_Manager.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRevenue_Manager.Location = new System.Drawing.Point(682, 0);
            this.BtnRevenue_Manager.Name = "BtnRevenue_Manager";
            this.BtnRevenue_Manager.Size = new System.Drawing.Size(160, 86);
            this.BtnRevenue_Manager.TabIndex = 0;
            this.BtnRevenue_Manager.Text = "Revenue";
            this.BtnRevenue_Manager.UseVisualStyleBackColor = true;
            this.BtnRevenue_Manager.Click += new System.EventHandler(this.BtnRevenue_Click);
            // 
            // BtnPayment_Manager
            // 
            this.BtnPayment_Manager.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPayment_Manager.Location = new System.Drawing.Point(515, 0);
            this.BtnPayment_Manager.Name = "BtnPayment_Manager";
            this.BtnPayment_Manager.Size = new System.Drawing.Size(160, 86);
            this.BtnPayment_Manager.TabIndex = 0;
            this.BtnPayment_Manager.Text = "Payment";
            this.BtnPayment_Manager.UseVisualStyleBackColor = true;
            this.BtnPayment_Manager.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // BtnBooking_Manager
            // 
            this.BtnBooking_Manager.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBooking_Manager.Location = new System.Drawing.Point(349, 0);
            this.BtnBooking_Manager.Name = "BtnBooking_Manager";
            this.BtnBooking_Manager.Size = new System.Drawing.Size(160, 86);
            this.BtnBooking_Manager.TabIndex = 0;
            this.BtnBooking_Manager.Text = "Booking";
            this.BtnBooking_Manager.UseVisualStyleBackColor = true;
            this.BtnBooking_Manager.Click += new System.EventHandler(this.BtnBooking_Click);
            // 
            // PnlUC_Manager
            // 
            this.PnlUC_Manager.Controls.Add(this.uC_EditRoom1);
            this.PnlUC_Manager.Controls.Add(this.uC_RoomList2);
            this.PnlUC_Manager.Controls.Add(this.uC_Booking1);
            this.PnlUC_Manager.Controls.Add(this.uC_Payment1);
            this.PnlUC_Manager.Controls.Add(this.uC_Revenue1);
            this.PnlUC_Manager.Controls.Add(this.uC_Staff1);
            this.PnlUC_Manager.Controls.Add(this.uC_RoomList1);
            this.PnlUC_Manager.Location = new System.Drawing.Point(12, 123);
            this.PnlUC_Manager.Name = "PnlUC_Manager";
            this.PnlUC_Manager.Size = new System.Drawing.Size(1098, 427);
            this.PnlUC_Manager.TabIndex = 4;
            // 
            // uC_EditRoom1
            // 
            this.uC_EditRoom1.BackColor = System.Drawing.Color.White;
            this.uC_EditRoom1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_EditRoom1.Location = new System.Drawing.Point(0, 0);
            this.uC_EditRoom1.Name = "uC_EditRoom1";
            this.uC_EditRoom1.Size = new System.Drawing.Size(1098, 427);
            this.uC_EditRoom1.TabIndex = 7;
            // 
            // uC_RoomList2
            // 
            this.uC_RoomList2.BackColor = System.Drawing.Color.White;
            this.uC_RoomList2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_RoomList2.Location = new System.Drawing.Point(0, 0);
            this.uC_RoomList2.Name = "uC_RoomList2";
            this.uC_RoomList2.Size = new System.Drawing.Size(1098, 427);
            this.uC_RoomList2.TabIndex = 6;
            // 
            // uC_Booking1
            // 
            this.uC_Booking1.BackColor = System.Drawing.Color.White;
            this.uC_Booking1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Booking1.Location = new System.Drawing.Point(0, 0);
            this.uC_Booking1.Name = "uC_Booking1";
            this.uC_Booking1.Size = new System.Drawing.Size(1098, 427);
            this.uC_Booking1.TabIndex = 5;
            // 
            // uC_Payment1
            // 
            this.uC_Payment1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_Payment1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Payment1.Location = new System.Drawing.Point(0, 0);
            this.uC_Payment1.Name = "uC_Payment1";
            this.uC_Payment1.Size = new System.Drawing.Size(1098, 427);
            this.uC_Payment1.TabIndex = 4;
            // 
            // uC_Revenue1
            // 
            this.uC_Revenue1.BackColor = System.Drawing.Color.White;
            this.uC_Revenue1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Revenue1.Location = new System.Drawing.Point(0, 0);
            this.uC_Revenue1.Name = "uC_Revenue1";
            this.uC_Revenue1.Size = new System.Drawing.Size(1098, 427);
            this.uC_Revenue1.TabIndex = 3;
            // 
            // uC_Staff1
            // 
            this.uC_Staff1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_Staff1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Staff1.Location = new System.Drawing.Point(0, 0);
            this.uC_Staff1.Name = "uC_Staff1";
            this.uC_Staff1.Size = new System.Drawing.Size(1098, 427);
            this.uC_Staff1.TabIndex = 2;
            // 
            // uC_RoomList1
            // 
            this.uC_RoomList1.BackColor = System.Drawing.Color.White;
            this.uC_RoomList1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_RoomList1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_RoomList1.Location = new System.Drawing.Point(0, 0);
            this.uC_RoomList1.Name = "uC_RoomList1";
            this.uC_RoomList1.Size = new System.Drawing.Size(0, 0);
            this.uC_RoomList1.TabIndex = 1;
            // 
            // FrmDashBoardManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1122, 562);
            this.Controls.Add(this.PnlUC_Manager);
            this.Controls.Add(this.PnlDashBoard_Manager);
            this.Controls.Add(this.PnlMoving);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDashBoardManager";
            this.Text = "Hatsune Miku\'s Vila";
            this.Load += new System.EventHandler(this.FrmDashBoard_Load);
            this.PnlDashBoard_Manager.ResumeLayout(false);
            this.PnlUC_Manager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMoving;
        private System.Windows.Forms.Panel PnlDashBoard_Manager;
        private System.Windows.Forms.Button BtnStaff_Manager;
        private System.Windows.Forms.Button BtnEditRoom_Manager;
        private System.Windows.Forms.Button BtnRoomList_Manager;
        private System.Windows.Forms.Button BtnRevenue_Manager;
        private System.Windows.Forms.Button BtnPayment_Manager;
        private System.Windows.Forms.Button BtnBooking_Manager;
        private System.Windows.Forms.Panel PnlUC_Manager;
        private User_Control.UC_RoomList uC_RoomList1;
        private User_Control.UC_EditRoom uC_EditRoom1;
        private User_Control.UC_RoomList uC_RoomList2;
        private User_Control.UC_Booking uC_Booking1;
        private User_Control.UC_Payment uC_Payment1;
        private User_Control.UC_Revenue uC_Revenue1;
        private User_Control.UC_Staff uC_Staff1;
    }
}