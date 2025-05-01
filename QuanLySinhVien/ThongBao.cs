using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    public partial class ThongBao : Form
    {
        public ThongBao()
        {
            InitializeComponent();
            LoadDataToGridView();
        }

        private void LoadDataToGridView()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
            string query = @"SELECT 
                tb.Ma,
                lh.TenLop AS Lop,
                tb.TieuDe,
                tb.NoiDung,
                tb.MucDo
            FROM Thong_Bao tb
            JOIN LopHoc lh ON tb.Ma = lh.MaLop";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    data_thongbao.DataSource = dataTable;
                    data_thongbao.Columns["Ma"].Visible = false; // Ẩn cột khóa chính
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void InsertData()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";

            string query = @"INSERT INTO Thong_Bao (TieuDe, NoiDung, MucDo, Ma) 
                 VALUES (@TieuDe, @NoiDung, @MucDo, @Ma)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    // Lấy giá trị mức độ từ radio button
                    string mucDo = "";
                    if (rbtn_Chung.Checked)
                        mucDo = "Chung";
                    else if (rbtn_ChuyenNganh.Checked)
                        mucDo = "Chuyên ngành";
                    else if (rbtn_Gap.Checked)
                        mucDo = "Khẩn cấp";

                    // Gán dữ liệu
                    command.Parameters.AddWithValue("@TieuDe", txt_TieuDeThongBao.Text.Trim());
                    command.Parameters.AddWithValue("@NoiDung", txt_noidungthongbao.Text.Trim());
                    command.Parameters.AddWithValue("@MucDo", mucDo);
                    command.Parameters.AddWithValue("@Ma", ccb_lop.SelectedValue.ToString()); // cbLop là ComboBox chứa mã lớp

                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm dữ liệu thành công!");
                    LoadDataToGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }


        }


        private void DeleteData()
        {
            if (data_thongbao.SelectedRows.Count > 0)
            {
                string ma = data_thongbao.SelectedRows[0].Cells["Ma"].Value.ToString();

                string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
                string query = "DELETE FROM Thong_Bao WHERE Ma = @Ma";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Ma", ma);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Xóa dữ liệu thành công!");
                        LoadDataToGridView(); // làm mới danh sách
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }


        private void btn_GuiThongBao_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void btn_XoaThongBao_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void ThongBao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySinhVienDataSet.LopHoc' table. You can move, or remove it, as needed.
            this.lopHocTableAdapter.Fill(this.quanLySinhVienDataSet.LopHoc);

        }
    }
}
