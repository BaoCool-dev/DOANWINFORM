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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLySinhVien
{
    public partial class Khac : Form
    {
        string masinhvien;
        public Khac(string masinhvien)
        {
            this.masinhvien = masinhvien;
            InitializeComponent();
            loadMessager();
            loadHocPhi();

        }

        private void container(object object_form)
        {
            if (panel_mess.Controls.Count > 0)
                panel_mess.Controls.Clear();

            Form fm = object_form as Form;
            if (fm != null)
            {
                fm.TopLevel = false;
                fm.FormBorderStyle = FormBorderStyle.None;
                fm.Dock = DockStyle.Fill;

                panel_mess.Controls.Add(fm);
                panel_mess.Tag = fm;
                fm.Show();
            }
        }

        public void loadMessager()
        {
            container(new Messenger("SV001", "GV001"));
        }

        public void loadHocPhi()
        {
            btn_ThanhToan.Visible = false;
            btn_TaoMaQR.Enabled = false;
            lbl_TinhTrangHocPhi.Text = "Không có dữ liệu";
        }

        private void btn_TaoMaQR_Click(object sender, EventArgs e)
        {
            string selected = cbb_NganHang.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selected))
            {
                // Xử lý trường hợp chưa chọn ngân hàng
                MessageBox.Show("Vui lòng chọn ngân hàng.");
            }
            else if (selected == "VietComBank")
            {
                pictureBox1.Image = Properties.Resources.vietcombank;
            }
            else if (selected == "MOMO")
            {
                pictureBox1.Image = Properties.Resources.momo;
            }
            btn_ThanhToan.Visible = true;
        }

        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaSinhVien.Text))
            {
                txt_MaSinhVien.Text = masinhvien;
            }
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
            string maSinhVien = txt_MaSinhVien.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                                SELECT Họ_và_Tên
                                FROM Thông_Tin_Sinh_Viên
                                WHERE Mã_Sinh_Viên = @MaSV";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", maSinhVien);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_Hoten.Text = reader["Họ_và_Tên"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_Hoten.Clear();
                        }
                    }
                }
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                                SELECT Tình_Trạng, Học_Phí
                                FROM Học_Phí
                                WHERE Mã_Sinh_Viên = @MaSV";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", maSinhVien);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tinhTrang = reader["Tình_Trạng"].ToString();
                            decimal hocPhi = Convert.ToDecimal(reader["Học_Phí"]);

                            lbl_TinhTrangHocPhi.Text = $": {tinhTrang} {hocPhi:C0}"; // C0: định dạng tiền tệ, không thập phân
                            if(tinhTrang=="Đã đóng")
                            {
                                btn_TaoMaQR.Enabled = false;
                            }
                            else
                            {
                                btn_TaoMaQR.Enabled = true;
                            }
                        }
                        else
                        {
                            lbl_TinhTrangHocPhi.Text = "Không tìm thấy thông tin học phí!";
                        }
                    }
                }
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
            string maSinhVien = txt_MaSinhVien.Text.Trim();

            if (!string.IsNullOrEmpty(maSinhVien))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Câu truy vấn SQL để cập nhật tình trạng học phí
                        string query = "";
                        //string query = @"
                        //    UPDATE Học_Phí 
                        //    SET Tình_Trạng = 'Đã Đóng' 
                        //    WHERE Mã_Sinh_Viên = @MaSV ";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Thêm tham số để bảo vệ khỏi SQL Injection
                            cmd.Parameters.AddWithValue("@MaSV", maSinhVien);
                            DialogResult result = MessageBox.Show("Thanh toán học phí thành công. Bạn có muốn xuất hóa đơn?",
                                              "Thông báo",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                // Gọi hàm bạn muốn chạy khi nhấn Yes
                                XuatHoaDon();
                            }
                            else
                            {
                                // Xử lý khi nhấn No (nếu cần)
                                MessageBox.Show("Bạn đã chọn không thực hiện thao tác tiếp theo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void XuatHoaDon()
        {
            MessageBox.Show("Xuát hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
