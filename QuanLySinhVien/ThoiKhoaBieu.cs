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
    public partial class ThoiKhoaBieu : Form
    {
        string position;
        //string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
        private string connectionString = @"Server=localhost\SQLEXPRESS;Database=QuanLySinhVien;Trusted_Connection=True;";
        public ThoiKhoaBieu(string position)
        {
            InitializeComponent();
            this.position = position;
            LoadDataToGridView();
            StyleDataGridView();
        }
        private void StyleDataGridView()
        {
            // 1. Bật tự co dãn cột cho vừa khung
            //data_thoikhoabieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 2. Ẩn dòng chỉ số hàng (row header) nếu không cần
            data_thoikhoabieu.RowHeadersVisible = false;

            // 3. Thiết lập font chung, kích thước và padding
            var baseFont = new Font("Segoe UI", 9F);
            data_thoikhoabieu.DefaultCellStyle.Font = baseFont;
            data_thoikhoabieu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            data_thoikhoabieu.DefaultCellStyle.Padding = new Padding(4, 2, 4, 2);

            // 4. Căn giữa nội dung số
            //data_thoikhoabieu.Columns["ĐiểmGK"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //data_thoikhoabieu.Columns["ĐiểmCK"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //data_thoikhoabieu.Columns["DiemTB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //data_thoikhoabieu.Columns["Số tín chỉ"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 5. Màu xen kẽ cho hàng (zebra striping)
            data_thoikhoabieu.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);

            // 6. Màu background chung và màu lưới
            data_thoikhoabieu.BackgroundColor = Color.White;
            data_thoikhoabieu.GridColor = Color.LightGray;

            // 7. Tô màu header và căn giữa
            data_thoikhoabieu.EnableHeadersVisualStyles = false;
            data_thoikhoabieu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
            data_thoikhoabieu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            data_thoikhoabieu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 8. Màu khi chọn
            data_thoikhoabieu.DefaultCellStyle.SelectionBackColor = Color.FromArgb(135, 206, 250);
            data_thoikhoabieu.DefaultCellStyle.SelectionForeColor = Color.Black;

            // 9. Tăng chiều cao hàng để dễ đọc
            data_thoikhoabieu.RowTemplate.Height = 40;

            // 10. Chặn người dùng chỉnh sửa trực tiếp ở lưới
            data_thoikhoabieu.ReadOnly = true;
            data_thoikhoabieu.AllowUserToAddRows = false;
            data_thoikhoabieu.AllowUserToDeleteRows = false;
        }
        private DataRow GetSelectedRow()
        {
            if (data_thoikhoabieu.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = data_thoikhoabieu.SelectedRows[0];
                return ((DataRowView)selectedRow.DataBoundItem).Row;
            }
            return null;
        }

        private void LoadDataToGridView()
        {
            
            //    string query = @"
            //SELECT 
            //    mh.Tên_Môn,
            //    mh.Mã_Môn,
            //    tkb.Phòng,
            //    tkb.Thứ,
            //    tkb.Buổi,
            //    LTRIM(RTRIM(tkb.Hình_Thức)) AS Hình_Thức,
            //    tkb.Chú_ý,
            //    tkb.Lớp
            //FROM Thời_Khóa_Biểu tkb 
            //JOIN Thông_Tin_Môn_Học mh ON tkb.Môn_Học = mh.Mã_Môn
            //WHERE mh.Mã_Giáo_Viên = @MaGV";

            string query = @"
            SELECT 
                tkb.id,
                tkb.Thứ,
                tkb.Buổi,
                mh.Tên_Môn,
                mh.Mã_Môn,
                tkb.Phòng,
                tkb.Hình_Thức,
                tkb.Chú_ý,
                tkb.Lớp
            FROM Thời_Khóa_Biểu tkb 
            JOIN Thông_Tin_Môn_Học mh ON tkb.Môn_Học = mh.Mã_Môn
            WHERE mh.Mã_Giáo_Viên = @MaGV
            ORDER BY 
                CASE 
                    WHEN tkb.Thứ = N'Thứ 2' THEN 2
                    WHEN tkb.Thứ = N'Thứ 3' THEN 3
                    WHEN tkb.Thứ = N'Thứ 4' THEN 4
                    WHEN tkb.Thứ = N'Thứ 5' THEN 5
                    WHEN tkb.Thứ = N'Thứ 6' THEN 6
                    WHEN tkb.Thứ = N'Thứ 7' THEN 7
                    ELSE 8
                END,
                tkb.Buổi";

            data_thoikhoabieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_thoikhoabieu.MultiSelect = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaGV", position);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    data_thoikhoabieu.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }



        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
       
            DataRow selectedRow = GetSelectedRow();
            if (selectedRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!");
                return;
            }
            string message;
            if (KiemTraTrungLich(out message, Convert.ToInt32(selectedRow["ID"])))
            {
                MessageBox.Show(message);
                return;
            }
            try
            {
               
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"UPDATE [Thời_Khóa_Biểu] SET 
                                Môn_Học = @MonHoc,
                                Phòng = @Phong,
                                Thứ = @Thu,
                                Buổi = @Buoi,
                                Hình_Thức = @HinhThuc,
                                Chú_ý = @ChuY,
                                Lớp = @Lop
                            WHERE ID = @ID";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MonHoc", txt_mamonhoc.Text);
                    cmd.Parameters.AddWithValue("@Phong", txt_phong.Text);
                    cmd.Parameters.AddWithValue("@Thu", cbb_Thu.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Buoi", cbbb_Buoi.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@HinhThuc", cbb_hinhthuc.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ChuY", txt_mota.Text);
                    cmd.Parameters.AddWithValue("@Lop", txt_lop.Text);
                    cmd.Parameters.AddWithValue("@ID", selectedRow["ID"]);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        LoadDataToGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataRow selectedRow = GetSelectedRow();
            if (selectedRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"DELETE FROM [Thời_Khóa_Biểu] WHERE ID = @ID";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@ID", selectedRow["ID"]);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                            LoadDataToGridView();
                            ResetForm();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string message;
                    if (KiemTraTrungLich(out message))
                    {
                        MessageBox.Show(message);
                        return;
                    }

                    string query = @"INSERT INTO [Thời_Khóa_Biểu] 
                            (Môn_Học, Phòng, Thứ, Buổi, Hình_Thức, Chú_ý, Lớp)
                            VALUES 
                            (@MonHoc, @Phong, @Thu, @Buoi, @HinhThuc, @ChuY, @Lop)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MonHoc", txt_mamonhoc.Text);
                    cmd.Parameters.AddWithValue("@Phong", txt_phong.Text);
                    cmd.Parameters.AddWithValue("@Thu", cbb_Thu.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Buoi", cbbb_Buoi.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@HinhThuc", cbb_hinhthuc.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ChuY", txt_mota.Text);
                    cmd.Parameters.AddWithValue("@Lop", txt_lop.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công!");
                        LoadDataToGridView();
                        ResetForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void ResetForm()
        {
            //Làm trống tất cả các control nhập liệu
            txt_mamonhoc.Text = "";
            cbb_Thu.SelectedIndex = -1;
            cbbb_Buoi.SelectedIndex = -1;
            txt_mota.Text = "";
            txt_phong.Text = "";
            txt_tenmonhoc.Text = "";
            cbb_hinhthuc.SelectedIndex = -1;

        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ThoiKhoaBieu_Load(object sender, EventArgs e)
        {

        }

        private void data_thoikhoabieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = data_thoikhoabieu.Rows[e.RowIndex];

                 txt_tenmonhoc.Text = row.Cells["Tên_Môn"].Value?.ToString();
                txt_mamonhoc.Text = row.Cells["Mã_Môn"].Value?.ToString();
                txt_phong.Text = row.Cells["Phòng"].Value?.ToString();
                cbb_Thu.SelectedItem = row.Cells["Thứ"].Value?.ToString();
                cbbb_Buoi.SelectedItem = row.Cells["Buổi"].Value?.ToString();
                cbb_hinhthuc.SelectedItem = row.Cells["Hình_Thức"].Value?.ToString();
                txt_mota.Text = row.Cells["Chú_ý"].Value?.ToString();
                txt_lop.Text = row.Cells["Lớp"].Value?.ToString();
            }
        }

        private void pb_timMonHoc_Click(object sender, EventArgs e)
        {
            string maMon = txt_mamonhoc.Text.Trim(); // lấy mã môn
            if (string.IsNullOrEmpty(maMon))
            {
                MessageBox.Show("Vui lòng nhập mã môn học.");
                return;
            }

           
            string query = @"
        SELECT * FROM Thông_Tin_Môn_Học 
        WHERE RTRIM(Mã_Môn) = @MaMon";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaMon", maMon);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Không tồn tại mã môn này.");
                        return;
                    }

                    reader.Read();
                    string tenMon = reader["Tên_Môn"].ToString().Trim();
                    string maGVTrongBang = reader["Mã_Giáo_Viên"].ToString().Trim();

                    if (maGVTrongBang != position.Trim())
                    {
                        MessageBox.Show($"Môn \"{tenMon}\" không thuộc quyền giảng dạyC.");
                        return;
                    }

                    txt_tenmonhoc.Text = reader["Tên_Môn"].ToString().Trim();
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void txtbox_TimKiemMonHoc_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = false;
                TimKiemMonHoc(); 
            }
        }

        private void TimKiemMonHoc()
        {
            string maMonCanTim = txtbox_TimKiemMonHoc.Text.Trim();
           
            string query = @"
        SELECT 
            mh.Tên_Môn,
            mh.Mã_Môn,
            tkb.Phòng,
            tkb.Thứ,
            tkb.Buổi,
            tkb.Hình_Thức,
            tkb.Chú_ý,
            tkb.Lớp
        FROM Thời_Khóa_Biểu tkb 
        JOIN Thông_Tin_Môn_Học mh ON tkb.Môn_Học = mh.Mã_Môn
        WHERE mh.Mã_Giáo_Viên = @MaGV AND mh.Mã_Môn = @MaMon
    ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaGV", position);
                    command.Parameters.AddWithValue("@MaMon", maMonCanTim);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    data_thoikhoabieu.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private bool KiemTraTrungLich(out string message, int? excludeId = null)
        {
            message = "";

            string phong = txt_phong.Text.Trim();
            string thu = cbb_Thu.Text.Trim();
            string buoi = cbbb_Buoi.Text.Trim();
            string mamon = txt_mamonhoc.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra trùng phòng
                string query1 = @"
            SELECT * FROM Thời_Khóa_Biểu 
            WHERE Phòng = @Phong AND Thứ = @Thu AND Buổi = @Buoi";

                if (excludeId.HasValue)
                {
                    query1 += " AND ID != @ExcludeID";
                }

                using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                {
                    cmd1.Parameters.AddWithValue("@Phong", phong);
                    cmd1.Parameters.AddWithValue("@Thu", thu);
                    cmd1.Parameters.AddWithValue("@Buoi", buoi);
                    if (excludeId.HasValue)
                        cmd1.Parameters.AddWithValue("@ExcludeID", excludeId.Value);

                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            message = $"Phòng {phong}, thứ {thu}, buổi {buoi} đã được đăng ký trước.";
                            return true;
                        }
                    }
                }

                // Kiểm tra giáo viên có lịch dạy cùng lúc
                string query2 = @"
            SELECT mh.Tên_Môn, tkb.Phòng FROM Thời_Khóa_Biểu tkb
            JOIN Thông_Tin_Môn_Học mh ON tkb.Môn_Học = mh.Mã_Môn
            WHERE tkb.Thứ = @Thu AND tkb.Buổi = @Buoi AND mh.Mã_Giáo_Viên = @MaGV";

                if (excludeId.HasValue)
                {
                    query2 += " AND tkb.ID != @ExcludeID";
                }

                using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                {
                    cmd2.Parameters.AddWithValue("@Thu", thu);
                    cmd2.Parameters.AddWithValue("@Buoi", buoi);
                    cmd2.Parameters.AddWithValue("@MaGV", position);
                    if (excludeId.HasValue)
                        cmd2.Parameters.AddWithValue("@ExcludeID", excludeId.Value);

                    using (SqlDataReader reader2 = cmd2.ExecuteReader())
                    {
                        if (reader2.Read())
                        {
                            string tenMon = reader2["Tên_Môn"].ToString().Trim();
                            string phongDangDay = reader2["Phòng"].ToString().Trim();
                            message = $"Thứ {thu}, buổi {buoi}, bạn đã có lịch dạy môn \"{tenMon}\" tại phòng {phongDangDay}.";
                            return true;
                        }
                    }
                }
            }

            return false; // Không trùng
        }


        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb_reload_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
    }
}
