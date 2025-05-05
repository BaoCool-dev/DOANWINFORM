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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLySinhVien
{
    public partial class ThongTinCaNhan_SinhVien : Form
    {
        string mssv;
        public ThongTinCaNhan_SinhVien(string mssv)
        {
            InitializeComponent();
            this.mssv = mssv;
            loadThongTinSinhVien();
        }
        public void loadThongTinSinhVien()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT 
                                    sv.Họ_và_Tên, sv.Ngày_Sinh, sv.Quê_Quán, sv.Giới_Tính, sv.CCCD, 
                                    sv.Tôn_Giáo, sv.Quốc_Tịch, sv.Lớp,
                                    ll.Tỉnh, ll.Huyện, ll.Xã, ll.SDT, ll.Email_Trường, ll.Email_Cá_Nhân
                                FROM Thông_Tin_Sinh_Viên sv
                                JOIN Thông_Tin_Liên_Lạc ll ON sv.Mã_Sinh_Viên = ll.Mã
                                WHERE sv.Mã_Sinh_Viên = @mssv";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mssv", mssv);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lb_HovaTen.Text = reader["Họ_và_Tên"].ToString();
                        lb_NgaySinh.Text = Convert.ToDateTime(reader["Ngày_Sinh"]).ToString("dd/MM/yyyy");
                        lb_QueQuan.Text = reader["Quê_Quán"].ToString().ToString();
                        lb_GioiTinh.Text = reader["Giới_Tính"].ToString();
                        lb_CCCD.Text = reader["CCCD"].ToString();
                        lb_TonGiao.Text = reader["Tôn_Giáo"].ToString();
                        lb_QuocTich.Text = reader["Quốc_Tịch"].ToString();
                        lb_Tinh_ThanhPho.Text = reader["Tỉnh"].ToString();
                        lb_Huyen.Text = reader["Huyện"].ToString();
                        lb_Xa.Text = reader["Xã"].ToString();
                        lb_SDT.Text = reader["SDT"].ToString();
                        lb_email.Text = reader["Email_Cá_Nhân"].ToString();
                        lb_email_truong.Text = reader["Email_Trường"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên với MSSV này!");
                    }
                }
            }
        }
    }
}
