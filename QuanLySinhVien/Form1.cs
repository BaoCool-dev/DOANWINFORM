using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            container(new ThongBao());
            labelinfor.Text = "Thông báo";
        }

        private void container(object object_form)
        {
            if (Control_Panel.Controls.Count > 0) 
                Control_Panel.Controls.Clear();

            Form fm = object_form as Form;
            if (fm != null)
            {
                fm.TopLevel = false;
                fm.FormBorderStyle = FormBorderStyle.None;
                fm.Dock = DockStyle.Fill;

                Control_Panel.Controls.Add(fm);
                Control_Panel.Tag = fm;
                fm.Show();
            }
        }


        private void btn_ThongBao_Click(object sender, EventArgs e)
        {
            container(new ThongBao());
            labelinfor.Text = "Thông báo";
        }

        private void btn_ThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            container(new ThoiKhoaBieu());
            labelinfor.Text = "Thời khóa biểu";
        }

        private void btn_LopCuaBan_Click(object sender, EventArgs e)
        {
            container(new LopCuaBan());
            labelinfor.Text = "Lớp của bạn";
        }

        private void btn_ThongTinGiangVien_Click(object sender, EventArgs e)
        {
            container(new ThongTin_GiangVien());
            labelinfor.Text = "Thông tin giảng viên";
        }
    }
}
