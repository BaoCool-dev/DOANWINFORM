namespace QuanLySinhVien
{
    partial class DanhSachLop
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
            this.panel_DanhSachLop = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_refesh = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_timkiem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.gp_TacVuDanhDanhSachlop = new System.Windows.Forms.GroupBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_KiemTra = new Guna.UI2.WinForms.Guna2Button();
            this.txtDiemCK = new System.Windows.Forms.TextBox();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_chinhsua = new Guna.UI2.WinForms.Guna2Button();
            this.txtDiemGK = new System.Windows.Forms.TextBox();
            this.txt_Lop = new System.Windows.Forms.TextBox();
            this.txt_MaSinhVien = new System.Windows.Forms.TextBox();
            this.txt_Hoten = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_TImKiemDanhSachLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_TroVeLopCuaBan = new Guna.UI2.WinForms.Guna2Button();
            this.data_bangdiem = new System.Windows.Forms.DataGridView();
            this.bangDiemCNTT01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLySinhVienDataSet1 = new QuanLySinhVien.QuanLySinhVienDataSet1();
            this.bangDiem_CNTT01TableAdapter = new QuanLySinhVien.QuanLySinhVienDataSet1TableAdapters.BangDiem_CNTT01TableAdapter();
            this.panel_DanhSachLop.SuspendLayout();
            this.gp_TacVuDanhDanhSachlop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_bangdiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemCNTT01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_DanhSachLop
            // 
            this.panel_DanhSachLop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_DanhSachLop.BorderThickness = 1;
            this.panel_DanhSachLop.Controls.Add(this.btn_refesh);
            this.panel_DanhSachLop.Controls.Add(this.btn_timkiem);
            this.panel_DanhSachLop.Controls.Add(this.gp_TacVuDanhDanhSachlop);
            this.panel_DanhSachLop.Controls.Add(this.txtBox_TImKiemDanhSachLop);
            this.panel_DanhSachLop.Controls.Add(this.btn_TroVeLopCuaBan);
            this.panel_DanhSachLop.Controls.Add(this.data_bangdiem);
            this.panel_DanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DanhSachLop.FillColor = System.Drawing.Color.DarkOrange;
            this.panel_DanhSachLop.FillColor2 = System.Drawing.Color.LightGoldenrodYellow;
            this.panel_DanhSachLop.FillColor3 = System.Drawing.Color.Orange;
            this.panel_DanhSachLop.Location = new System.Drawing.Point(0, 0);
            this.panel_DanhSachLop.Name = "panel_DanhSachLop";
            this.panel_DanhSachLop.Size = new System.Drawing.Size(1726, 882);
            this.panel_DanhSachLop.TabIndex = 1;
            // 
            // btn_refesh
            // 
            this.btn_refesh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refesh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refesh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refesh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refesh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refesh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refesh.FillColor = System.Drawing.Color.Transparent;
            this.btn_refesh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_refesh.ForeColor = System.Drawing.Color.White;
            this.btn_refesh.Image = global::QuanLySinhVien.Properties.Resources.exchange_4051968;
            this.btn_refesh.Location = new System.Drawing.Point(1074, 90);
            this.btn_refesh.Name = "btn_refesh";
            this.btn_refesh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_refesh.Size = new System.Drawing.Size(37, 34);
            this.btn_refesh.TabIndex = 11;
            this.btn_refesh.Click += new System.EventHandler(this.btn_refesh_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timkiem.BackColor = System.Drawing.Color.Transparent;
            this.btn_timkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_timkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_timkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_timkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_timkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_timkiem.FillColor = System.Drawing.Color.Transparent;
            this.btn_timkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_timkiem.ForeColor = System.Drawing.Color.White;
            this.btn_timkiem.Image = global::QuanLySinhVien.Properties.Resources.tool_16205471_removebg_preview;
            this.btn_timkiem.ImageSize = new System.Drawing.Size(70, 70);
            this.btn_timkiem.Location = new System.Drawing.Point(1158, 24);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_timkiem.Size = new System.Drawing.Size(83, 80);
            this.btn_timkiem.TabIndex = 10;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // gp_TacVuDanhDanhSachlop
            // 
            this.gp_TacVuDanhDanhSachlop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_TacVuDanhDanhSachlop.BackColor = System.Drawing.Color.Transparent;
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.guna2Button1);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.btn_KiemTra);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.txtDiemCK);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.btn_clear);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.btn_them);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.btn_xoa);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.btn_chinhsua);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.txtDiemGK);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.txt_Lop);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.txt_MaSinhVien);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.txt_Hoten);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.label7);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.label5);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.label3);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.label2);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.label1);
            this.gp_TacVuDanhDanhSachlop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gp_TacVuDanhDanhSachlop.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_TacVuDanhDanhSachlop.Location = new System.Drawing.Point(1144, 130);
            this.gp_TacVuDanhDanhSachlop.Name = "gp_TacVuDanhDanhSachlop";
            this.gp_TacVuDanhDanhSachlop.Size = new System.Drawing.Size(523, 768);
            this.gp_TacVuDanhDanhSachlop.TabIndex = 9;
            this.gp_TacVuDanhDanhSachlop.TabStop = false;
            this.gp_TacVuDanhDanhSachlop.Text = "TÁC VỤ:";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(162, 535);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(189, 45);
            this.guna2Button1.TabIndex = 20;
            this.guna2Button1.Text = "Chat với sinh viên này";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btn_KiemTra
            // 
            this.btn_KiemTra.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_KiemTra.Animated = true;
            this.btn_KiemTra.AutoRoundedCorners = true;
            this.btn_KiemTra.BackColor = System.Drawing.Color.Transparent;
            this.btn_KiemTra.BorderThickness = 1;
            this.btn_KiemTra.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_KiemTra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_KiemTra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_KiemTra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_KiemTra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_KiemTra.FillColor = System.Drawing.Color.White;
            this.btn_KiemTra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_KiemTra.ForeColor = System.Drawing.Color.Black;
            this.btn_KiemTra.Location = new System.Drawing.Point(323, 126);
            this.btn_KiemTra.Name = "btn_KiemTra";
            this.btn_KiemTra.Size = new System.Drawing.Size(143, 34);
            this.btn_KiemTra.TabIndex = 19;
            this.btn_KiemTra.Text = "Kiểm tra";
            this.btn_KiemTra.Click += new System.EventHandler(this.btn_KiemTra_Click);
            // 
            // txtDiemCK
            // 
            this.txtDiemCK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemCK.Location = new System.Drawing.Point(403, 260);
            this.txtDiemCK.Name = "txtDiemCK";
            this.txtDiemCK.Size = new System.Drawing.Size(49, 27);
            this.txtDiemCK.TabIndex = 18;
            // 
            // btn_clear
            // 
            this.btn_clear.Animated = true;
            this.btn_clear.AutoRoundedCorners = true;
            this.btn_clear.BorderThickness = 1;
            this.btn_clear.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear.FillColor = System.Drawing.Color.White;
            this.btn_clear.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(298, 442);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(143, 36);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_them
            // 
            this.btn_them.Animated = true;
            this.btn_them.AutoRoundedCorners = true;
            this.btn_them.BorderThickness = 1;
            this.btn_them.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_them.FillColor = System.Drawing.Color.White;
            this.btn_them.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Location = new System.Drawing.Point(64, 442);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(143, 36);
            this.btn_them.TabIndex = 16;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Animated = true;
            this.btn_xoa.AutoRoundedCorners = true;
            this.btn_xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoa.BorderThickness = 1;
            this.btn_xoa.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoa.FillColor = System.Drawing.Color.White;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(298, 344);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(143, 36);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_chinhsua
            // 
            this.btn_chinhsua.Animated = true;
            this.btn_chinhsua.AutoRoundedCorners = true;
            this.btn_chinhsua.BackColor = System.Drawing.Color.Transparent;
            this.btn_chinhsua.BorderThickness = 1;
            this.btn_chinhsua.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_chinhsua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_chinhsua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_chinhsua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_chinhsua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_chinhsua.FillColor = System.Drawing.Color.White;
            this.btn_chinhsua.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_chinhsua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_chinhsua.ForeColor = System.Drawing.Color.Black;
            this.btn_chinhsua.Location = new System.Drawing.Point(64, 344);
            this.btn_chinhsua.Name = "btn_chinhsua";
            this.btn_chinhsua.Size = new System.Drawing.Size(143, 36);
            this.btn_chinhsua.TabIndex = 14;
            this.btn_chinhsua.Text = "Chính sửa";
            this.btn_chinhsua.Click += new System.EventHandler(this.btn_chinhsua_Click);
            // 
            // txtDiemGK
            // 
            this.txtDiemGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemGK.Location = new System.Drawing.Point(199, 263);
            this.txtDiemGK.Name = "txtDiemGK";
            this.txtDiemGK.Size = new System.Drawing.Size(53, 27);
            this.txtDiemGK.TabIndex = 11;
            // 
            // txt_Lop
            // 
            this.txt_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lop.Location = new System.Drawing.Point(162, 196);
            this.txt_Lop.Name = "txt_Lop";
            this.txt_Lop.ReadOnly = true;
            this.txt_Lop.Size = new System.Drawing.Size(112, 27);
            this.txt_Lop.TabIndex = 9;
            // 
            // txt_MaSinhVien
            // 
            this.txt_MaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSinhVien.Location = new System.Drawing.Point(142, 133);
            this.txt_MaSinhVien.Name = "txt_MaSinhVien";
            this.txt_MaSinhVien.Size = new System.Drawing.Size(110, 27);
            this.txt_MaSinhVien.TabIndex = 8;
            this.txt_MaSinhVien.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Hoten.Location = new System.Drawing.Point(199, 70);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.ReadOnly = true;
            this.txt_Hoten.Size = new System.Drawing.Size(267, 27);
            this.txt_Hoten.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Điểm cuối kỳ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm giữa kỳ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSSV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // txtBox_TImKiemDanhSachLop
            // 
            this.txtBox_TImKiemDanhSachLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_TImKiemDanhSachLop.AutoRoundedCorners = true;
            this.txtBox_TImKiemDanhSachLop.BackColor = System.Drawing.Color.Transparent;
            this.txtBox_TImKiemDanhSachLop.BorderColor = System.Drawing.Color.Black;
            this.txtBox_TImKiemDanhSachLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_TImKiemDanhSachLop.DefaultText = "";
            this.txtBox_TImKiemDanhSachLop.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBox_TImKiemDanhSachLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBox_TImKiemDanhSachLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_TImKiemDanhSachLop.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_TImKiemDanhSachLop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_TImKiemDanhSachLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBox_TImKiemDanhSachLop.ForeColor = System.Drawing.Color.Black;
            this.txtBox_TImKiemDanhSachLop.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_TImKiemDanhSachLop.IconLeft = global::QuanLySinhVien.Properties.Resources.tool_16205471;
            this.txtBox_TImKiemDanhSachLop.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtBox_TImKiemDanhSachLop.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtBox_TImKiemDanhSachLop.Location = new System.Drawing.Point(262, 41);
            this.txtBox_TImKiemDanhSachLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_TImKiemDanhSachLop.Name = "txtBox_TImKiemDanhSachLop";
            this.txtBox_TImKiemDanhSachLop.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtBox_TImKiemDanhSachLop.PlaceholderText = "Tìm kiếm";
            this.txtBox_TImKiemDanhSachLop.SelectedText = "";
            this.txtBox_TImKiemDanhSachLop.Size = new System.Drawing.Size(799, 48);
            this.txtBox_TImKiemDanhSachLop.TabIndex = 8;
            // 
            // btn_TroVeLopCuaBan
            // 
            this.btn_TroVeLopCuaBan.Animated = true;
            this.btn_TroVeLopCuaBan.AutoRoundedCorners = true;
            this.btn_TroVeLopCuaBan.BackColor = System.Drawing.Color.Transparent;
            this.btn_TroVeLopCuaBan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_TroVeLopCuaBan.BorderThickness = 1;
            this.btn_TroVeLopCuaBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TroVeLopCuaBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TroVeLopCuaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TroVeLopCuaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TroVeLopCuaBan.FillColor = System.Drawing.Color.White;
            this.btn_TroVeLopCuaBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TroVeLopCuaBan.ForeColor = System.Drawing.Color.Black;
            this.btn_TroVeLopCuaBan.Image = global::QuanLySinhVien.Properties.Resources.left_arrow_3272431;
            this.btn_TroVeLopCuaBan.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btn_TroVeLopCuaBan.Location = new System.Drawing.Point(76, 45);
            this.btn_TroVeLopCuaBan.Name = "btn_TroVeLopCuaBan";
            this.btn_TroVeLopCuaBan.Size = new System.Drawing.Size(128, 44);
            this.btn_TroVeLopCuaBan.TabIndex = 7;
            this.btn_TroVeLopCuaBan.Text = "Trở lại";
            this.btn_TroVeLopCuaBan.Click += new System.EventHandler(this.btn_TroVeLopCuaBan_Click);
            // 
            // data_bangdiem
            // 
            this.data_bangdiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_bangdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_bangdiem.Location = new System.Drawing.Point(76, 130);
            this.data_bangdiem.Name = "data_bangdiem";
            this.data_bangdiem.ReadOnly = true;
            this.data_bangdiem.RowHeadersWidth = 51;
            this.data_bangdiem.RowTemplate.Height = 24;
            this.data_bangdiem.Size = new System.Drawing.Size(1035, 708);
            this.data_bangdiem.TabIndex = 6;
            this.data_bangdiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_bangdiem_CellContentClick);
            // 
            // bangDiemCNTT01BindingSource
            // 
            this.bangDiemCNTT01BindingSource.DataMember = "BangDiem_CNTT01";
            this.bangDiemCNTT01BindingSource.DataSource = this.quanLySinhVienDataSet1;
            // 
            // quanLySinhVienDataSet1
            // 
            this.quanLySinhVienDataSet1.DataSetName = "QuanLySinhVienDataSet1";
            this.quanLySinhVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangDiem_CNTT01TableAdapter
            // 
            this.bangDiem_CNTT01TableAdapter.ClearBeforeFill = true;
            // 
            // DanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 882);
            this.Controls.Add(this.panel_DanhSachLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhSachLop";
            this.Text = "DanhSachLop";
            this.Load += new System.EventHandler(this.DanhSachLop_Load);
            this.panel_DanhSachLop.ResumeLayout(false);
            this.gp_TacVuDanhDanhSachlop.ResumeLayout(false);
            this.gp_TacVuDanhDanhSachlop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_bangdiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemCNTT01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel_DanhSachLop;
        private System.Windows.Forms.DataGridView data_bangdiem;
        private Guna.UI2.WinForms.Guna2Button btn_TroVeLopCuaBan;
        private Guna.UI2.WinForms.Guna2TextBox txtBox_TImKiemDanhSachLop;
        private System.Windows.Forms.GroupBox gp_TacVuDanhDanhSachlop;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private Guna.UI2.WinForms.Guna2Button btn_chinhsua;
        private System.Windows.Forms.TextBox txtDiemGK;
        private System.Windows.Forms.TextBox txt_Lop;
        private System.Windows.Forms.TextBox txt_MaSinhVien;
        private System.Windows.Forms.TextBox txt_Hoten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiemCK;
        private QuanLySinhVienDataSet1 quanLySinhVienDataSet1;
        private System.Windows.Forms.BindingSource bangDiemCNTT01BindingSource;
        private QuanLySinhVienDataSet1TableAdapters.BangDiem_CNTT01TableAdapter bangDiem_CNTT01TableAdapter;
        private Guna.UI2.WinForms.Guna2Button btn_KiemTra;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_timkiem;
        private Guna.UI2.WinForms.Guna2CircleButton btn_refesh;
    }
}