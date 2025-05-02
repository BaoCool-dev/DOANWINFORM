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
            this.gp_TacVuDanhDanhSachlop = new System.Windows.Forms.GroupBox();
            this.txtDiemCK = new System.Windows.Forms.TextBox();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_chinhsua = new Guna.UI2.WinForms.Guna2Button();
            this.txtDiemGK = new System.Windows.Forms.TextBox();
            this.txt_Nganh = new System.Windows.Forms.TextBox();
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
            this.hotenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nganhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemGKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel_DanhSachLop.Controls.Add(this.gp_TacVuDanhDanhSachlop);
            this.panel_DanhSachLop.Controls.Add(this.txtBox_TImKiemDanhSachLop);
            this.panel_DanhSachLop.Controls.Add(this.btn_TroVeLopCuaBan);
            this.panel_DanhSachLop.Controls.Add(this.data_bangdiem);
            this.panel_DanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DanhSachLop.FillColor = System.Drawing.Color.DarkOrange;
            this.panel_DanhSachLop.FillColor2 = System.Drawing.Color.LightGoldenrodYellow;
            this.panel_DanhSachLop.FillColor3 = System.Drawing.Color.Orange;
            this.panel_DanhSachLop.Location = new System.Drawing.Point(0, 0);
            this.panel_DanhSachLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_DanhSachLop.Name = "panel_DanhSachLop";
            this.panel_DanhSachLop.Size = new System.Drawing.Size(1946, 1106);
            this.panel_DanhSachLop.TabIndex = 1;
            // 
            // gp_TacVuDanhDanhSachlop
            // 
            this.gp_TacVuDanhDanhSachlop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_TacVuDanhDanhSachlop.BackColor = System.Drawing.Color.Transparent;
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.txtDiemCK);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.btn_clear);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.btn_them);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.btn_xoa);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.btn_chinhsua);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.txtDiemGK);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.txt_Nganh);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.txt_MaSinhVien);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.txt_Hoten);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.label7);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.label5);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.label3);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.label2);
            this.gp_TacVuDanhDanhSachlop.Controls.Add(this.label1);
            this.gp_TacVuDanhDanhSachlop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gp_TacVuDanhDanhSachlop.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_TacVuDanhDanhSachlop.Location = new System.Drawing.Point(1291, 162);
            this.gp_TacVuDanhDanhSachlop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gp_TacVuDanhDanhSachlop.Name = "gp_TacVuDanhDanhSachlop";
            this.gp_TacVuDanhDanhSachlop.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gp_TacVuDanhDanhSachlop.Size = new System.Drawing.Size(588, 964);
            this.gp_TacVuDanhDanhSachlop.TabIndex = 9;
            this.gp_TacVuDanhDanhSachlop.TabStop = false;
            this.gp_TacVuDanhDanhSachlop.Text = "TÁC VỤ:";
            // 
            // txtDiemCK
            // 
            this.txtDiemCK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemCK.Location = new System.Drawing.Point(453, 325);
            this.txtDiemCK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiemCK.Name = "txtDiemCK";
            this.txtDiemCK.Size = new System.Drawing.Size(42, 31);
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
            this.btn_clear.Location = new System.Drawing.Point(335, 552);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(161, 45);
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
            this.btn_them.Location = new System.Drawing.Point(72, 552);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(161, 45);
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
            this.btn_xoa.Location = new System.Drawing.Point(335, 430);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(161, 45);
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
            this.btn_chinhsua.Location = new System.Drawing.Point(72, 430);
            this.btn_chinhsua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_chinhsua.Name = "btn_chinhsua";
            this.btn_chinhsua.Size = new System.Drawing.Size(161, 45);
            this.btn_chinhsua.TabIndex = 14;
            this.btn_chinhsua.Text = "Chính sửa";
            this.btn_chinhsua.Click += new System.EventHandler(this.btn_chinhsua_Click);
            // 
            // txtDiemGK
            // 
            this.txtDiemGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemGK.Location = new System.Drawing.Point(224, 329);
            this.txtDiemGK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiemGK.Name = "txtDiemGK";
            this.txtDiemGK.Size = new System.Drawing.Size(42, 31);
            this.txtDiemGK.TabIndex = 11;
            // 
            // txt_Nganh
            // 
            this.txt_Nganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nganh.Location = new System.Drawing.Point(182, 245);
            this.txt_Nganh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Nganh.Name = "txt_Nganh";
            this.txt_Nganh.Size = new System.Drawing.Size(212, 31);
            this.txt_Nganh.TabIndex = 9;
            // 
            // txt_MaSinhVien
            // 
            this.txt_MaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSinhVien.Location = new System.Drawing.Point(160, 166);
            this.txt_MaSinhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaSinhVien.Name = "txt_MaSinhVien";
            this.txt_MaSinhVien.Size = new System.Drawing.Size(123, 31);
            this.txt_MaSinhVien.TabIndex = 8;
            this.txt_MaSinhVien.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Hoten.Location = new System.Drawing.Point(224, 88);
            this.txt_Hoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(295, 31);
            this.txt_Hoten.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(306, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Điểm cuối kỳ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm giữa kỳ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngành:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSSV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 30);
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
            this.txtBox_TImKiemDanhSachLop.Location = new System.Drawing.Point(295, 51);
            this.txtBox_TImKiemDanhSachLop.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBox_TImKiemDanhSachLop.Name = "txtBox_TImKiemDanhSachLop";
            this.txtBox_TImKiemDanhSachLop.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtBox_TImKiemDanhSachLop.PlaceholderText = "Tìm kiếm";
            this.txtBox_TImKiemDanhSachLop.SelectedText = "";
            this.txtBox_TImKiemDanhSachLop.Size = new System.Drawing.Size(903, 60);
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
            this.btn_TroVeLopCuaBan.Location = new System.Drawing.Point(86, 56);
            this.btn_TroVeLopCuaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TroVeLopCuaBan.Name = "btn_TroVeLopCuaBan";
            this.btn_TroVeLopCuaBan.Size = new System.Drawing.Size(144, 55);
            this.btn_TroVeLopCuaBan.TabIndex = 7;
            this.btn_TroVeLopCuaBan.Text = "Trở lại";
            this.btn_TroVeLopCuaBan.Click += new System.EventHandler(this.btn_TroVeLopCuaBan_Click);
            // 
            // data_bangdiem
            // 
            this.data_bangdiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_bangdiem.AutoGenerateColumns = false;
            this.data_bangdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_bangdiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotenDataGridViewTextBoxColumn,
            this.maSinhVienDataGridViewTextBoxColumn,
            this.nganhDataGridViewTextBoxColumn,
            this.diemGKDataGridViewTextBoxColumn,
            this.diemCKDataGridViewTextBoxColumn});
            this.data_bangdiem.DataSource = this.bangDiemCNTT01BindingSource;
            this.data_bangdiem.Location = new System.Drawing.Point(86, 162);
            this.data_bangdiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_bangdiem.Name = "data_bangdiem";
            this.data_bangdiem.ReadOnly = true;
            this.data_bangdiem.RowHeadersWidth = 51;
            this.data_bangdiem.RowTemplate.Height = 24;
            this.data_bangdiem.Size = new System.Drawing.Size(1169, 889);
            this.data_bangdiem.TabIndex = 6;
            // 
            // hotenDataGridViewTextBoxColumn
            // 
            this.hotenDataGridViewTextBoxColumn.DataPropertyName = "Hoten";
            this.hotenDataGridViewTextBoxColumn.HeaderText = "Hoten";
            this.hotenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hotenDataGridViewTextBoxColumn.Name = "hotenDataGridViewTextBoxColumn";
            this.hotenDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotenDataGridViewTextBoxColumn.Width = 150;
            // 
            // maSinhVienDataGridViewTextBoxColumn
            // 
            this.maSinhVienDataGridViewTextBoxColumn.DataPropertyName = "MaSinhVien";
            this.maSinhVienDataGridViewTextBoxColumn.HeaderText = "MaSinhVien";
            this.maSinhVienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maSinhVienDataGridViewTextBoxColumn.Name = "maSinhVienDataGridViewTextBoxColumn";
            this.maSinhVienDataGridViewTextBoxColumn.ReadOnly = true;
            this.maSinhVienDataGridViewTextBoxColumn.Width = 150;
            // 
            // nganhDataGridViewTextBoxColumn
            // 
            this.nganhDataGridViewTextBoxColumn.DataPropertyName = "Nganh";
            this.nganhDataGridViewTextBoxColumn.HeaderText = "Nganh";
            this.nganhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nganhDataGridViewTextBoxColumn.Name = "nganhDataGridViewTextBoxColumn";
            this.nganhDataGridViewTextBoxColumn.ReadOnly = true;
            this.nganhDataGridViewTextBoxColumn.Width = 150;
            // 
            // diemGKDataGridViewTextBoxColumn
            // 
            this.diemGKDataGridViewTextBoxColumn.DataPropertyName = "DiemGK";
            this.diemGKDataGridViewTextBoxColumn.HeaderText = "DiemGK";
            this.diemGKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diemGKDataGridViewTextBoxColumn.Name = "diemGKDataGridViewTextBoxColumn";
            this.diemGKDataGridViewTextBoxColumn.ReadOnly = true;
            this.diemGKDataGridViewTextBoxColumn.Width = 150;
            // 
            // diemCKDataGridViewTextBoxColumn
            // 
            this.diemCKDataGridViewTextBoxColumn.DataPropertyName = "DiemCK";
            this.diemCKDataGridViewTextBoxColumn.HeaderText = "DiemCK";
            this.diemCKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diemCKDataGridViewTextBoxColumn.Name = "diemCKDataGridViewTextBoxColumn";
            this.diemCKDataGridViewTextBoxColumn.ReadOnly = true;
            this.diemCKDataGridViewTextBoxColumn.Width = 150;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.panel_DanhSachLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox txt_Nganh;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nganhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemGKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemCKDataGridViewTextBoxColumn;
    }
}