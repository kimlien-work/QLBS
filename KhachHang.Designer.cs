namespace QLBS
{
    partial class KhachHang
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
            splitContainer1 = new SplitContainer();
            txtTenKH = new TextBox();
            btnThoat = new Button();
            label1 = new Label();
            txtSDT = new TextBox();
            label = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            btnSua = new Button();
            txtDiaChi = new TextBox();
            btnHuy = new Button();
            txtDiemTichLuy = new TextBox();
            btnThem = new Button();
            txtMaKH = new TextBox();
            btnLuu = new Button();
            btnXoa = new Button();
            dgvKhachHang = new DataGridView();
            MaKH = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            Diem = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            panel1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(txtTenKH);
            splitContainer1.Panel1.Controls.Add(btnThoat);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txtSDT);
            splitContainer1.Panel1.Controls.Add(label);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(txtEmail);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(btnSua);
            splitContainer1.Panel1.Controls.Add(txtDiaChi);
            splitContainer1.Panel1.Controls.Add(btnHuy);
            splitContainer1.Panel1.Controls.Add(txtDiemTichLuy);
            splitContainer1.Panel1.Controls.Add(btnThem);
            splitContainer1.Panel1.Controls.Add(txtMaKH);
            splitContainer1.Panel1.Controls.Add(btnLuu);
            splitContainer1.Panel1.Controls.Add(btnXoa);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvKhachHang);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1088, 473);
            splitContainer1.SplitterDistance = 306;
            splitContainer1.TabIndex = 0;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(19, 95);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(268, 27);
            txtTenKH.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(207, 433);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(79, 29);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 72);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 41;
            label1.Text = "Tên Khách Hàng";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(19, 161);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(268, 27);
            txtSDT.TabIndex = 2;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(19, 204);
            label.Name = "label";
            label.Size = new Size(102, 20);
            label.TabIndex = 36;
            label.Text = "Điểm Tích Lũy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 138);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 39;
            label4.Tag = "";
            label4.Text = "Số Điện Thoại";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(19, 354);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 27);
            txtEmail.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 5);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 37;
            label6.Text = "Mã Khách Hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 331);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 270);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 38;
            label3.Text = "Đia Chỉ";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(112, 401);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 29);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(19, 293);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(268, 27);
            txtDiaChi.TabIndex = 4;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(112, 433);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(80, 29);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // txtDiemTichLuy
            // 
            txtDiemTichLuy.Location = new Point(19, 227);
            txtDiemTichLuy.Name = "txtDiemTichLuy";
            txtDiemTichLuy.ReadOnly = true;
            txtDiemTichLuy.Size = new Size(268, 27);
            txtDiemTichLuy.TabIndex = 3;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(19, 401);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(76, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(19, 29);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(268, 27);
            txtMaKH.TabIndex = 0;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(19, 433);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(74, 29);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(209, 401);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(78, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeight = 29;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenKH, SoDienThoai, Diem, DiaChi, Email });
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 70);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.ScrollBars = ScrollBars.Vertical;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(778, 403);
            dgvKhachHang.TabIndex = 32;
            // 
            // MaKH
            // 
            MaKH.DataPropertyName = "MaKH";
            MaKH.FillWeight = 50F;
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
            SoDienThoai.FillWeight = 85F;
            SoDienThoai.HeaderText = "Số Điện Thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.ReadOnly = true;
            // 
            // Diem
            // 
            Diem.DataPropertyName = "DiemTichLuy";
            Diem.FillWeight = 65F;
            Diem.HeaderText = "Điểm Tích Lũy";
            Diem.MinimumWidth = 6;
            Diem.Name = "Diem";
            Diem.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.FillWeight = 125F;
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.FillWeight = 105F;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 70);
            panel1.TabIndex = 36;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.Location = new Point(638, 21);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(117, 29);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tim Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.ForeColor = SystemColors.ControlDark;
            txtTimKiem.Location = new Point(114, 22);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(506, 27);
            txtTimKiem.TabIndex = 12;
            txtTimKiem.Enter += txtTimKiem_Enter;
            txtTimKiem.Leave += txtTimKiem_Leave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(24, 25);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 33;
            label2.Text = "Tìm Kiếm";
            // 
            // KhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 473);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(1106, 520);
            Name = "KhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "0";
            Text = "Khách Hàng";
            Load += KhachHang_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        public TextBox txtTenKH;
        private Button btnThoat;
        private Label label1;
        public TextBox txtSDT;
        private Label label;
        private Label label4;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private Label label3;
        private Button btnSua;
        private TextBox txtDiaChi;
        private Button btnHuy;
        public TextBox txtDiemTichLuy;
        private Button btnThem;
        public TextBox txtMaKH;
        private Button btnLuu;
        private Button btnXoa;
        public DataGridView dgvKhachHang;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn Diem;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn Email;
        private Panel panel1;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label2;
    }
}