namespace PBL3_test
{
    partial class FrmDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashBoard));
            this.PnlMoving = new System.Windows.Forms.Panel();
            this.PnlDashBoard = new System.Windows.Forms.Panel();
            this.BtnStaff = new System.Windows.Forms.Button();
            this.BtnEditRoom = new System.Windows.Forms.Button();
            this.BtnRoomList = new System.Windows.Forms.Button();
            this.BtnRevenue = new System.Windows.Forms.Button();
            this.BtnPayment = new System.Windows.Forms.Button();
            this.BtnBooking = new System.Windows.Forms.Button();
            this.PnlUC = new System.Windows.Forms.Panel();
            this.uC_EditRoom1 = new PBL3_test.User_Control.UC_EditRoom();
            this.uC_RoomList2 = new PBL3_test.User_Control.UC_RoomList();
            this.uC_Booking1 = new PBL3_test.User_Control.UC_Booking();
            this.uC_Payment1 = new PBL3_test.User_Control.UC_Payment();
            this.uC_Revenue1 = new PBL3_test.User_Control.UC_Revenue();
            this.uC_Staff1 = new PBL3_test.User_Control.UC_Staff();
            this.uC_RoomList1 = new PBL3_test.User_Control.UC_RoomList();
            this.PnlDashBoard.SuspendLayout();
            this.PnlUC.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMoving
            // 
            this.PnlMoving.BackColor = System.Drawing.SystemColors.Info;
            this.PnlMoving.Location = new System.Drawing.Point(67, 102);
            this.PnlMoving.Name = "PnlMoving";
            this.PnlMoving.Size = new System.Drawing.Size(170, 5);
            this.PnlMoving.TabIndex = 1;
            // 
            // PnlDashBoard
            // 
            this.PnlDashBoard.Controls.Add(this.BtnStaff);
            this.PnlDashBoard.Controls.Add(this.BtnEditRoom);
            this.PnlDashBoard.Controls.Add(this.BtnRoomList);
            this.PnlDashBoard.Controls.Add(this.BtnRevenue);
            this.PnlDashBoard.Controls.Add(this.BtnPayment);
            this.PnlDashBoard.Controls.Add(this.BtnBooking);
            this.PnlDashBoard.Location = new System.Drawing.Point(53, 12);
            this.PnlDashBoard.Name = "PnlDashBoard";
            this.PnlDashBoard.Size = new System.Drawing.Size(1025, 86);
            this.PnlDashBoard.TabIndex = 3;
            // 
            // BtnStaff
            // 
            this.BtnStaff.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStaff.Location = new System.Drawing.Point(849, 5);
            this.BtnStaff.Name = "BtnStaff";
            this.BtnStaff.Size = new System.Drawing.Size(161, 81);
            this.BtnStaff.TabIndex = 0;
            this.BtnStaff.Text = "Staff";
            this.BtnStaff.UseVisualStyleBackColor = true;
            this.BtnStaff.Click += new System.EventHandler(this.BtnStaff_Click);
            // 
            // BtnEditRoom
            // 
            this.BtnEditRoom.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditRoom.Location = new System.Drawing.Point(14, 3);
            this.BtnEditRoom.Name = "BtnEditRoom";
            this.BtnEditRoom.Size = new System.Drawing.Size(161, 81);
            this.BtnEditRoom.TabIndex = 0;
            this.BtnEditRoom.Text = "Edit Room";
            this.BtnEditRoom.UseVisualStyleBackColor = true;
            this.BtnEditRoom.Click += new System.EventHandler(this.BtnEditRoom_Click);
            // 
            // BtnRoomList
            // 
            this.BtnRoomList.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoomList.Location = new System.Drawing.Point(181, 3);
            this.BtnRoomList.Name = "BtnRoomList";
            this.BtnRoomList.Size = new System.Drawing.Size(161, 81);
            this.BtnRoomList.TabIndex = 0;
            this.BtnRoomList.Text = "Room List";
            this.BtnRoomList.UseVisualStyleBackColor = true;
            this.BtnRoomList.Click += new System.EventHandler(this.BtnRoomList_Click);
            // 
            // BtnRevenue
            // 
            this.BtnRevenue.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRevenue.Location = new System.Drawing.Point(682, 3);
            this.BtnRevenue.Name = "BtnRevenue";
            this.BtnRevenue.Size = new System.Drawing.Size(161, 81);
            this.BtnRevenue.TabIndex = 0;
            this.BtnRevenue.Text = "Revenue";
            this.BtnRevenue.UseVisualStyleBackColor = true;
            this.BtnRevenue.Click += new System.EventHandler(this.BtnRevenue_Click);
            // 
            // BtnPayment
            // 
            this.BtnPayment.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPayment.Location = new System.Drawing.Point(515, 2);
            this.BtnPayment.Name = "BtnPayment";
            this.BtnPayment.Size = new System.Drawing.Size(161, 81);
            this.BtnPayment.TabIndex = 0;
            this.BtnPayment.Text = "Payment";
            this.BtnPayment.UseVisualStyleBackColor = true;
            this.BtnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // BtnBooking
            // 
            this.BtnBooking.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBooking.Location = new System.Drawing.Point(348, 3);
            this.BtnBooking.Name = "BtnBooking";
            this.BtnBooking.Size = new System.Drawing.Size(161, 81);
            this.BtnBooking.TabIndex = 0;
            this.BtnBooking.Text = "Booking";
            this.BtnBooking.UseVisualStyleBackColor = true;
            this.BtnBooking.Click += new System.EventHandler(this.BtnBooking_Click);
            // 
            // PnlUC
            // 
            this.PnlUC.Controls.Add(this.uC_EditRoom1);
            this.PnlUC.Controls.Add(this.uC_RoomList2);
            this.PnlUC.Controls.Add(this.uC_Booking1);
            this.PnlUC.Controls.Add(this.uC_Payment1);
            this.PnlUC.Controls.Add(this.uC_Revenue1);
            this.PnlUC.Controls.Add(this.uC_Staff1);
            this.PnlUC.Controls.Add(this.uC_RoomList1);
            this.PnlUC.Location = new System.Drawing.Point(12, 123);
            this.PnlUC.Name = "PnlUC";
            this.PnlUC.Size = new System.Drawing.Size(1098, 427);
            this.PnlUC.TabIndex = 4;
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
            // FrmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1122, 562);
            this.Controls.Add(this.PnlUC);
            this.Controls.Add(this.PnlDashBoard);
            this.Controls.Add(this.PnlMoving);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDashBoard";
            this.Text = "Hatsune Miku\'s Vila";
            this.Load += new System.EventHandler(this.FrmDashBoard_Load);
            this.PnlDashBoard.ResumeLayout(false);
            this.PnlUC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMoving;
        private System.Windows.Forms.Panel PnlDashBoard;
        private System.Windows.Forms.Button BtnStaff;
        private System.Windows.Forms.Button BtnEditRoom;
        private System.Windows.Forms.Button BtnRoomList;
        private System.Windows.Forms.Button BtnRevenue;
        private System.Windows.Forms.Button BtnPayment;
        private System.Windows.Forms.Button BtnBooking;
        private System.Windows.Forms.Panel PnlUC;
        private User_Control.UC_RoomList uC_RoomList1;
        private User_Control.UC_EditRoom uC_EditRoom1;
        private User_Control.UC_RoomList uC_RoomList2;
        private User_Control.UC_Booking uC_Booking1;
        private User_Control.UC_Payment uC_Payment1;
        private User_Control.UC_Revenue uC_Revenue1;
        private User_Control.UC_Staff uC_Staff1;
    }
}