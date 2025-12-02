namespace QLBS
{
    partial class TaiKhoan
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
            panel1 = new Panel();
            btnXoa = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnHuy = new Button();
            btnSua = new Button();
            cboChucVu = new ComboBox();
            label = new Label();
            label6 = new Label();
            label3 = new Label();
            txtTenNhanVien = new TextBox();
            txtID = new TextBox();
            label4 = new Label();
            txtMatKhau = new TextBox();
            label1 = new Label();
            txtAccount = new TextBox();
            panel2 = new Panel();
            dgvTaiKhoan = new DataGridView();
            MaID = new DataGridViewTextBoxColumn();
            Account = new DataGridViewTextBoxColumn();
            MatKhau = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(cboChucVu);
            panel1.Controls.Add(label);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTenNhanVien);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtAccount);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 429);
            panel1.TabIndex = 0;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(202, 354);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(78, 29);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(14, 386);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(119, 29);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(14, 354);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(76, 29);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(172, 386);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(108, 29);
            btnHuy.TabIndex = 21;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(105, 354);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 29);
            btnSua.TabIndex = 23;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Admin", "Nhân Viên" });
            cboChucVu.Location = new Point(12, 294);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(268, 28);
            cboChucVu.TabIndex = 18;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 205);
            label.Name = "label";
            label.Size = new Size(104, 20);
            label.TabIndex = 9;
            label.Text = "Tên Nhân Viên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 6);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 10;
            label6.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 271);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 11;
            label3.Text = "Chức Vụ";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(12, 228);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(268, 27);
            txtTenNhanVien.TabIndex = 17;
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 30);
            txtID.Name = "txtID";
            txtID.Size = new Size(268, 27);
            txtID.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 139);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 12;
            label4.Tag = "";
            label4.Text = "Mật Khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(12, 162);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(268, 27);
            txtMatKhau.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 13;
            label1.Text = "Tài Khoản";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(12, 96);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(268, 27);
            txtAccount.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvTaiKhoan);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(294, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(506, 429);
            panel2.TabIndex = 1;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(0, 0);
            dgvTaiKhoan.MultiSelect = false;
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.Size = new Size(506, 429);
            dgvTaiKhoan.TabIndex = 2;
            // 
            // MaID
            // 
            MaID.DataPropertyName = "ID";
            MaID.HeaderText = "ID";
            MaID.MinimumWidth = 6;
            MaID.Name = "MaID";
            MaID.ReadOnly = true;
            MaID.Width = 125;
            // 
            // Account
            // 
            Account.DataPropertyName = "Account";
            Account.HeaderText = "Tài Khoản";
            Account.MinimumWidth = 6;
            Account.Name = "Account";
            Account.ReadOnly = true;
            Account.Width = 125;
            // 
            // MatKhau
            // 
            MatKhau.DataPropertyName = "MatKhau";
            MatKhau.HeaderText = "Mật Khẩu";
            MatKhau.MinimumWidth = 6;
            MatKhau.Name = "MatKhau";
            MatKhau.ReadOnly = true;
            MatKhau.Width = 125;
            // 
            // ChucVu
            // 
            ChucVu.HeaderText = "Chức Vụ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            ChucVu.ReadOnly = true;
            ChucVu.Width = 125;
            // 
            // TaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 429);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tài Khoản";
            Load += TaiKhoan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label;
        private Label label6;
        private Label label3;
        private TextBox txtTenNhanVien;
        private TextBox txtID;
        private Label label4;
        private TextBox txtMatKhau;
        private Label label1;
        private TextBox txtAccount;
        private ComboBox cboChucVu;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnThem;
        private Button btnHuy;
        private Button btnSua;
        private DataGridView dgvTaiKhoan;
        private DataGridViewTextBoxColumn MaID;
        private DataGridViewTextBoxColumn Account;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewTextBoxColumn ChucVu;
    }
}