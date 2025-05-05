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
    public partial class ThongTin_GiangVien : Form
    {
        string position;
        public ThongTin_GiangVien(string position)
        {
            InitializeComponent();
            this.position = position;
            loadThongTinSinhVien();
        }
        public void loadThongTinSinhVien()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT 
                                    gv.Họ_và_Tên, gv.Ngày_Sinh, gv.Quê_Quán, gv.Giới_Tính, gv.CCCD, 
                                    gv.Tôn_Giáo, gv.Quốc_Tịch, gv.Lớp,
                                    ll.Tỉnh, ll.Huyện, ll.Xã, ll.SDT, ll.Email_Trường, ll.Email_Cá_Nhân
                                FROM Thông_Tin_Giảng_Viên gv
                                JOIN Thông_Tin_Liên_Lạc ll ON gv.Mã_Giảng_Viên = ll.Mã
                                WHERE gv.Mã_Giảng_Viên = @msgv";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@msgv", position);

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
