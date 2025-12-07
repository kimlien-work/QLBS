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
            btnTimKiem = new Button();
            btnTichDiem = new Button();
            txtTimKiem = new TextBox();
            label7 = new Label();
            lblThanhTien = new Label();
            label3 = new Label();
            BtnThanhToan = new Button();
            btnHuy = new Button();
            btnXoa = new Button();
            dgvGioHang = new DataGridView();
            idsach = new DataGridViewTextBoxColumn();
            namesach = new DataGridViewTextBoxColumn();
            slsach = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            thtien = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            btnThem = new Button();
            dgvKhachHang = new DataGridView();
            MaKH = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            DiemTichLuy = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label4 = new Label();
            txtTimSDT = new TextBox();
            btnTimSDT = new Button();
            panel4 = new Panel();
            dgvSach = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            numSoLuong = new NumericUpDown();
            label = new Label();
            txtMaSach = new TextBox();
            txtTenSach = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtGiaBan = new TextBox();
            btnThemGioHang = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(602, 10);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(140, 29);
            btnTimKiem.TabIndex = 56;
            btnTimKiem.Text = "Tim Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnTichDiem
            // 
            btnTichDiem.Location = new Point(547, 26);
            btnTichDiem.Name = "btnTichDiem";
            btnTichDiem.Size = new Size(94, 58);
            btnTichDiem.TabIndex = 60;
            btnTichDiem.Text = "Tích Điểm";
            btnTichDiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.ForeColor = SystemColors.ControlDark;
            txtTimKiem.Location = new Point(102, 11);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(494, 27);
            txtTimKiem.TabIndex = 55;
            txtTimKiem.Text = "Nhập Tên Sách Cần Mua";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 14);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 52;
            label7.Text = "Tìm Kiếm";
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Location = new Point(184, 26);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(40, 20);
            lblThanhTien.TabIndex = 53;
            lblThanhTien.Text = "VND";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 15);
            label3.Name = "label3";
            label3.Size = new Size(126, 31);
            label3.TabIndex = 54;
            label3.Text = "Thanh Tiền";
            // 
            // BtnThanhToan
            // 
            BtnThanhToan.Location = new Point(647, 26);
            BtnThanhToan.Name = "BtnThanhToan";
            BtnThanhToan.Size = new Size(94, 58);
            BtnThanhToan.TabIndex = 59;
            BtnThanhToan.Text = "Thanh Toán";
            BtnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(62, 558);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 58);
            btnHuy.TabIndex = 58;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(15, 55);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(169, 29);
            btnXoa.TabIndex = 57;
            btnXoa.Text = "Xóa Khỏi Giỏ Hàng";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // dgvGioHang
            // 
            dgvGioHang.AllowUserToAddRows = false;
            dgvGioHang.AllowUserToDeleteRows = false;
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Columns.AddRange(new DataGridViewColumn[] { idsach, namesach, slsach, price, thtien });
            dgvGioHang.Dock = DockStyle.Bottom;
            dgvGioHang.Location = new Point(0, 354);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.RowHeadersWidth = 51;
            dgvGioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGioHang.Size = new Size(756, 296);
            dgvGioHang.TabIndex = 43;
            // 
            // idsach
            // 
            idsach.DataPropertyName = "MaSach";
            idsach.HeaderText = "Mã Sách";
            idsach.MinimumWidth = 6;
            idsach.Name = "idsach";
            // 
            // namesach
            // 
            namesach.DataPropertyName = "TenSach";
            namesach.HeaderText = "Tên Sách";
            namesach.MinimumWidth = 6;
            namesach.Name = "namesach";
            // 
            // slsach
            // 
            slsach.DataPropertyName = "SoLuong";
            slsach.HeaderText = "Số Lượng";
            slsach.MinimumWidth = 6;
            slsach.Name = "slsach";
            // 
            // price
            // 
            price.DataPropertyName = "DonGia";
            price.HeaderText = "Đơn Giá ";
            price.MinimumWidth = 6;
            price.Name = "price";
            // 
            // thtien
            // 
            thtien.DataPropertyName = "ThanhTien";
            thtien.HeaderText = "Thành Tiền";
            thtien.MinimumWidth = 6;
            thtien.Name = "thtien";
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnTimKiem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 52);
            panel1.TabIndex = 61;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHuy);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(dgvKhachHang);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(756, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(341, 750);
            panel2.TabIndex = 62;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(186, 558);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 58);
            btnThem.TabIndex = 60;
            btnThem.Text = "Thêm Khách Hàng";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeight = 29;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenKH, SoDienThoai, DiemTichLuy });
            dgvKhachHang.Dock = DockStyle.Top;
            dgvKhachHang.Location = new Point(0, 95);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(341, 437);
            dgvKhachHang.TabIndex = 64;
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
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            DiemTichLuy.DefaultCellStyle = dataGridViewCellStyle1;
            DiemTichLuy.HeaderText = "Điểm Tích Lũy";
            DiemTichLuy.MinimumWidth = 6;
            DiemTichLuy.Name = "DiemTichLuy";
            DiemTichLuy.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtTimSDT);
            panel3.Controls.Add(btnTimSDT);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(341, 95);
            panel3.TabIndex = 63;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 44);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 56;
            label4.Text = "Tìm Kiếm";
            // 
            // txtTimSDT
            // 
            txtTimSDT.ForeColor = SystemColors.ControlDark;
            txtTimSDT.Location = new Point(103, 41);
            txtTimSDT.Name = "txtTimSDT";
            txtTimSDT.Size = new Size(148, 27);
            txtTimSDT.TabIndex = 57;
            txtTimSDT.Text = "Nhập SDT";
            // 
            // btnTimSDT
            // 
            btnTimSDT.Location = new Point(257, 40);
            btnTimSDT.Name = "btnTimSDT";
            btnTimSDT.Size = new Size(67, 29);
            btnTimSDT.TabIndex = 56;
            btnTimSDT.Text = "Tim";
            btnTimSDT.UseVisualStyleBackColor = true;
            btnTimSDT.Click += btnTimSDT_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(BtnThanhToan);
            panel4.Controls.Add(btnXoa);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(lblThanhTien);
            panel4.Controls.Add(btnTichDiem);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 650);
            panel4.Name = "panel4";
            panel4.Size = new Size(756, 100);
            panel4.TabIndex = 64;
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, GiaBan, SoLuongTon });
            dgvSach.Dock = DockStyle.Top;
            dgvSach.Location = new Point(0, 52);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(756, 183);
            dgvSach.TabIndex = 65;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "MaSach";
            dataGridViewTextBoxColumn1.HeaderText = "Mã Sách";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "TenSach";
            dataGridViewTextBoxColumn2.HeaderText = "Tên Sách";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // GiaBan
            // 
            GiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            GiaBan.DefaultCellStyle = dataGridViewCellStyle2;
            GiaBan.HeaderText = "Đơn Giá";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            SoLuongTon.HeaderText = "Số Lượng";
            SoLuongTon.MinimumWidth = 6;
            SoLuongTon.Name = "SoLuongTon";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(329, 321);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(268, 27);
            numSoLuong.TabIndex = 73;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(329, 240);
            label.Name = "label";
            label.Size = new Size(64, 20);
            label.TabIndex = 66;
            label.Text = "Giá Bán ";
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(24, 263);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(268, 27);
            txtMaSach.TabIndex = 70;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(24, 321);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(268, 27);
            txtTenSach.TabIndex = 71;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 238);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 67;
            label6.Text = "Mã Sách";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 298);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 68;
            label1.Text = "Số Lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 298);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 69;
            label2.Text = "Tên Sách";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(329, 263);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(268, 27);
            txtGiaBan.TabIndex = 72;
            // 
            // btnThemGioHang
            // 
            btnThemGioHang.Location = new Point(604, 263);
            btnThemGioHang.Name = "btnThemGioHang";
            btnThemGioHang.Size = new Size(138, 69);
            btnThemGioHang.TabIndex = 57;
            btnThemGioHang.Text = "Thêm Vào Giỏ Hàng";
            btnThemGioHang.UseVisualStyleBackColor = true;
            btnThemGioHang.Click += btnThemGioHang_Click_1;
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 750);
            Controls.Add(numSoLuong);
            Controls.Add(btnThemGioHang);
            Controls.Add(label);
            Controls.Add(txtMaSach);
            Controls.Add(txtTenSach);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtGiaBan);
            Controls.Add(dgvSach);
            Controls.Add(panel1);
            Controls.Add(dgvGioHang);
            Controls.Add(panel4);
            Controls.Add(panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán Hàng";
            Load += BanHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn TenDanhMuc;
        private Button btnTimKiem;
        private Button btnTichDiem;
        private TextBox txtTimKiem;
        private Label label7;
        private Label lblThanhTien;
        private Label label3;
        private Button BtnThanhToan;
        private Button btnHuy;
        private Button btnXoa;
        private DataGridView dgvGioHang;
        private DataGridViewTextBoxColumn idsach;
        private DataGridViewTextBoxColumn namesach;
        private DataGridViewTextBoxColumn slsach;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn thtien;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dgvSach;
        private NumericUpDown numSoLuong;
        private Label label;
        private TextBox txtMaSach;
        private TextBox txtTenSach;
        private Label label6;
        private Label label1;
        private Label label2;
        private TextBox txtGiaBan;
        private Button btnThemGioHang;
        private Label label4;
        private TextBox txtTimSDT;
        private Button btnTimSDT;
        public DataGridView dgvKhachHang;
        private Button btnThem;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn DiemTichLuy;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn SoLuongTon;
    }
}