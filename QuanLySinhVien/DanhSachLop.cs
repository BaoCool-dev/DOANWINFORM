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
    }
}
