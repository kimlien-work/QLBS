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
            panel2 = new Panel();
            numSoLuong = new NumericUpDown();
            btnThemGiohang = new Button();
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
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(lblThanhTien);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(BtnThanhToan);
            panel3.Controls.Add(btnHuy);
            panel3.Controls.Add(btnXoa);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 598);
            panel3.Name = "panel3";
            panel3.Size = new Size(746, 110);
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
            dgvSach.Size = new Size(746, 217);
            dgvSach.TabIndex = 0;
            dgvSach.CellClick += dgvSach_CellClick;
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
            dgvGioHang.Location = new Point(0, 338);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.RowHeadersWidth = 51;
            dgvGioHang.Size = new Size(746, 260);
            dgvGioHang.TabIndex = 3;
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
            dataGridViewCellStyle2.Format = "N0";
            price.DefaultCellStyle = dataGridViewCellStyle2;
            price.HeaderText = "Đơn Giá ";
            price.MinimumWidth = 6;
            price.Name = "price";
            // 
            // thtien
            // 
            thtien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Format = "N0";
            thtien.DefaultCellStyle = dataGridViewCellStyle3;
            thtien.HeaderText = "Thành Tiền";
            thtien.MinimumWidth = 6;
            thtien.Name = "thtien";
            // 
            // panel2
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
            panel2.Size = new Size(746, 80);
            panel2.TabIndex = 4;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(399, 11);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(211, 27);
            numSoLuong.TabIndex = 14;
            // 
            // btnThemGiohang
            // 
            btnThemGiohang.Location = new Point(632, 11);
            btnThemGiohang.Name = "btnThemGiohang";
            btnThemGiohang.Size = new Size(102, 57);
            btnThemGiohang.TabIndex = 5;
            btnThemGiohang.Text = "Thêm Vào Giỏ Hàng";
            btnThemGiohang.UseVisualStyleBackColor = true;
            btnThemGiohang.Click += btnThemGiohang_Click_1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(321, 44);
            label.Name = "label";
            label.Size = new Size(64, 20);
            label.TabIndex = 10;
            label.Text = "Giá Bán ";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(399, 41);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(211, 27);
            txtGiaBan.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 11);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 11;
            label4.Tag = "";
            label4.Text = "Số Lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 11);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 6;
            label6.Text = "Mã Sách";
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(84, 8);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(229, 27);
            txtMaSach.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 44);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 7;
            label1.Text = "Tên Sách";
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(84, 41);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(229, 27);
            txtTenSach.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 41);
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
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 708);
            Controls.Add(panel2);
            Controls.Add(dgvGioHang);
            Controls.Add(dgvSach);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BanHang";
            Text = "Bán Hàng";
            Load += BanHang_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private DataGridView dgvSach;
        private DataGridView dgvGioHang;
        private Panel panel2;
        private Panel panel1;
        private Button btnTimKiem;
        private Label label2;
        private TextBox txtTimKiem;
        private Label label6;
        private TextBox txtMaSach;
        private Label label1;
        private TextBox txtTenSach;
        private Label label;
        private TextBox txtGiaBan;
        private Label label4;
        private Button BtnThanhToan;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnThemGiohang;
        private Label lblThanhTien;
        private Label label3;
        private NumericUpDown numSoLuong;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn TenDanhMuc;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridViewTextBoxColumn idsach;
        private DataGridViewTextBoxColumn namesach;
        private DataGridViewTextBoxColumn slsach;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn thtien;
    }
}