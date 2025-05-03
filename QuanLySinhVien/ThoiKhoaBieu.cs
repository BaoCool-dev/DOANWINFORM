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
        public ThoiKhoaBieu()
        {
            InitializeComponent();
            LoadDataToGridView();
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
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
            string query = @"SELECT mh.TenMonHoc, tkb.Thu, tbd.ThoiGian AS GioBatDau, tkt.ThoiGian AS GioKetThuc,  tkb.MaMonHoc, mh.SoTinChi,   tkb.MaGiangVien,     tkb.MaPhong,
            tkb.MaLop,
            tkb.HinhThuc,
            tkb.HocKy,
            tkb.MoTa
            FROM ThoiKhoaBieu tkb JOIN  MonHoc mh ON tkb.MaMonHoc = mh.MaMonHoc JOIN TietHoc tbd ON tkb.TietDau = tbd.Tiet JOIN  TietHoc tkt ON tkb.TietCuoi = tkt.Tiet";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
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

            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"UPDATE ThoiKhoaBieu 
                            SET MaMonHoc = @MaMonHoc, 
                                Thu = @Thu, 
                                TietDau = @TietDau, 
                                TietCuoi = @TietCuoi, 
                                MaGiangVien = @MaGiangVien, 
                                MaPhong = @MaPhong, 
                                MaLop = @MaLop, 
                                HinhThuc = @HinhThuc, 
                                HocKy = @HocKy, 
                                MoTa = @MoTa
                            WHERE MaMonHoc = @OldMaMonHoc AND Thu = @OldThu AND TietDau = @OldTietDau";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Giá trị mới từ form
                    cmd.Parameters.AddWithValue("@MaMonHoc", txtMaMonHoc.Text);
                    cmd.Parameters.AddWithValue("@Thu", cbThu.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TietDau", Convert.ToInt32(txtTietDau.Text));
                    cmd.Parameters.AddWithValue("@TietCuoi", Convert.ToInt32(txtTietCuoi.Text));
                    cmd.Parameters.AddWithValue("@MaGiangVien", txtMaGiangVien.Text);
                    cmd.Parameters.AddWithValue("@MaPhong", txtPhong.Text);
                    cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text);
                    cmd.Parameters.AddWithValue("@HinhThuc", cbHinhThuc.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@HocKy", txtHocKy.Text);
                    cmd.Parameters.AddWithValue("@MoTa", txtMoTa.Text);

                    // Giá trị cũ để xác định bản ghi cần sửa
                    cmd.Parameters.AddWithValue("@OldMaMonHoc", selectedRow["MaMonHoc"]);
                    cmd.Parameters.AddWithValue("@OldThu", selectedRow["Thu"]);
                    cmd.Parameters.AddWithValue("@OldTietDau", selectedRow["TietDau"]);

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
                    string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"DELETE FROM ThoiKhoaBieu 
                                WHERE MaMonHoc = @MaMonHoc AND Thu = @Thu AND TietDau = @TietDau";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        cmd.Parameters.AddWithValue("@MaMonHoc", selectedRow["MaMonHoc"]);
                        cmd.Parameters.AddWithValue("@Thu", selectedRow["Thu"]);
                        cmd.Parameters.AddWithValue("@TietDau", selectedRow["TietDau"]);

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
                string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO ThoiKhoaBieu 
                            (MaMonHoc, Thu, TietDau, TietCuoi, MaGiangVien, MaPhong, MaLop, HinhThuc, HocKy, MoTa)
                            VALUES 
                            (@MaMonHoc, @Thu, @TietDau, @TietCuoi, @MaGiangVien, @MaPhong, @MaLop, @HinhThuc, @HocKy, @MoTa)";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Lấy giá trị từ các control trên form
                    cmd.Parameters.AddWithValue("@MaMonHoc", txtMaMonHoc.Text);
                    cmd.Parameters.AddWithValue("@Thu", cbThu.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TietDau", Convert.ToInt32(txtTietDau.Text));
                    cmd.Parameters.AddWithValue("@TietCuoi", Convert.ToInt32(txtTietCuoi.Text));
                    cmd.Parameters.AddWithValue("@MaGiangVien", txtMaGiangVien.Text);
                    cmd.Parameters.AddWithValue("@MaPhong", txtPhong.Text);
                    cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text);
                    cmd.Parameters.AddWithValue("@HinhThuc", cbHinhThuc.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@HocKy", txtHocKy.Text);
                    cmd.Parameters.AddWithValue("@MoTa", txtMoTa.Text);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công!");
                        LoadDataToGridView(); // Tải lại dữ liệu
                        ResetForm(); // Làm mới form
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
            // Làm trống tất cả các control nhập liệu
            txtMaMonHoc.Text = "";
            cbThu.SelectedIndex = -1;
            txtTietDau.Text = "";
            txtTietCuoi.Text = "";
            txtMaGiangVien.Text = "";
            txtPhong.Text = "";
            txtMaLop.Text = "";
            cbHinhThuc.SelectedIndex = -1;
            txtHocKy.Text = "";
            txtMoTa.Text = "";
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ThoiKhoaBieu_Load(object sender, EventArgs e)
        {

        }
    }
}
