using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLySinhVien
{
    public partial class Thongbao_sinhvien : Form
    {
        private string mssv;
        private string ConnectionString;
        public Thongbao_sinhvien(string mssv, string connectionString)
        {
            this.mssv = mssv;
            this.ConnectionString = connectionString;
            InitializeComponent();
            LoadThongBaoSinhVien();
        }

        //private void Thongbao_sinhvien_Load(object sender, EventArgs e)
        //{
        //    LoadThongBaoSinhVien();
        //}

        private void LoadThongBaoSinhVien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    string query = @"
                SELECT TB.Tiêu_Đề, TB.Nội_Dung, TB.Mức_Độ, TB.Thời_Gian
                FROM Thông_Báo TB
                JOIN Thông_Tin_Sinh_Viên SV ON TB.Lớp = SV.Lớp
                WHERE SV.Mã_Sinh_Viên = @mssv";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@mssv", mssv);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    guna2DataGridView1.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc truy vấn CSDL:\n" + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
                string noiDung = row.Cells["Nội_Dung"].Value?.ToString();
                richTextBox1.Text = noiDung;
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gb_ThongBaoGiangVien_Enter(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
