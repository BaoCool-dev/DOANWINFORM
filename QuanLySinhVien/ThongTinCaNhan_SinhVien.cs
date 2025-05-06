using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
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
                        sv.Tôn_Giáo, sv.Quốc_Tịch, sv.Lớp, sv.Hình_Ảnh,
                        ll.Tỉnh, ll.Huyện, ll.Xã, ll.SDT, ll.Email_Trường, ll.Email_Cá_Nhân,
                        tn.Tên_Thân_Nhân , tn.Quan_Hệ_Thân_Nhân, tn.SDT,
                        cm.Năm_Bắt_Đầu, cm.Khoa, cm.Học_Vị, cm.Chức_Vụ
                    FROM Thông_Tin_Sinh_Viên sv
                    JOIN Thông_Tin_Liên_Lạc ll ON sv.Mã_Sinh_Viên = ll.Mã
                    JOIN Thân_Nhân tn ON sv.Mã_Sinh_Viên = tn.Mã
                    JOIN Chuyên_Môn cm ON sv.Mã_Sinh_Viên = cm.Mã
                    WHERE sv.Mã_Sinh_Viên = @msgv"
                ;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@msgv", mssv);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lb_HovaTen.Text = reader["Họ_và_Tên"].ToString();
                        lb_NgaySinh.Text = Convert.ToDateTime(reader["Ngày_Sinh"]).ToString("dd/MM/yyyy");
                        lb_QueQuan.Text = reader["Quê_Quán"].ToString();
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
                        lbl_Ho_TenThanNhan.Text = reader["Tên_Thân_Nhân"].ToString();
                        lbl_SDT_ThanNhan.Text = reader["SDT"].ToString();
                        lbl_QuanHeThanNhan.Text = reader["Quan_Hệ_Thân_Nhân"].ToString();
                        lbl_MaSinhVien.Text = mssv.ToString();
                        lbl_NamBatDau.Text = reader["Năm_Bắt_Đầu"].ToString();
                        lbl_khoa.Text = reader["Khoa"].ToString();
                        lbl_ChucVu.Text = reader["Chức_Vụ"].ToString();

                        // 👉 Load hình ảnh vào PictureBox nếu có
                        if (reader["Hình_Ảnh"] != DBNull.Value)
                        {
                            byte[] imgBytes = (byte[])reader["Hình_Ảnh"];
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                pb_AnhSinhVien.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pb_AnhSinhVien.Image = null; // hoặc ảnh mặc định nếu cần
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên với Mã này!");
                    }
                }
            }
        }

        private void btn_ChinSuaAnhSinhVien_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị ảnh lên PictureBox
                Image img = Image.FromFile(open.FileName);
                pb_AnhSinhVien.Image = img;

                // Chuyển ảnh sang byte[]
                byte[] b;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    b = ms.ToArray();
                }

                // Cập nhật ảnh vào cơ sở dữ liệu
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("UPDATE Thông_Tin_Sinh_Viên SET Hình_Ảnh = @hinh WHERE Mã_Sinh_Viên = @ma", conn))
                        {
                            cmd.Parameters.AddWithValue("@hinh", b);
                            cmd.Parameters.AddWithValue("@ma", mssv); // Biến này cần được xác định trước
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Cập nhật ảnh thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật ảnh: " + ex.Message);
                }
            }
        }
    }
}
