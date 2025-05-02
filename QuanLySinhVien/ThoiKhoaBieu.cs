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
        private void LoadDataToGridView()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
            string query = @"
        SELECT 
            mh.TenMonHoc,
            tkb.Thu,
            tbd.ThoiGian AS GioBatDau,
            tkt.ThoiGian AS GioKetThuc,
            tkb.MaMonHoc,
            mh.SoTinChi,
            tkb.MaGiangVien,
            tkb.MaPhong,
            tkb.MaLop,
            tkb.HinhThuc,
            tkb.HocKy,
            tkb.MoTa
        FROM 
            ThoiKhoaBieu tkb
        JOIN 
            MonHoc mh ON tkb.MaMonHoc = mh.MaMonHoc
        JOIN 
            TietHoc tbd ON tkb.TietDau = tbd.Tiet
        JOIN 
            TietHoc tkt ON tkb.TietCuoi = tkt.Tiet";

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

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
            string query = "INSERT INTO ThoiKhoaBieu ( Thu, MaMonHoc, MaGiangVien, MaPhong, MaLop, HinhThuc, MoTa, HocKy,TietDau, TietCuoi) " +
                           "VALUES (@MaLich, @MaTiet, @Thu, @MaMonHoc, @MaGiangVien, @MaPhong, @MaLop, @HinhThuc, @MoTa, @HocKy)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Thêm các tham số với giá trị từ các control trên form
                    //cmd.Parameters.AddWithValue("@MaLich", string.IsNullOrEmpty(txt_MaLich.Text) ? (object)DBNull.Value : txt_MaLich.Text);
                    //cmd.Parameters.AddWithValue("@MaTiet", string.IsNullOrEmpty(txt_MaTiet.Text) ? (object)DBNull.Value : txt_MaTiet.Text);
                    //cmd.Parameters.AddWithValue("@Thu", string.IsNullOrEmpty(txt_Thu.Text) ? (object)DBNull.Value : txt_Thu.Text);
                    //cmd.Parameters.AddWithValue("@MaMonHoc", string.IsNullOrEmpty(txt_MaMonHoc.Text) ? (object)DBNull.Value : txt_MaMonHoc.Text);
                    //cmd.Parameters.AddWithValue("@MaGiangVien", string.IsNullOrEmpty(txt_MaGiangVien.Text) ? (object)DBNull.Value : txt_MaGiangVien.Text);
                    //cmd.Parameters.AddWithValue("@MaPhong", string.IsNullOrEmpty(txt_MaPhong.Text) ? (object)DBNull.Value : txt_MaPhong.Text);
                    //cmd.Parameters.AddWithValue("@MaLop", string.IsNullOrEmpty(txt_MaLop.Text) ? (object)DBNull.Value : txt_MaLop.Text);

                    //// Lấy giá trị từ ComboBox HinhThuc
                    //cmd.Parameters.AddWithValue("@HinhThuc", cbo_HinhThuc.SelectedItem?.ToString() ?? (object)DBNull.Value);

                    //cmd.Parameters.AddWithValue("@MoTa", string.IsNullOrEmpty(txt_MoTa.Text) ? (object)DBNull.Value : txt_MoTa.Text);
                    //cmd.Parameters.AddWithValue("@HocKy", string.IsNullOrEmpty(txt_HocKy.Text) ? (object)DBNull.Value : txt_HocKy.Text);

                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Thêm thành công!");
                    LoadDataToGridView(); // Gọi hàm load lại dữ liệu vào DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void ThoiKhoaBieu_Load(object sender, EventArgs e)
        {

        }
    }
}
