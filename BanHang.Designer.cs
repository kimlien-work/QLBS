namespace QLBS
{
    partial class BanHang
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            dgvSach = new DataGridView();
            MaSach = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            dgvGioHang = new DataGridView();
            IDSach = new DataGridViewTextBoxColumn();
            nameSach = new DataGridViewTextBoxColumn();
            soLuong = new DataGridViewTextBoxColumn();
            donGia = new DataGridViewTextBoxColumn();
            thanhTien = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            numSoLuong = new NumericUpDown();
            txtGiaBan = new TextBox();
            btnThemGioHang = new Button();
            label2 = new Label();
            label1 = new Label();
            label = new Label();
            label6 = new Label();
            txtMaSach = new TextBox();
            txtTenSach = new TextBox();
            panel4 = new Panel();
            btnThoat = new Button();
            BtnThanhToan = new Button();
            btnXoa = new Button();
            lblThanhTien = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvKhachHang = new DataGridView();
            MaKH = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            DiemTichLuy = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label4 = new Label();
            btnTimSDT = new Button();
            txtTimSDT = new TextBox();
            panel3 = new Panel();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            splitContainer1.Panel1.Controls.Add(panel4);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvKhachHang);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Size = new Size(1243, 777);
            splitContainer1.SplitterDistance = 860;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 52);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dgvSach);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dgvGioHang);
            splitContainer2.Panel2.Controls.Add(panel5);
            splitContainer2.Size = new Size(860, 619);
            splitContainer2.SplitterDistance = 261;
            splitContainer2.TabIndex = 120;
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { MaSach, TenSach, SoLuongTon, GiaBan });
            dgvSach.Dock = DockStyle.Fill;
            dgvSach.Location = new Point(0, 0);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.ScrollBars = ScrollBars.Vertical;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(860, 261);
            dgvSach.TabIndex = 123;
            dgvSach.CellClick += dgvSach_CellClick;
            // 
            // MaSach
            // 
            MaSach.DataPropertyName = "MaSach";
            MaSach.FillWeight = 50F;
            MaSach.HeaderText = "Mã sách";
            MaSach.MinimumWidth = 6;
            MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            TenSach.DataPropertyName = "TenSach";
            TenSach.FillWeight = 175F;
            TenSach.HeaderText = "Tên sách";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            SoLuongTon.FillWeight = 50F;
            SoLuongTon.HeaderText = "Số lượng";
            SoLuongTon.MinimumWidth = 6;
            SoLuongTon.Name = "SoLuongTon";
            // 
            // GiaBan
            // 
            GiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            GiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            GiaBan.FillWeight = 70F;
            GiaBan.HeaderText = "Giá bán";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            // 
            // dgvGioHang
            // 
            dgvGioHang.AllowUserToAddRows = false;
            dgvGioHang.AllowUserToDeleteRows = false;
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Columns.AddRange(new DataGridViewColumn[] { IDSach, nameSach, soLuong, donGia, thanhTien });
            dgvGioHang.Dock = DockStyle.Fill;
            dgvGioHang.Location = new Point(0, 125);
            dgvGioHang.MinimumSize = new Size(826, 231);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.RowHeadersWidth = 51;
            dgvGioHang.ScrollBars = ScrollBars.Vertical;
            dgvGioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGioHang.Size = new Size(860, 231);
            dgvGioHang.TabIndex = 121;
            // 
            // IDSach
            // 
            IDSach.DataPropertyName = "MaSach";
            IDSach.FillWeight = 50F;
            IDSach.HeaderText = "Mã sách";
            IDSach.MinimumWidth = 6;
            IDSach.Name = "IDSach";
            // 
            // nameSach
            // 
            nameSach.DataPropertyName = "TenSach";
            nameSach.FillWeight = 175F;
            nameSach.HeaderText = "Tên sách";
            nameSach.MinimumWidth = 6;
            nameSach.Name = "nameSach";
            // 
            // soLuong
            // 
            soLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            soLuong.DefaultCellStyle = dataGridViewCellStyle2;
            soLuong.FillWeight = 50F;
            soLuong.HeaderText = "Số lượng";
            soLuong.MinimumWidth = 6;
            soLuong.Name = "soLuong";
            // 
            // donGia
            // 
            donGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle3.Format = "N0";
            donGia.DefaultCellStyle = dataGridViewCellStyle3;
            donGia.FillWeight = 55F;
            donGia.HeaderText = "Giá bán";
            donGia.MinimumWidth = 6;
            donGia.Name = "donGia";
            // 
            // thanhTien
            // 
            thanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle4.Format = "N0";
            thanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            thanhTien.FillWeight = 75F;
            thanhTien.HeaderText = "Thành tiền";
            thanhTien.MinimumWidth = 6;
            thanhTien.Name = "thanhTien";
            // 
            // panel5
            // 
            panel5.Controls.Add(numSoLuong);
            panel5.Controls.Add(txtGiaBan);
            panel5.Controls.Add(btnThemGioHang);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txtMaSach);
            panel5.Controls.Add(txtTenSach);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(860, 125);
            panel5.TabIndex = 0;
            // 
            // numSoLuong
            // 
            numSoLuong.Anchor = AnchorStyles.None;
            numSoLuong.Location = new Point(345, 86);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(268, 27);
            numSoLuong.TabIndex = 131;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Anchor = AnchorStyles.None;
            txtGiaBan.Location = new Point(345, 28);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(268, 27);
            txtGiaBan.TabIndex = 130;
            // 
            // btnThemGioHang
            // 
            btnThemGioHang.Anchor = AnchorStyles.None;
            btnThemGioHang.Location = new Point(644, 31);
            btnThemGioHang.Name = "btnThemGioHang";
            btnThemGioHang.Size = new Size(105, 85);
            btnThemGioHang.TabIndex = 122;
            btnThemGioHang.Text = "Thêm Vào Giỏ Hàng";
            btnThemGioHang.UseVisualStyleBackColor = true;
            btnThemGioHang.Click += btnThemGioHang_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(40, 63);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 127;
            label2.Text = "Tên Sách";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(345, 63);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 126;
            label1.Text = "Số Lượng";
            // 
            // label
            // 
            label.Anchor = AnchorStyles.None;
            label.AutoSize = true;
            label.Location = new Point(345, 5);
            label.Name = "label";
            label.Size = new Size(64, 20);
            label.TabIndex = 124;
            label.Text = "Giá Bán ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(40, 3);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 125;
            label6.Text = "Mã Sách";
            // 
            // txtMaSach
            // 
            txtMaSach.Anchor = AnchorStyles.None;
            txtMaSach.Location = new Point(40, 28);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(268, 27);
            txtMaSach.TabIndex = 128;
            // 
            // txtTenSach
            // 
            txtTenSach.Anchor = AnchorStyles.None;
            txtTenSach.Location = new Point(40, 86);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(268, 27);
            txtTenSach.TabIndex = 129;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnThoat);
            panel4.Controls.Add(BtnThanhToan);
            panel4.Controls.Add(btnXoa);
            panel4.Controls.Add(lblThanhTien);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 671);
            panel4.Name = "panel4";
            panel4.Size = new Size(860, 106);
            panel4.TabIndex = 119;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.Location = new Point(724, 64);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 120;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // BtnThanhToan
            // 
            BtnThanhToan.Anchor = AnchorStyles.None;
            BtnThanhToan.Location = new Point(609, 64);
            BtnThanhToan.Name = "BtnThanhToan";
            BtnThanhToan.Size = new Size(94, 29);
            BtnThanhToan.TabIndex = 119;
            BtnThanhToan.Text = "Thanh Toán";
            BtnThanhToan.UseVisualStyleBackColor = true;
            BtnThanhToan.Click += BtnThanhToan_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Location = new Point(41, 64);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(169, 29);
            btnXoa.TabIndex = 57;
            btnXoa.Text = "Xóa Khỏi Giỏ Hàng";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lblThanhTien
            // 
            lblThanhTien.Anchor = AnchorStyles.None;
            lblThanhTien.AutoSize = true;
            lblThanhTien.Location = new Point(268, 26);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(40, 20);
            lblThanhTien.TabIndex = 53;
            lblThanhTien.Text = "VND";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 17);
            label3.Name = "label3";
            label3.Size = new Size(126, 31);
            label3.TabIndex = 54;
            label3.Text = "Thanh Tiền";
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnTimKiem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 52);
            panel1.TabIndex = 106;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(38, 16);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 52;
            label7.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.ForeColor = Color.Black;
            txtTimKiem.Location = new Point(129, 13);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(494, 27);
            txtTimKiem.TabIndex = 55;
            txtTimKiem.Enter += txtTimKiem_Enter;
            txtTimKiem.Leave += txtTimKiem_Leave;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.Location = new Point(642, 12);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(105, 29);
            btnTimKiem.TabIndex = 56;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeight = 29;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenKH, SoDienThoai, DiemTichLuy });
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 96);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.ScrollBars = ScrollBars.Vertical;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(379, 575);
            dgvKhachHang.TabIndex = 108;
            // 
            // MaKH
            // 
            MaKH.DataPropertyName = "MaKH";
            MaKH.HeaderText = "Mã KH";
            MaKH.MinimumWidth = 6;
            MaKH.Name = "MaKH";
            MaKH.ReadOnly = true;
            // 
            // TenKH
            // 
            TenKH.DataPropertyName = "TenKH";
            TenKH.HeaderText = "Tên KH";
            TenKH.MinimumWidth = 6;
            TenKH.Name = "TenKH";
            TenKH.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SDT";
            SoDienThoai.HeaderText = "SDT";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.ReadOnly = true;
            // 
            // DiemTichLuy
            // 
            DiemTichLuy.DataPropertyName = "DiemTichLuy";
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            DiemTichLuy.DefaultCellStyle = dataGridViewCellStyle5;
            DiemTichLuy.HeaderText = "Điểm Tích Lũy";
            DiemTichLuy.MinimumWidth = 6;
            DiemTichLuy.Name = "DiemTichLuy";
            DiemTichLuy.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnTimSDT);
            panel2.Controls.Add(txtTimSDT);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 96);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(3, 39);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 58;
            label4.Text = "Tìm Kiếm";
            // 
            // btnTimSDT
            // 
            btnTimSDT.Anchor = AnchorStyles.None;
            btnTimSDT.Location = new Point(300, 35);
            btnTimSDT.Name = "btnTimSDT";
            btnTimSDT.Size = new Size(67, 29);
            btnTimSDT.TabIndex = 59;
            btnTimSDT.Text = "Tìm";
            btnTimSDT.UseVisualStyleBackColor = true;
            btnTimSDT.Click += btnTimSDT_Click;
            // 
            // txtTimSDT
            // 
            txtTimSDT.Anchor = AnchorStyles.None;
            txtTimSDT.ForeColor = SystemColors.ControlDark;
            txtTimSDT.Location = new Point(81, 35);
            txtTimSDT.Name = "txtTimSDT";
            txtTimSDT.Size = new Size(213, 27);
            txtTimSDT.TabIndex = 60;
            txtTimSDT.Enter += txtTimSDT_Enter;
            txtTimSDT.Leave += txtTimSDT_Leave;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnThem);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 671);
            panel3.Name = "panel3";
            panel3.Size = new Size(379, 106);
            panel3.TabIndex = 109;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.Location = new Point(118, 17);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(148, 29);
            btnThem.TabIndex = 60;
            btnThem.Text = "Thêm Khách Hàng";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 777);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(1211, 824);
            Name = "BanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán Hàng";
            Load += BanHang_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn TenDanhMuc;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label label7;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnThem;
        private Button btnXoa;
        private Label label3;
        private Label lblThanhTien;
        private Panel panel3;
        private Panel panel2;
        public DataGridView dgvKhachHang;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn DiemTichLuy;
        private SplitContainer splitContainer2;
        private DataGridView dgvSach;
        private DataGridView dgvGioHang;
        private Panel panel5;
        private NumericUpDown numSoLuong;
        private TextBox txtGiaBan;
        private Button btnThemGioHang;
        private Label label2;
        private Label label1;
        private Label label;
        private Label label6;
        private TextBox txtMaSach;
        private TextBox txtTenSach;
        private Panel panel4;
        private Button btnThoat;
        private Button BtnThanhToan;
        private Label label4;
        private Button btnTimSDT;
        private TextBox txtTimSDT;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn IDSach;
        private DataGridViewTextBoxColumn nameSach;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn donGia;
        private DataGridViewTextBoxColumn thanhTien;
    }
}