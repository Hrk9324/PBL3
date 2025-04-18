using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PBL3_test
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            PicLogin.Image = Image.FromFile("C:/Users/Admin/Documents/code/PBL3/Picture/Login.jpg");
            PicLogin.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=DESKTOP-2G0F3Q1;Initial Catalog=QLKS;Integrated Security=True";
            //SqlConnection conn = null;
            //try
            //{
            //    conn = new SqlConnection(connectionString);
            //    conn.Open();
            //    string query = "SELECT * FROM Account WHERE AccountName = @AccountName AND Password = @Password";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    cmd.Parameters.AddWithValue("@AccountName", TxtAccount.Text);
            //    cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    if (reader.HasRows)
            //    {
            //        MessageBox.Show("Login successful!");
            //        // Open the main form or perform any other action here
            //        this.Hide();
            //        FrmMain mainForm = new FrmMain();
            //        mainForm.ShowDialog();
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid account name or password.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An error occurred: " + ex.Message);
            //}
            //finally
            //{
            //    if (conn != null && conn.State == ConnectionState.Open)
            //    {
            //        conn.Close();
            //    }
            //}


            if (TxtAccount.Text == "" && TxtPassword.Text == "")
            {
                //MessageBox.Show("Login successful!");
                // Open the main form or perform any other action here
                this.Hide();
                FrmDashBoard mainForm = new FrmDashBoard();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid account name or password.");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PnlAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
