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
            button1 = new Button();
            btnTichDiem = new Button();
            textBox5 = new TextBox();
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
            panel3 = new Panel();
            panel4 = new Panel();
            dgvSach = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            numSoLuong = new NumericUpDown();
            label = new Label();
            txtMaSach = new TextBox();
            txtTenSach = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtGiaBan = new TextBox();
            btnThemGioHang = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            btnTim = new Button();
            dgvKhachHang = new DataGridView();
            MaKH = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label8 = new Label();
            txtDiaChi = new TextBox();
            txtMaKH = new TextBox();
            label9 = new Label();
            txtEmail = new TextBox();
            label10 = new Label();
            txtTenKH = new TextBox();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(602, 10);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 56;
            button1.Text = "Tim Kiếm";
            button1.UseVisualStyleBackColor = true;
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
            // textBox5
            // 
            textBox5.ForeColor = SystemColors.ControlDark;
            textBox5.Location = new Point(102, 11);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(494, 27);
            textBox5.TabIndex = 55;
            textBox5.Text = "Nhập Tên Sách Cần Mua";
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
            btnHuy.Location = new Point(129, 676);
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
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 52);
            panel1.TabIndex = 61;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(txtMaKH);
            panel2.Controls.Add(btnHuy);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtTenKH);
            panel2.Controls.Add(dgvKhachHang);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(756, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(341, 750);
            panel2.TabIndex = 62;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(btnTim);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(341, 95);
            panel3.TabIndex = 63;
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
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvSach.Dock = DockStyle.Top;
            dgvSach.Location = new Point(0, 52);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
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
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "SoLuong";
            dataGridViewTextBoxColumn3.HeaderText = "Số Lượng";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "DonGia";
            dataGridViewTextBoxColumn4.HeaderText = "Đơn Giá ";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "ThanhTien";
            dataGridViewTextBoxColumn5.HeaderText = "Thành Tiền";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
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
            btnThemGioHang.Location = new Point(603, 263);
            btnThemGioHang.Name = "btnThemGioHang";
            btnThemGioHang.Size = new Size(138, 85);
            btnThemGioHang.TabIndex = 57;
            btnThemGioHang.Text = "Xóa Khỏi Giỏ Hàng";
            btnThemGioHang.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ControlDark;
            textBox1.Location = new Point(103, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 27);
            textBox1.TabIndex = 57;
            textBox1.Text = "Nhập SDT";
            // 
            // btnTim
            // 
            btnTim.Location = new Point(257, 40);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(67, 29);
            btnTim.TabIndex = 56;
            btnTim.Text = "Tim";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeight = 29;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenKH, SoDienThoai });
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 538);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 65;
            label5.Text = "Mã Khách Hàng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 605);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 66;
            label8.Text = "Đia Chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(144, 604);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(185, 27);
            txtDiaChi.TabIndex = 71;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(144, 538);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(185, 27);
            txtMaKH.TabIndex = 69;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 638);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 67;
            label9.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(144, 637);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(185, 27);
            txtEmail.TabIndex = 72;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 572);
            label10.Name = "label10";
            label10.Size = new Size(116, 20);
            label10.TabIndex = 68;
            label10.Text = "Tên Khách Hàng";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(144, 571);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(185, 27);
            txtTenKH.TabIndex = 70;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(229, 676);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 58);
            btnThem.TabIndex = 60;
            btnThem.Text = "Thêm Khách Hàng";
            btnThem.UseVisualStyleBackColor = true;
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
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn TenDanhMuc;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn SoLuongTon;
        private Button button1;
        private Button btnTichDiem;
        private TextBox textBox5;
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
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
        private TextBox textBox1;
        private Button btnTim;
        public DataGridView dgvKhachHang;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn SoDienThoai;
        private Label label5;
        private Label label8;
        private TextBox txtDiaChi;
        public TextBox txtMaKH;
        private Label label9;
        private TextBox txtEmail;
        private Label label10;
        public TextBox txtTenKH;
        private Button btnThem;
    }
}