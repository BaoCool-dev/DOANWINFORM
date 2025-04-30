using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            string connectionString = "Data Source=DESKTOP-G8H86K3\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE username = @user AND password = @pass";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", userName);
                    cmd.Parameters.AddWithValue("@pass", password);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        Form1 form1 = new Form1();
                        this.Hide();
                        form1.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblClearField_Click(object sender, EventArgs e)
        {
            tbPassword.Clear();
            tbUsername.Clear();
            tbUsername.Focus();
        }
        private bool isImage = true;
        private void pbLock_Click(object sender, EventArgs e)
        {
            if (isImage)
            {
                pbLock.Image = Properties.Resources.unlock__3_;
                pbUser.Image = Properties.Resources.ChatGPT_Image_Apr_30__2025__07_22_30_PM_removebg_preview;
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                pbLock.Image = Properties.Resources._lock;
                pbUser.Image = Properties.Resources.ChatGPT_Image_Apr_30__2025__07_21_55_PM_removebg_preview;
                tbPassword.PasswordChar = '*';
            }

            isImage = !isImage;
        }

        private void lblClearfield_MouseEnter(object sender, EventArgs e)
        {
            lblClearField.Font = new Font(lblClearField.Font.FontFamily, lblClearField.Font.Size, FontStyle.Underline);
        }

        private void lblClearfield_MouseLeave(object sender, EventArgs e)
        {
            lblClearField.Font = new Font(lblClearField.Font.FontFamily, lblClearField.Font.Size, FontStyle.Bold);
        }

        private void lblExit_mouseEnter(object sender, EventArgs e)
        {
            lblExit.Font = new Font(lblExit.Font.FontFamily, lblExit.Font.Size, FontStyle.Underline);
        }

        private void lblExit_mouseLeave(object sender, EventArgs e)
        {
            lblExit.Font = new Font(lblExit.Font.FontFamily, lblExit.Font.Size, FontStyle.Bold);
        }
    }
}
