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
    public partial class FrmDashboardStaff : Form
    {
        public FrmDashboardStaff()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        private void FrmDashboardStaff_Load(object sender, EventArgs e)
        {
            uC_Payment1.Visible = false;
            BtnPayment_Staff.PerformClick();

            uC_RoomList1.Visible = false;
            BtnRoomList_Staff.PerformClick();

            uC_Booking1.Visible = false;
            BtnBooking_Staff.PerformClick();

            uC_Profile1.Visible = false;
            BtnProfile_Staff.PerformClick();
        }

        private void BtnProfile_Staff_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnProfile_Staff.Left + 40;
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }

        private void BtnPayment_Staff_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnPayment_Staff.Left + 40;
            uC_Payment1.Visible = true;
            uC_Payment1.BringToFront();
        }

        private void BtnRoomList_Staff_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnRoomList_Staff.Left + 40;
            uC_RoomList1.Visible = true;
            uC_RoomList1.BringToFront();
        }

        private void BtnBooking_Staff_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnBooking_Staff.Left + 40;
            uC_Booking1.Visible = true;
            uC_Booking1.BringToFront();
        }

    }
}
