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
            MaID = new DataGridViewTextBoxColumn();
            Account = new DataGridViewTextBoxColumn();
            MatKhau = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            splitContainer1 = new SplitContainer();
            btnThoat = new Button();
            txtTenNhanVien = new TextBox();
            lblGhiChuMK = new Label();
            label1 = new Label();
            btnXoa = new Button();
            label2 = new Label();
            txtAccount = new TextBox();
            label3 = new Label();
            btnLuu = new Button();
            cboChucVu = new ComboBox();
            label5 = new Label();
            txtID = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            txtMatKhau = new TextBox();
            label4 = new Label();
            btnHuy = new Button();
            dgvTaiKhoan = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
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
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnThoat);
            splitContainer1.Panel1.Controls.Add(txtTenNhanVien);
            splitContainer1.Panel1.Controls.Add(lblGhiChuMK);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(btnXoa);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(txtAccount);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(btnLuu);
            splitContainer1.Panel1.Controls.Add(cboChucVu);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(txtID);
            splitContainer1.Panel1.Controls.Add(btnThem);
            splitContainer1.Panel1.Controls.Add(btnSua);
            splitContainer1.Panel1.Controls.Add(txtMatKhau);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(btnHuy);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvTaiKhoan);
            splitContainer1.Size = new Size(865, 442);
            splitContainer1.SplitterDistance = 368;
            splitContainer1.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(244, 399);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 29);
            btnThoat.TabIndex = 24;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(6, 236);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(349, 27);
            txtTenNhanVien.TabIndex = 17;
            // 
            // lblGhiChuMK
            // 
            lblGhiChuMK.AutoSize = true;
            lblGhiChuMK.ForeColor = Color.Red;
            lblGhiChuMK.Location = new Point(6, 333);
            lblGhiChuMK.Name = "lblGhiChuMK";
            lblGhiChuMK.Size = new Size(356, 20);
            lblGhiChuMK.TabIndex = 3;
            lblGhiChuMK.Text = "* Bỏ trống mật khẩu sẽ giữ nguyên mật khẩu hiện tại";
            lblGhiChuMK.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 10;
            label1.Text = "ID";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(246, 365);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(108, 29);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 279);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 11;
            label2.Text = "Chức Vụ";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(6, 104);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(349, 27);
            txtAccount.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 213);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 9;
            label3.Text = "Tên Nhân Viên";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(6, 397);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(106, 29);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Admin", "Nhân Viên" });
            cboChucVu.Location = new Point(6, 302);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(349, 28);
            cboChucVu.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 81);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 13;
            label5.Text = "Tài Khoản";
            // 
            // txtID
            // 
            txtID.Location = new Point(6, 38);
            txtID.Name = "txtID";
            txtID.Size = new Size(349, 27);
            txtID.TabIndex = 14;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(6, 365);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(106, 29);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(124, 365);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 29);
            btnSua.TabIndex = 23;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(6, 170);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '•';
            txtMatKhau.Size = new Size(349, 27);
            txtMatKhau.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 147);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 12;
            label4.Tag = "";
            label4.Text = "Mật Khẩu";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(123, 399);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 29);
            btnHuy.TabIndex = 21;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(0, 0);
            dgvTaiKhoan.MultiSelect = false;
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.Size = new Size(493, 442);
            dgvTaiKhoan.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Account";
            dataGridViewTextBoxColumn1.FillWeight = 50F;
            dataGridViewTextBoxColumn1.HeaderText = "Account";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "MatKhau";
            dataGridViewTextBoxColumn2.FillWeight = 50F;
            dataGridViewTextBoxColumn2.HeaderText = "Mật Khẩu";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "TenNhanVien";
            dataGridViewTextBoxColumn3.FillWeight = 75F;
            dataGridViewTextBoxColumn3.HeaderText = "Tên Nhân Viên";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "ChucVu";
            dataGridViewTextBoxColumn4.FillWeight = 40F;
            dataGridViewTextBoxColumn4.HeaderText = "Chức Vụ";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // TaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 442);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(883, 489);
            Name = "TaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tài Khoản";
            Load += TaiKhoan_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn MaID;
        private DataGridViewTextBoxColumn Account;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewTextBoxColumn ChucVu;
        private SplitContainer splitContainer1;
        private DataGridView dgvTaiKhoan;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button btnThoat;
        private TextBox txtTenNhanVien;
        private Label lblGhiChuMK;
        private Label label1;
        private Button btnXoa;
        private Label label2;
        private TextBox txtAccount;
        private Label label3;
        private Button btnLuu;
        private ComboBox cboChucVu;
        private Label label5;
        private TextBox txtID;
        private Button btnThem;
        private Button btnSua;
        private TextBox txtMatKhau;
        private Label label4;
        private Button btnHuy;
    }
}