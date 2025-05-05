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
    public partial class ThoiKhoaBieu_Sinhvien : Form
    {
        private string mssv;
        public ThoiKhoaBieu_Sinhvien(string mssv)
        {
            InitializeComponent();
            this.mssv = mssv;
            LoadThoiKhoaBieu();
        }
        private void LoadThoiKhoaBieu()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=chibao";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        tkb.Thứ, 
                        tkb.Buổi, 
                        (mh.Tên_Môn 
                            + '(' + CAST(mh.Số_Tín_Chỉ AS VARCHAR) + ')'
                            + CHAR(13) + CHAR(10) + '(' + 'Phòng ' + tkb.Phòng + ')' 
                            + CHAR(13) + CHAR(10) + CHAR(13) + CHAR(10) + tkb.Hình_Thức 
                            + CHAR(13) + CHAR(10) + CHAR(13) + CHAR(10) + tkb.Chú_ý 
                            + CHAR(13) + CHAR(10) + CHAR(13) + CHAR(10) + 'gv: ' + gv.Họ_Và_Tên) AS Môn_Học
                    FROM Thông_Tin_Sinh_Viên sv
                    JOIN Thời_Khóa_Biểu tkb ON sv.Lớp = tkb.Lớp
                    JOIN Thông_Tin_Môn_Học mh ON tkb.Môn_Học = mh.Mã_Môn
                    JOIN Thông_Tin_Giảng_Viên gv ON gv.Mã_Giảng_Viên = mh.Mã_Giáo_Viên
                    WHERE sv.Mã_Sinh_Viên = @MSSV";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MSSV", mssv);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        DataTable pivoted = PivotTable(dt);
                        dataGridView1.DataSource = pivoted;
                        //dataGridView1.DataSource = dt;

                        // Beautify
                        dataGridView1.AllowUserToAddRows = false;
                        dataGridView1.ReadOnly = true;
                        dataGridView1.RowHeadersVisible = false;

                        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                        // Chọn *một* trong hai cái dưới tùy ý định:
                        // Nếu muốn cột co vừa nội dung:
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        // Nếu muốn cột dàn đều:
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        dataGridView1.BorderStyle = BorderStyle.FixedSingle;
                        dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single; // Lưới ngang + dọc
                        dataGridView1.GridColor = Color.Gray;

                        dataGridView1.EnableHeadersVisualStyles = false;
                        dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
                        dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                        dataGridView1.DefaultCellStyle.BackColor = Color.White;
                        dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                        dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                        dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
                        dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
                        //dataGridView1.Dock = DockStyle.None;
                        //dataGridView1.Height = dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible)
                        //+ dataGridView1.ColumnHeadersHeight;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }
        private DataTable PivotTable(DataTable originalTable)
        {
            DataTable pivot = new DataTable();
            pivot.Columns.Add("Buổi");

            //var distinctThu = originalTable.AsEnumerable()
            //    .Select(row => row.Field<string>("Thứ"))
            //    .Distinct()
            //    .OrderBy(x => x)
            //    .ToList();
            List<string> distinctThu = new List<string>
            {
                "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7"
            };

            foreach (var thu in distinctThu)
                pivot.Columns.Add(thu);

            //var distinctBuoi = originalTable.AsEnumerable()
            //    .Select(row => row.Field<string>("Buổi").Trim())
            //    .Distinct()
            //    .OrderBy(b =>
            //    b == "Sáng" ? 0 :
            //    b == "Chiều" ? 1 :2 );

            List<string> distinctBuoi = new List<string>
            {
                "Sáng", "Chiều","Tối"
            };

            foreach (var buoi in distinctBuoi)
            {
                DataRow newRow = pivot.NewRow();
                newRow["Buổi"] = buoi;

                foreach (var thu in distinctThu)
                {
                    var rowData = originalTable.AsEnumerable()
                        .FirstOrDefault(r => r.Field<string>("Thứ") == thu && r.Field<string>("Buổi").Trim() == buoi);

                    if (rowData != null)
                    {
                        string mon = rowData["Môn_Học"].ToString();
                        newRow[thu] = mon;
                    }
                }

                pivot.Rows.Add(newRow);
            }

            return pivot;
        }

        private void btn_TimKiemTKBSinhVien_Click(object sender, EventArgs e)
        {

        }
    }
}
