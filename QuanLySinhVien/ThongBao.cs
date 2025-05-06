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
        string position;
        public ThongBao(string position)
        {
            InitializeComponent();
            LoadDataToGridView();
            this.position = position;
        }

            private void LoadDataToGridView()
            {
                string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
                string query = @"SELECT 
                    tb.STT,
                    lh.Tên_Lớp AS Lớp,
                    tb.Tiêu_Đề,
                    tb.Nội_Dung,
                    tb.Mức_Độ
                FROM Thông_Báo tb
                JOIN Thông_Tin_Lớp_Học lh ON tb.Lớp = lh.ID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        data_thongbao.DataSource = dataTable;
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

            string query = @"INSERT INTO Thông_Báo (Tiêu_Đề, Nội_Dung, Mức_Độ, Lớp) 
                 VALUES (@Tiêu_Đề, @Nội_Dung, @Mức_Độ, @Lớp)";

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
                    command.Parameters.AddWithValue("@Tiêu_Đề", txt_TieuDeThongBao.Text.Trim());
                    command.Parameters.AddWithValue("@Nội_Dung", txt_noidungthongbao.Text.Trim());
                    command.Parameters.AddWithValue("@Mức_ĐỘ", mucDo);
                    command.Parameters.AddWithValue("@Lớp", ccb_lop.SelectedValue.ToString()); // cbLop là ComboBox chứa mã lớp

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
                string ma = data_thongbao.SelectedRows[0].Cells["id"].Value.ToString();

                string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
                string query = "DELETE FROM Thông_Báo WHERE id = @id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", ma);
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
            // TODO: This line of code loads data into the 'quanLySinhVienDataSet2.Thông_Tin_Lớp_Học' table. You can move, or remove it, as needed.
            //this.thông_Tin_Lớp_HọcTableAdapter.Fill(this.quanLySinhVienDataSet2.Thông_Tin_Lớp_Học);
            // TODO: This line of code loads data into the 'quanLySinhVienDataSet.LopHoc' table. You can move, or remove it, as needed.
            //this.lopHocTableAdapter.Fill(this.quanLySinhVienDataSet.LopHoc);

        }

        private void SearchByClass(string className)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
            string query = @"SELECT 
            tb.STT,
            lh.Tên_Lớp AS Lớp,
            tb.Tiêu_Đề,
            tb.Nội_Dung,
            tb.Mức_Độ
            FROM Thông_Báo tb
            JOIN Thông_Tin_Lớp_Học lh ON tb.Lớp = lh.ID
            WHERE lh.Tên_Lớp LIKE @ClassName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@ClassName", "%" + className + "%");

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    data_thongbao.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        // Sự kiện click cho nút tìm kiếm
     

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string searchText = txtBox_TImKiemTHongBao.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadDataToGridView(); // Nếu textbox rỗng thì load toàn bộ
            }
            else
            {
                SearchByClass(searchText); // Nếu có nội dung thì tìm kiếm
            }
        }
       
    }
}
