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
    public partial class FrmDashBoard : Form
    {
        public FrmDashBoard()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            uC_EditRoom1.Visible = false;
            BtnEditRoom.PerformClick();

            uC_Booking1.Visible = false;
            BtnBooking.PerformClick();

            uC_Payment1.Visible = false;
            BtnPayment.PerformClick();

            uC_Revenue1.Visible = false;
            BtnRevenue.PerformClick();

            uC_RoomList2.Visible = false;
            BtnRoomList.PerformClick();

            uC_Staff1.Visible = false;
            BtnStaff.PerformClick();

        }

        private void BtnEditRoom_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnEditRoom.Left + 35;
            uC_EditRoom1.Visible = true;
            uC_EditRoom1.BringToFront();
        }

        private void BtnRoomList_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnRoomList.Left + 40;
            uC_RoomList2.Visible = true;
            uC_RoomList2.BringToFront();
        }

        private void BtnBooking_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnBooking.Left + 40;
            uC_Booking1.Visible = true;
            uC_Booking1.BringToFront();
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnPayment.Left + 40;
            uC_Payment1.Visible = true;
            uC_Payment1.BringToFront();
        }

        private void BtnRevenue_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnRevenue.Left + 40;
            uC_Revenue1.Visible = true;
            uC_Revenue1.BringToFront();
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnStaff.Left + 40;
            uC_Staff1.Visible = true;
            uC_Staff1.BringToFront();
        }


    }
}
