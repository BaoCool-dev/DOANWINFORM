namespace QuanLySinhVien
{
    partial class LopCuaBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_LopCuaBan = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.data_LopCuaBan = new System.Windows.Forms.DataGridView();
            this.btn_TimKiemLopCuaBan = new Guna.UI2.WinForms.Guna2Button();
            this.cb_HocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_NienKhoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quanLySinhVienDataSet = new QuanLySinhVien.QuanLySinhVienDataSet();
            this.lopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopHocTableAdapter = new QuanLySinhVien.QuanLySinhVienDataSetTableAdapters.LopHocTableAdapter();
            this.panel_LopCuaBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_LopCuaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_LopCuaBan
            // 
            this.panel_LopCuaBan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_LopCuaBan.BorderThickness = 1;
            this.panel_LopCuaBan.Controls.Add(this.data_LopCuaBan);
            this.panel_LopCuaBan.Controls.Add(this.btn_TimKiemLopCuaBan);
            this.panel_LopCuaBan.Controls.Add(this.cb_HocKy);
            this.panel_LopCuaBan.Controls.Add(this.label2);
            this.panel_LopCuaBan.Controls.Add(this.cb_NienKhoa);
            this.panel_LopCuaBan.Controls.Add(this.label1);
            this.panel_LopCuaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_LopCuaBan.FillColor = System.Drawing.Color.DarkOrange;
            this.panel_LopCuaBan.FillColor2 = System.Drawing.Color.LightGoldenrodYellow;
            this.panel_LopCuaBan.FillColor3 = System.Drawing.Color.Orange;
            this.panel_LopCuaBan.Location = new System.Drawing.Point(0, 0);
            this.panel_LopCuaBan.Name = "panel_LopCuaBan";
            this.panel_LopCuaBan.Size = new System.Drawing.Size(1726, 882);
            this.panel_LopCuaBan.TabIndex = 0;
            // 
            // data_LopCuaBan
            // 
            this.data_LopCuaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_LopCuaBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_LopCuaBan.Location = new System.Drawing.Point(76, 130);
            this.data_LopCuaBan.Name = "data_LopCuaBan";
            this.data_LopCuaBan.RowHeadersWidth = 51;
            this.data_LopCuaBan.RowTemplate.Height = 24;
            this.data_LopCuaBan.Size = new System.Drawing.Size(1560, 708);
            this.data_LopCuaBan.TabIndex = 6;
            this.data_LopCuaBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_LopCuaBan_CellContentClick);
            // 
            // btn_TimKiemLopCuaBan
            // 
            this.btn_TimKiemLopCuaBan.Animated = true;
            this.btn_TimKiemLopCuaBan.AutoRoundedCorners = true;
            this.btn_TimKiemLopCuaBan.BackColor = System.Drawing.Color.Transparent;
            this.btn_TimKiemLopCuaBan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_TimKiemLopCuaBan.BorderThickness = 1;
            this.btn_TimKiemLopCuaBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemLopCuaBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemLopCuaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiemLopCuaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiemLopCuaBan.FillColor = System.Drawing.Color.White;
            this.btn_TimKiemLopCuaBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TimKiemLopCuaBan.ForeColor = System.Drawing.Color.Black;
            this.btn_TimKiemLopCuaBan.Location = new System.Drawing.Point(707, 40);
            this.btn_TimKiemLopCuaBan.Name = "btn_TimKiemLopCuaBan";
            this.btn_TimKiemLopCuaBan.Size = new System.Drawing.Size(128, 44);
            this.btn_TimKiemLopCuaBan.TabIndex = 5;
            this.btn_TimKiemLopCuaBan.Text = "Tìm kiếm";
            this.btn_TimKiemLopCuaBan.Click += new System.EventHandler(this.btn_TimKiemLopCuaBan_Click);
            // 
            // cb_HocKy
            // 
            this.cb_HocKy.AutoRoundedCorners = true;
            this.cb_HocKy.BackColor = System.Drawing.Color.Transparent;
            this.cb_HocKy.BorderColor = System.Drawing.Color.Black;
            this.cb_HocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_HocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_HocKy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_HocKy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_HocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_HocKy.ForeColor = System.Drawing.Color.Black;
            this.cb_HocKy.ItemHeight = 30;
            this.cb_HocKy.Items.AddRange(new object[] {
            "HKI",
            "HKII",
            "HKIII"});
            this.cb_HocKy.Location = new System.Drawing.Point(536, 40);
            this.cb_HocKy.Name = "cb_HocKy";
            this.cb_HocKy.Size = new System.Drawing.Size(93, 36);
            this.cb_HocKy.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kỳ học:";
            // 
            // cb_NienKhoa
            // 
            this.cb_NienKhoa.AutoRoundedCorners = true;
            this.cb_NienKhoa.BackColor = System.Drawing.Color.Transparent;
            this.cb_NienKhoa.BorderColor = System.Drawing.Color.Black;
            this.cb_NienKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_NienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NienKhoa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_NienKhoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_NienKhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_NienKhoa.ForeColor = System.Drawing.Color.Black;
            this.cb_NienKhoa.ItemHeight = 30;
            this.cb_NienKhoa.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.cb_NienKhoa.Location = new System.Drawing.Point(206, 40);
            this.cb_NienKhoa.Name = "cb_NienKhoa";
            this.cb_NienKhoa.Size = new System.Drawing.Size(140, 36);
            this.cb_NienKhoa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Niên khóa:";
            // 
            // quanLySinhVienDataSet
            // 
            this.quanLySinhVienDataSet.DataSetName = "QuanLySinhVienDataSet";
            this.quanLySinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopHocBindingSource
            // 
            this.lopHocBindingSource.DataMember = "LopHoc";
            this.lopHocBindingSource.DataSource = this.quanLySinhVienDataSet;
            // 
            // lopHocTableAdapter
            // 
            this.lopHocTableAdapter.ClearBeforeFill = true;
            // 
            // LopCuaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 882);
            this.Controls.Add(this.panel_LopCuaBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LopCuaBan";
            this.Text = "LopCuaBan";
            this.Load += new System.EventHandler(this.LopCuaBan_Load);
            this.panel_LopCuaBan.ResumeLayout(false);
            this.panel_LopCuaBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_LopCuaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel_LopCuaBan;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_NienKhoa;
        private Guna.UI2.WinForms.Guna2ComboBox cb_HocKy;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiemLopCuaBan;
        private System.Windows.Forms.DataGridView data_LopCuaBan;
        private QuanLySinhVienDataSet quanLySinhVienDataSet;
        private System.Windows.Forms.BindingSource lopHocBindingSource;
        private QuanLySinhVienDataSetTableAdapters.LopHocTableAdapter lopHocTableAdapter;
    }
}