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
        string connectionString = "Server=your_server_name;Database=your_database_name;Trusted_Connection=True;";
        // Hoặc nếu dùng tài khoản SQL Server:
        // string connectionString = "Server=your_server_name;Database=your_database_name;User Id=your_username;Password=your_password;";
        public ThongBao()
        {
            InitializeComponent();
        }

        private void LoadDataToGridView()
        {
            string connectionString = "Server=your_server_name;Database=your_database_name;Trusted_Connection=True;";
            string query = "SELECT * FROM YourTableName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    //dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void InsertData()
        {
            string connectionString = "Server=your_server_name;Database=your_database_name;Trusted_Connection=True;";
            string query = "INSERT INTO YourTableName (Column1, Column2) VALUES (@Column1, @Column2)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    //command.Parameters.AddWithValue("@Column1", textBox1.Text);
                    //command.Parameters.AddWithValue("@Column2", textBox2.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void UpdateData()
        {
            string connectionString = "Server=your_server_name;Database=your_database_name;Trusted_Connection=True;";
            string query = "UPDATE YourTableName SET Column1 = @Column1, Column2 = @Column2 WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                   // command.Parameters.AddWithValue("@Column1", textBox1.Text);
                   //command.Parameters.AddWithValue("@Column2", textBox2.Text);
                   // command.Parameters.AddWithValue("@Id", textBoxId.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void DeleteData()
        {
            string connectionString = "Server=your_server_name;Database=your_database_name;Trusted_Connection=True;";
            string query = "DELETE FROM YourTableName WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    //command.Parameters.AddWithValue("@Id", textBoxId.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
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
    }
}
