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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
            // Bật DoubleBuffer cho chính form
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();

            // Bật DoubleBuffer cho tableLayoutPanel1 nếu không null
            if (tableLayoutPanel1 != null)
            {
                var prop = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                prop?.SetValue(tableLayoutPanel1, true);
            }

        }

    }
}
