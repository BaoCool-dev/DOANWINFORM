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
    public partial class Diem_Sinhvien : Form
    {
        string mssv;
        string connectionString;
        public Diem_Sinhvien(string mssv, string connectionString)
        {
            InitializeComponent();
            this.mssv = mssv;
            this.connectionString = connectionString;
            LoadData();
        }

        private void LoadData()
        {
            string query =

            @"WITH Diem_All AS (
              SELECT Mã           AS Ma_Sinh_Vien,
                     'MH001'      AS Ma_Mon,
                     ĐiểmGK,
                     ĐiểmCK
                FROM [Bảng_Điểm_TRR]
              UNION ALL
              SELECT Mã, 'MH002', ĐiểmGK, ĐiểmCK
                FROM [Bảng_Điểm_LTW]
              UNION ALL
              SELECT Mã, 'MH003', ĐiểmGK, ĐiểmCK
                FROM [Bảng_Điểm_KTMT]
              UNION ALL
              SELECT Mã, 'MH004', ĐiểmGK, ĐiểmCK
                FROM [Bảng_Điểm_KTLT]
              UNION ALL
              SELECT Mã, 'MH005', ĐiểmGK, ĐiểmCK
                FROM [Bảng_Điểm_TTNT]
            ),

            -- CTE chính để ghép sinh viên → thời khóa biểu → môn học → điểm
            BangDiem AS (
              SELECT
                sv.Mã_Sinh_Viên,
                --sv.Họ_và_Tên,
                tmh.Mã_Môn,
                tmh.Tên_Môn,
                tmh.Số_tín_chỉ,
                COALESCE(da.ĐiểmGK,0) AS ĐiểmGK,
                COALESCE(da.ĐiểmCK,0) AS ĐiểmCK,
                ROUND(
                  COALESCE(da.ĐiểmGK,0)*0.3
                  + COALESCE(da.ĐiểmCK,0)*0.7
                ,2) AS DiemTB,
                CAST(
                CASE 
                  WHEN COALESCE(da.ĐiểmGK,0)*0.3 + COALESCE(da.ĐiểmCK,0)*0.7 >= 8   THEN N'Giỏi'
                  WHEN COALESCE(da.ĐiểmGK,0)*0.3 + COALESCE(da.ĐiểmCK,0)*0.7 >= 6.5 THEN N'Khá'
                  WHEN COALESCE(da.ĐiểmGK,0)*0.3 + COALESCE(da.ĐiểmCK,0)*0.7 >= 5   THEN N'Trung Bình'
                  ELSE N'Yếu'
                END
              AS nvarchar(20)
              ) AS Xep_Loai
              FROM Thông_Tin_Sinh_Viên sv
              JOIN Thời_Khóa_Biểu    tkb
                ON sv.Lớp = tkb.Lớp
              JOIN Thông_Tin_Môn_Học tmh
                ON tkb.Môn_Học = tmh.Mã_Môn
              LEFT JOIN Diem_All da
                ON sv.Mã_Sinh_Viên = da.Ma_Sinh_Vien
               AND tmh.Mã_Môn       = da.Ma_Mon
              WHERE tmh.Bảng_Điểm IS NOT NULL
            )

            -- Lấy kết quả cho sinh viên @MSSV
            SELECT
              Tên_Môn as [Môn học],
              Số_tín_chỉ as [Số tín chỉ],
              ĐiểmGK,
              ĐiểmCK,
              DiemTB,
              Xep_Loai
            FROM BangDiem
            WHERE Mã_Sinh_Viên = @mssv
            ORDER BY Mã_Môn;
                        ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@mssv", mssv);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                StyleDataGridView();
            }
        }

        private void StyleDataGridView()
        {
            // 1. Bật tự co dãn cột cho vừa khung
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 2. Ẩn dòng chỉ số hàng (row header) nếu không cần
            dataGridView1.RowHeadersVisible = false;

            // 3. Thiết lập font chung, kích thước và padding
            var baseFont = new Font("Segoe UI", 9F);
            dataGridView1.DefaultCellStyle.Font = baseFont;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Padding = new Padding(4, 2, 4, 2);

            // 4. Căn giữa nội dung số
            dataGridView1.Columns["ĐiểmGK"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["ĐiểmCK"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["DiemTB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Số tín chỉ"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 5. Màu xen kẽ cho hàng (zebra striping)
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);

            // 6. Màu background chung và màu lưới
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.GridColor = Color.LightGray;

            // 7. Tô màu header và căn giữa
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 8. Màu khi chọn
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(135, 206, 250);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            // 9. Tăng chiều cao hàng để dễ đọc
            dataGridView1.RowTemplate.Height = 28;

            // 10. Chặn người dùng chỉnh sửa trực tiếp ở lưới
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void btn_XemDiem_Click(object sender, EventArgs e)
        {
            string namHoc = cb_NamHocXemDiem.Text;   
            string hocKi = cb_HocKyXemDiem.Text;

            if (namHoc != "2025" || hocKi != "II")
            {
                MessageBox.Show("Không có thông tin điểm cho năm học hoặc học kỳ đã chọn.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            LoadData();
        }
    }
}
