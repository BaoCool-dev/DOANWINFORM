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
        string position;
        public Form1(string position)
        {
            this.position = position;
            InitializeComponent();
            container(new ThongBao(position));
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

        private void ResetButtonsToTransparent()
        {
            btn_ThongBao.FillColor = Color.Transparent;
            btn_ThoiKhoaBieu.FillColor = Color.Transparent;
            btn_LopCuaBan.FillColor = Color.Transparent;
            btn_ThongTinGiangVien.FillColor = Color.Transparent;

        }
        private void btn_ThongBao_Click(object sender, EventArgs e)
        {
            ResetButtonsToTransparent();
            btn_ThongBao.FillColor = Color.FromArgb(255, 128, 0);
            container(new ThongBao(position));
            labelinfor.Text = "Thông báo";
        }

        private void btn_ThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            ResetButtonsToTransparent();
            btn_ThoiKhoaBieu.FillColor = Color.Goldenrod;
            container(new ThoiKhoaBieu(position));
            labelinfor.Text = "Thời khóa biểu";
        }

        private void btn_LopCuaBan_Click(object sender, EventArgs e)
        {
            ResetButtonsToTransparent();
            btn_LopCuaBan.FillColor= Color.Orange;
            container(new LopCuaBan(position));
            labelinfor.Text = "Lớp của bạn";
        }

        private void btn_ThongTinGiangVien_Click(object sender, EventArgs e)
        {
            ResetButtonsToTransparent();
            btn_ThongTinGiangVien.FillColor = Color.SandyBrown;
            container(new ThongTin_GiangVien(position));
            labelinfor.Text = "Thông tin giảng viên";
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
