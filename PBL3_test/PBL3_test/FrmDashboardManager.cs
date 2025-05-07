using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_test
{
    public partial class FrmDashBoardManager : Form
    {
        public FrmDashBoardManager()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            uC_EditRoom1.Visible = false;
            BtnEditRoom_Manager.PerformClick();

            uC_Booking1.Visible = false;
            BtnBooking_Manager.PerformClick();

            uC_Payment1.Visible = false;
            BtnPayment_Manager.PerformClick();

            uC_Revenue1.Visible = false;
            BtnRevenue_Manager.PerformClick();

            uC_RoomList2.Visible = false;
            BtnRoomList_Manager.PerformClick();

            uC_Staff1.Visible = false;
            BtnStaff_Manager.PerformClick();

        }

        private void BtnEditRoom_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnEditRoom_Manager.Left + 40;
            uC_EditRoom1.Visible = true;
            uC_EditRoom1.BringToFront();
        }

        private void BtnRoomList_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnRoomList_Manager.Left + 40;
            uC_RoomList2.Visible = true;
            uC_RoomList2.BringToFront();
        }

        private void BtnBooking_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnBooking_Manager.Left + 40;
            uC_Booking1.Visible = true;
            uC_Booking1.BringToFront();
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnPayment_Manager.Left + 40;
            uC_Payment1.Visible = true;
            uC_Payment1.BringToFront();
        }

        private void BtnRevenue_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnRevenue_Manager.Left + 40;
            uC_Revenue1.Visible = true;
            uC_Revenue1.BringToFront();
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnStaff_Manager.Left + 40;
            uC_Staff1.Visible = true;
            uC_Staff1.BringToFront();
        }


    }
}
