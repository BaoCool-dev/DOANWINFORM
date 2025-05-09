﻿using System;
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
    public partial class FormSinhVien : Form
    {
        private string mssv;
        string connectionString;
        public FormSinhVien(string mssv, string connectionString)
        {
            this.mssv = mssv;
            this.connectionString = connectionString;
            InitializeComponent();
            container(new Thongbao_sinhvien(mssv, connectionString));
        }

        private void container(object object_form)
        {
            if (guna2CustomGradientPanel2.Controls.Count > 0)
                guna2CustomGradientPanel2.Controls.Clear();

            Form fm = object_form as Form;
            if (fm != null)
            {
                fm.TopLevel = false;
                fm.FormBorderStyle = FormBorderStyle.None; 
                fm.Dock = DockStyle.Fill;

                guna2CustomGradientPanel2.Controls.Add(fm);
                guna2CustomGradientPanel2.Tag = fm;
                fm.Show();
            }
        }
        private void btn_ThongBao_Sinhvien_Click(object sender, EventArgs e)
        {
            container(new Thongbao_sinhvien(mssv, connectionString));
            labelinfor_Sinhvien.Text = "Thông báo";
        }

        private void btn_ThoiKhoaBieu_Sinhvien_Click(object sender, EventArgs e)
        {
            container(new ThoiKhoaBieu_Sinhvien(mssv));
            labelinfor_Sinhvien.Text = "Thời khóa biểu";
        }

        private void btn_LopCuaBan_Sinhvien_Click(object sender, EventArgs e)
        {
            container(new Diem_Sinhvien(mssv, connectionString));
            labelinfor_Sinhvien.Text = "Điểm của bạn";
        }


        private void btn_ThongTinGiangVien_Sinhvien_Click(object sender, EventArgs e)
        {
            container(new ThongTinCaNhan_SinhVien(mssv));
            labelinfor_Sinhvien.Text = "Thông tin cá nhân";
            //container(new test());

        }

        private void btn_Khac_Click(object sender, EventArgs e)
        {
            container(new Khac(mssv));
            labelinfor_Sinhvien.Text = "Các mục khác";
        }

        private void btn_Exit_Sinhvien_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
