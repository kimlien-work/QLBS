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
            panel3 = new Panel();
            lblThanhTien = new Label();
            label3 = new Label();
            BtnThanhToan = new Button();
            btnHuy = new Button();
            btnXoa = new Button();
            panel1 = new Panel();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dgvSach = new DataGridView();
            MaSach = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            TenDanhMuc = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            dgvGioHang = new DataGridView();
            idsach = new DataGridViewTextBoxColumn();
            namesach = new DataGridViewTextBoxColumn();
            slsach = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            thtien = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            numSoLuong = new NumericUpDown();
            label = new Label();
            txtGiaBan = new TextBox();
            label4 = new Label();
            label6 = new Label();
            txtMaSach = new TextBox();
            label1 = new Label();
            txtTenSach = new TextBox();
            panel1 = new Panel();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label2 = new Label();
            btnTichDiem = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(btnTichDiem);
            panel3.Controls.Add(lblThanhTien);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(BtnThanhToan);
            panel3.Controls.Add(btnHuy);
            panel3.Controls.Add(btnXoa);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 608);
            panel3.Name = "panel3";
            panel3.Size = new Size(757, 110);
            panel3.TabIndex = 2;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Location = new Point(183, 32);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(40, 20);
            lblThanhTien.TabIndex = 3;
            lblThanhTien.Text = "VND";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 21);
            label3.Name = "label3";
            label3.Size = new Size(126, 31);
            label3.TabIndex = 3;
            label3.Text = "Thanh Tiền";
            // 
            // BtnThanhToan
            // 
            BtnThanhToan.Location = new Point(540, 61);
            BtnThanhToan.Name = "BtnThanhToan";
            BtnThanhToan.Size = new Size(94, 29);
            BtnThanhToan.TabIndex = 7;
            BtnThanhToan.Text = "Thanh Toán";
            BtnThanhToan.UseVisualStyleBackColor = true;
            BtnThanhToan.Click += BtnThanhToan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(640, 61);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(14, 61);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(169, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa Khỏi Giỏ Hàng";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 41);
            panel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(592, 6);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(140, 29);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tim Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.ForeColor = SystemColors.ControlDark;
            txtTimKiem.Location = new Point(92, 7);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(494, 27);
            txtTimKiem.TabIndex = 4;
            txtTimKiem.Text = "Nhập Tên Sách Cần Mua";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 10);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Tìm Kiếm";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvKhachHang);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(757, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 709);
            panel2.TabIndex = 3;
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { MaSach, TenSach, TenDanhMuc, GiaBan, SoLuongTon });
            dgvSach.Dock = DockStyle.Top;
            dgvSach.Location = new Point(0, 41);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(757, 217);
            dgvSach.TabIndex = 24;
            // 
            // MaSach
            // 
            MaSach.DataPropertyName = "MaSach";
            MaSach.HeaderText = "Mã Sách";
            MaSach.MinimumWidth = 6;
            MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            TenSach.DataPropertyName = "TenSach";
            TenSach.HeaderText = "Tên Sách";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            // 
            // TenDanhMuc
            // 
            TenDanhMuc.DataPropertyName = "TenDanhMuc";
            TenDanhMuc.HeaderText = "Danh Mục";
            TenDanhMuc.MinimumWidth = 6;
            TenDanhMuc.Name = "TenDanhMuc";
            // 
            // GiaBan
            // 
            GiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle1.Format = "N0";
            GiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            GiaBan.HeaderText = "Giá Bán";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            SoLuongTon.HeaderText = "Tồn Kho";
            SoLuongTon.MinimumWidth = 6;
            SoLuongTon.Name = "SoLuongTon";
            // 
            // dgvGioHang
            // 
            dgvGioHang.AllowUserToAddRows = false;
            dgvGioHang.AllowUserToDeleteRows = false;
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Columns.AddRange(new DataGridViewColumn[] { idsach, namesach, slsach, price, thtien });
            dgvGioHang.Dock = DockStyle.Bottom;
            dgvGioHang.Location = new Point(0, 348);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.RowHeadersWidth = 51;
            dgvGioHang.Size = new Size(757, 260);
            dgvGioHang.TabIndex = 25;
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
            dataGridViewCellStyle8.Format = "N0";
            price.DefaultCellStyle = dataGridViewCellStyle8;
            price.HeaderText = "Đơn Giá ";
            price.MinimumWidth = 6;
            price.Name = "price";
            // 
            // thtien
            // 
            thtien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle9.Format = "N0";
            thtien.DefaultCellStyle = dataGridViewCellStyle9;
            thtien.HeaderText = "Thành Tiền";
            thtien.MinimumWidth = 6;
            thtien.Name = "thtien";
            // 
            // panel4
            // 
            panel2.Controls.Add(numSoLuong);
            panel2.Controls.Add(btnThemGiohang);
            panel2.Controls.Add(label);
            panel2.Controls.Add(txtGiaBan);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtMaSach);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtTenSach);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 258);
            panel2.Name = "panel2";
            panel2.Size = new Size(746, 90);
            panel2.TabIndex = 4;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(462, 13);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(211, 27);
            numSoLuong.TabIndex = 30;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(384, 46);
            label.Name = "label";
            label.Size = new Size(64, 20);
            label.TabIndex = 27;
            label.Text = "Giá Bán ";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(462, 43);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(211, 27);
            txtGiaBan.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(384, 13);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 28;
            label4.Tag = "";
            label4.Text = "Số Lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 13);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 23;
            label6.Text = "Mã Sách";
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(147, 10);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(229, 27);
            txtMaSach.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 46);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 24;
            label1.Text = "Tên Sách";
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(147, 43);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(229, 27);
            txtTenSach.TabIndex = 26;
            // 
            // btnKhongTichDiem
            // 
            btnKhongTichDiem.Location = new Point(17, 12);
            btnKhongTichDiem.Name = "btnKhongTichDiem";
            btnKhongTichDiem.Size = new Size(189, 73);
            btnKhongTichDiem.TabIndex = 0;
            btnKhongTichDiem.Text = "Không Tích Điểm";
            btnKhongTichDiem.UseVisualStyleBackColor = true;
            // 
            // btnTichDiem
            // 
            btnTichDiem.Location = new Point(212, 12);
            btnTichDiem.Name = "btnTichDiem";
            btnTichDiem.Size = new Size(190, 72);
            btnTichDiem.TabIndex = 1;
            btnTichDiem.Text = "Tích Điểm";
            btnTichDiem.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnKhongTichDiem);
            panel6.Controls.Add(btnTichDiem);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(414, 95);
            panel6.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnTimSDT);
            panel5.Controls.Add(txtTimSDT);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 95);
            panel5.Name = "panel5";
            panel5.Size = new Size(414, 41);
            panel5.TabIndex = 4;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.Location = new Point(248, 177);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(154, 37);
            btnThemKhachHang.TabIndex = 8;
            btnThemKhachHang.Text = "Thêm Khách Hàng";
            btnThemKhachHang.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnHuyThem);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(txtDiaChi);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(txtEmail);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(txtSDT);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(txtTenKH);
            panel7.Controls.Add(btnThemKhachHang);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 489);
            panel7.Name = "panel7";
            panel7.Size = new Size(414, 220);
            panel7.TabIndex = 5;
            // 
            // txtTimSDT
            // 
            txtTimSDT.ForeColor = SystemColors.ControlDark;
            txtTimSDT.Location = new Point(17, 7);
            txtTimSDT.Name = "txtTimSDT";
            txtTimSDT.Size = new Size(239, 27);
            txtTimSDT.TabIndex = 7;
            txtTimSDT.Text = "Nhập SĐT";
            // 
            // btnTimSDT
            // 
            btnTimSDT.Location = new Point(262, 6);
            btnTimSDT.Name = "btnTimSDT";
            btnTimSDT.Size = new Size(140, 29);
            btnTimSDT.TabIndex = 8;
            btnTimSDT.Text = "Tim";
            btnTimSDT.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 59);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
            label8.TabIndex = 31;
            label8.Tag = "";
            label8.Text = "Số Điện Thoại(*)";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(134, 56);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(268, 27);
            txtSDT.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 20);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 32;
            label9.Text = "Tên KH(*)";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(134, 17);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(268, 27);
            txtTenKH.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 98);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 35;
            label5.Text = "Đia Chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.ForeColor = SystemColors.ControlDark;
            txtDiaChi.Location = new Point(134, 95);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(268, 27);
            txtDiaChi.TabIndex = 37;
            txtDiaChi.Text = "Không bát buộc";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 137);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 36;
            label7.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = SystemColors.ControlDark;
            txtEmail.Location = new Point(134, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 27);
            txtEmail.TabIndex = 38;
            txtEmail.Text = "Không bát buộc";
            // 
            // btnTichDiem
            // 
            btnTichDiem.Location = new Point(440, 61);
            btnTichDiem.Name = "btnTichDiem";
            btnTichDiem.Size = new Size(94, 29);
            btnTichDiem.TabIndex = 8;
            btnTichDiem.Text = "Tích Điểm";
            btnTichDiem.UseVisualStyleBackColor = true;
            btnTichDiem.Click += btnTichDiem_Click;
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 718);
            Controls.Add(panel2);
            Controls.Add(dgvGioHang);
            Controls.Add(dgvSach);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán Hàng";
            Load += BanHang_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Panel panel1;
        private Button btnTimKiem;
        private Label label2;
        private TextBox txtTimKiem;
        private Button BtnThanhToan;
        private Button btnHuy;
        private Button btnXoa;
        private Label lblThanhTien;
        private Label label3;
        private Panel panel2;
        private DataGridView dgvSach;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn TenDanhMuc;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridView dgvGioHang;
        private DataGridViewTextBoxColumn idsach;
        private DataGridViewTextBoxColumn namesach;
        private DataGridViewTextBoxColumn slsach;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn thtien;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn TenDanhMuc;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn SoLuongTon;
        private Button btnTichDiem;
    }
}