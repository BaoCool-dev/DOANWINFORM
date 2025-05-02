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
    public partial class LopCuaBan : Form
    {
        public LopCuaBan()
        {
            InitializeComponent();
            LoadDataToGridView();   
        }
        private void container(object object_form)
        {
            if (panel_LopCuaBan.Controls.Count > 0)
                panel_LopCuaBan.Controls.Clear();

            Form fm = object_form as Form;
            if (fm != null)
            {
                fm.TopLevel = false;
                fm.FormBorderStyle = FormBorderStyle.None;
                fm.Dock = DockStyle.Fill;

                panel_LopCuaBan.Controls.Add(fm);
                panel_LopCuaBan.Tag = fm;
                fm.Show();
            }
        }

        private void LoadDataToGridView()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
            string query = @"SELECT * From LopHoc";
          
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    data_LopCuaBan.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void data_LopCuaBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            container(new DanhSachLop());
        }

        private void LopCuaBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySinhVienDataSet.LopHoc' table. You can move, or remove it, as needed.
            this.lopHocTableAdapter.Fill(this.quanLySinhVienDataSet.LopHoc);

        }

        private void btn_TimKiemLopCuaBan_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";

            // Lấy giá trị từ ComboBox
            string nienKhoa = cb_NienKhoa.SelectedItem?.ToString();
            string kyHoc = cb_HocKy.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nienKhoa) || string.IsNullOrEmpty(kyHoc))
            {
                MessageBox.Show("Vui lòng chọn cả Niên khóa và Kỳ học.");
                return;
            }

            // Query có điều kiện WHERE
            string query = @"SELECT * FROM LopHoc WHERE NienKhoa = @NienKhoa AND HocKy = @HocKy";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Thêm tham số vào query
                    adapter.SelectCommand.Parameters.AddWithValue("@NienKhoa", nienKhoa);
                    adapter.SelectCommand.Parameters.AddWithValue("@HocKy", kyHoc);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    data_LopCuaBan.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
