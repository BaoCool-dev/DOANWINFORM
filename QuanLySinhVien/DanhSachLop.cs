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
        public DanhSachLop()
        {
            InitializeComponent();
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
            container(new LopCuaBan());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DanhSachLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySinhVienDataSet1.BangDiem_CNTT01' table. You can move, or remove it, as needed.
            this.bangDiem_CNTT01TableAdapter.Fill(this.quanLySinhVienDataSet1.BangDiem_CNTT01);

        }
        private void LoadDataToGridView()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
            string query = @"SELECT * From BangDiem_CNTT01 ";
             
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    data_bangdiem.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
            string query = "INSERT INTO BangDiem_CNTT01 (Hoten, MaSinhVien, Nganh, DiemGK, DiemCK) VALUES (@Hoten, @MaSinhVien, @Nganh, @DiemGK, @DiemCK)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Hoten", txt_Hoten.Text);
                    cmd.Parameters.AddWithValue("@MaSinhVien", txt_MaSinhVien.Text);
                    cmd.Parameters.AddWithValue("@Nganh", txt_Nganh.Text);
                    cmd.Parameters.AddWithValue("@DiemGK", float.Parse(txtDiemGK.Text));
                    cmd.Parameters.AddWithValue("@DiemCK", float.Parse(txtDiemCK.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    LoadDataToGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
            string query = "DELETE FROM BangDiem_CNTT01 WHERE MaSinhVien = @MaSinhVien";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MaSinhVien", txt_MaSinhVien.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    LoadDataToGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";
            string query = "UPDATE BangDiem_CNTT01 SET Hoten = @Hoten, Nganh = @Nganh, DiemGK = @DiemGK, DiemCK = @DiemCK WHERE MaSinhVien = @MaSinhVien";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Hoten", txt_Hoten.Text);
                    cmd.Parameters.AddWithValue("@MaSinhVien", txt_MaSinhVien.Text);
                    cmd.Parameters.AddWithValue("@Nganh", txt_Nganh.Text);
                    cmd.Parameters.AddWithValue("@DiemGK", float.Parse(txtDiemGK.Text));
                    cmd.Parameters.AddWithValue("@DiemCK", float.Parse(txtDiemCK.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!");
                    LoadDataToGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Hoten.Clear();
            txt_MaSinhVien.Clear();
            txt_Nganh.Clear();
            txtDiemGK.Clear();
            txtDiemCK.Clear();
        }
    }
}
