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
            panel2 = new Panel();
            panel3 = new Panel();
            btnTimKiem = new Button();
            label2 = new Label();
            txtTimKiem = new TextBox();
            dgvKhachHang = new DataGridView();
            MaKH = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            Diem = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            txtTenKH = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label = new Label();
            label6 = new Label();
            label3 = new Label();
            txtDiaChi = new TextBox();
            txtDiemTichLuy = new TextBox();
            txtMaKH = new TextBox();
            btnXoa = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnHuy = new Button();
            btnSua = new Button();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtSDT = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgvKhachHang);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(287, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 477);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnTimKiem);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtTimKiem);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 437);
            panel3.Name = "panel3";
            panel3.Size = new Size(802, 40);
            panel3.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(616, 5);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(140, 29);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tim Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 8);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.ForeColor = SystemColors.ControlDark;
            txtTimKiem.Location = new Point(116, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(494, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.Text = "Nhập Tên Khách Hàng Cần Tìm";
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeight = 29;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenKH, SoDienThoai, Diem, DiaChi, Email });
            dgvKhachHang.Dock = DockStyle.Top;
            dgvKhachHang.Location = new Point(0, 0);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(802, 437);
            dgvKhachHang.TabIndex = 0;
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
            // Diem
            // 
            Diem.DataPropertyName = "DiemTichLuy";
            Diem.HeaderText = "Điểm Thành Viên";
            Diem.MinimumWidth = 6;
            Diem.Name = "Diem";
            Diem.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(12, 98);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(268, 27);
            txtTenKH.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Khách Hàng";
            // 
            // panel1
            // 
            panel1.Controls.Add(label);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtDiemTichLuy);
            panel1.Controls.Add(txtMaKH);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTenKH);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 477);
            panel1.TabIndex = 0;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 207);
            label.Name = "label";
            label.Size = new Size(102, 20);
            label.TabIndex = 0;
            label.Text = "Điểm Tích Lũy";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 8);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 0;
            label6.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 273);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 0;
            label3.Text = "Đia Chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(12, 296);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(268, 27);
            txtDiaChi.TabIndex = 8;
            // 
            // txtDiemTichLuy
            // 
            txtDiemTichLuy.Location = new Point(12, 230);
            txtDiemTichLuy.Name = "txtDiemTichLuy";
            txtDiemTichLuy.ReadOnly = true;
            txtDiemTichLuy.Size = new Size(268, 27);
            txtDiemTichLuy.TabIndex = 7;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(12, 32);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(268, 27);
            txtMaKH.TabIndex = 4;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(202, 404);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(78, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(14, 436);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(119, 29);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 404);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(76, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(172, 436);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(108, 29);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(105, 404);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 339);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 0;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 362);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 27);
            txtEmail.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 0;
            label4.Tag = "";
            label4.Text = "Số Điện Thoại";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(12, 164);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(268, 27);
            txtSDT.TabIndex = 6;
            // 
            // KhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 477);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "0";
            Text = "Khách Hàng";
            Load += KhachHang_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private TextBox txtTimKiem;
        private Label label1;
        private Panel panel1;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private TextBox txtDiaChi;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnThem;
        private Button btnHuy;
        private Button btnSua;
        private Button btnTimKiem;
        private Label label;
        private Label label6;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn Diem;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn Email;
        public DataGridView dgvKhachHang;
        public TextBox txtSDT;
        public TextBox txtTenKH;
        public TextBox txtDiemTichLuy;
        public TextBox txtMaKH;
    }
}