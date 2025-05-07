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
    public partial class DanhSachLop : Form
    {
        string MaMonHoc;
        string position;
        string MaGiangVien;
        public DanhSachLop(string maMonHoc, string position, string maGiangVien)
        {

            this.MaMonHoc = maMonHoc;
            this.position = position;
            InitializeComponent();
            LoadDataToGridView();
            MaGiangVien = maGiangVien;
        }

        private void container(object object_form)
        {
            if (panel_DanhSachLop.Controls.Count > 0)
                panel_DanhSachLop.Controls.Clear();

            Form fm = object_form as Form;
            if (fm != null)
            {
                fm.TopLevel = false;
                fm.FormBorderStyle = FormBorderStyle.None;
                fm.Dock = DockStyle.Fill;

                panel_DanhSachLop.Controls.Add(fm);
                panel_DanhSachLop.Tag = fm;
                fm.Show();
            }
        }
        private void btn_TroVeLopCuaBan_Click(object sender, EventArgs e)
        {
            container(new LopCuaBan(position));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DanhSachLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySinhVienDataSet1.BangDiem_CNTT01' table. You can move, or remove it, as needed.
            //this.bangDiem_CNTT01TableAdapter.Fill(this.quanLySinhVienDataSet1.BangDiem_CNTT01);

        }
        private void LoadDataToGridView()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                                SELECT 
                                    d.MonHoc,
                                    d.Mã,
                                    sv.Họ_và_Tên,
                                    sv.Ngày_Sinh,
                                    sv.Giới_Tính,
                                    sv.Lớp,
                                    d.ĐiểmGK,
                                    d.ĐiểmCK
                                    
                                FROM 
                                    Bảng_Điểm_Chung d
                                INNER JOIN 
                                    Thông_Tin_Sinh_Viên sv ON d.Mã = sv.Mã_Sinh_Viên
                                WHERE 
                                    d.MonHoc = @MaLop";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLop", MaMonHoc);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    data_bangdiem.DataSource = dt;
                }
            }
        }


        private void btn_them_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";

            string maSinhVien = txt_MaSinhVien.Text.Trim();

            // Kiểm tra mã sinh viên có bị trống không
            if (string.IsNullOrEmpty(maSinhVien))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(maSinhVien) ||
                string.IsNullOrEmpty(txt_Hoten.Text.Trim()) ||
                string.IsNullOrEmpty(txt_Lop.Text.Trim()))
            {
                MessageBox.Show("Thông tin không được để trống hoặc không trùng khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Xác định tên bảng điểm theo mã môn học
            string tenBang = "";
            switch (MaMonHoc)
            {
                case "MH001": tenBang = "Bảng_Điểm_TRR"; break;
                case "MH002": tenBang = "Bảng_Điểm_LTW"; break;
                case "MH003": tenBang = "Bảng_Điểm_KTMT"; break;
                case "MH004": tenBang = "Bảng_Điểm_KTLT"; break;
                case "MH005": tenBang = "Bảng_Điểm_TTNT"; break;
                default:
                    MessageBox.Show("Mã môn học không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra xem sinh viên đã có trong bảng điểm chưa
                string checkQuery = $@"SELECT COUNT(*) FROM {tenBang} WHERE Mã = @MaSV";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@MaSV", maSinhVien);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Sinh viên này đã tồn tại trong bảng điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                // Thêm sinh viên vào bảng điểm với NULL cho điểm GK và CK
                string insertQuery = $@"
                                    INSERT INTO {tenBang} (Mã, ĐiểmGK, ĐiểmCK)
                                    VALUES (@MaSV, NULL, NULL)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", maSinhVien);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Thêm sinh viên vào bảng điểm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataToGridView(); // Refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Thêm sinh viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";

            string maSinhVien = txt_MaSinhVien.Text.Trim();

            // Xác định tên bảng gốc dựa vào mã môn học
            string tenBang = "";
            switch (MaMonHoc)
            {
                case "MH001":
                    tenBang = "Bảng_Điểm_TRR";
                    break;
                case "MH002":
                    tenBang = "Bảng_Điểm_LTW";
                    break;
                case "MH003":
                    tenBang = "Bảng_Điểm_KTMT";
                    break;
                case "MH004":
                    tenBang = "Bảng_Điểm_KTLT";
                    break;
                case "MH005":
                    tenBang = "Bảng_Điểm_TTNT";
                    break;
                default:
                    MessageBox.Show("Mã môn học không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này khỏi bảng điểm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = $@"
                            DELETE FROM {tenBang}
                            WHERE Mã = @MaSV";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSinhVien);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataToGridView(); // Cập nhật lại giao diện
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";

            string maSinhVien = txt_MaSinhVien.Text.Trim();
            string strDiemGK = txtDiemGK.Text.Trim();
            string strDiemCK = txtDiemCK.Text.Trim();

            // Kiểm tra rỗng
            if (!float.TryParse(txtDiemGK.Text.Trim(), out float diemGK) || diemGK < 0 || diemGK > 10 ||
                !float.TryParse(txtDiemCK.Text.Trim(), out float diemCK) || diemCK < 0 || diemCK > 10)
            {
                MessageBox.Show("Vui lòng nhập đúng điểm (từ 0 đến 10) cho cả Giữa kỳ và Cuối kỳ!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Xác định tên bảng điểm theo mã môn học
            string tenBang = "";
            switch (MaMonHoc)
            {
                case "MH001": tenBang = "Bảng_Điểm_TRR"; break;
                case "MH002": tenBang = "Bảng_Điểm_LTW"; break;
                case "MH003": tenBang = "Bảng_Điểm_KTMT"; break;
                case "MH004": tenBang = "Bảng_Điểm_KTLT"; break;
                case "MH005": tenBang = "Bảng_Điểm_TTNT"; break;
                default:
                    MessageBox.Show("Mã môn học không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = $@"
                        UPDATE {tenBang}
                        SET ĐiểmGK = @DiemGK, ĐiểmCK = @DiemCK
                        WHERE Mã = @MaSV";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DiemGK", diemGK);
                    cmd.Parameters.AddWithValue("@DiemCK", diemCK);
                    cmd.Parameters.AddWithValue("@MaSV", maSinhVien);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataToGridView();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Hoten.Clear();
            txt_MaSinhVien.Clear();
            txt_Lop.Clear();
            txtDiemGK.Clear();
            txtDiemCK.Clear();
        }

        private void data_bangdiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = data_bangdiem.Rows[e.RowIndex];

                txt_Hoten.Text = row.Cells["Họ_và_Tên"].Value?.ToString();
                txt_MaSinhVien.Text = row.Cells["Mã"].Value?.ToString();
                txt_Lop.Text = row.Cells["Lớp"].Value?.ToString();
                txtDiemGK.Text = row.Cells["ĐiểmGK"].Value?.ToString();
                txtDiemCK.Text = row.Cells["ĐiểmCK"].Value?.ToString();
            }
        }

        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                                SELECT 
                                    sv.Họ_và_Tên,
                                    sv.Lớp
                                FROM 
                                    Thông_Tin_Sinh_Viên sv
                                WHERE 
                                    sv.Mã_Sinh_Viên = @MSSV";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MSSV", txt_MaSinhVien.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_Hoten.Text = reader["Họ_và_Tên"].ToString();
                            txt_Lop.Text = reader["Lớp"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên với mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_Hoten.Clear();
                            txt_Lop.Clear();
                        }
                    }
                }
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
            string maSinhVien = txtBox_TImKiemDanhSachLop.Text.Trim(); // textbox để nhập mã cần tìm

            if (string.IsNullOrEmpty(maSinhVien))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $@"
            SELECT 
                d.MonHoc,
                d.Mã,
                sv.Họ_và_Tên,
                sv.Ngày_Sinh,
                sv.Giới_Tính,
                sv.Lớp,
                d.ĐiểmGK,
                d.ĐiểmCK
            FROM 
                Bảng_Điểm_Chung d
            INNER JOIN 
                Thông_Tin_Sinh_Viên sv ON d.Mã = sv.Mã_Sinh_Viên
            WHERE 
                d.Mã = @MaSV and d.MonHoc = @MaMon";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", maSinhVien);
                    cmd.Parameters.AddWithValue("@MaMon", MaMonHoc);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        data_bangdiem.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên với mã đã nhập!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        data_bangdiem.DataSource = null;
                    }
                }
            }
        }

        private void btn_refesh_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Messenger message = new Messenger(MaGiangVien, txt_MaSinhVien.Text);
            message.ShowDialog();
        }
    }
}
