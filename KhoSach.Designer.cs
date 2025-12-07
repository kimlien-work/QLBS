namespace QLBS
{
    partial class KhoSach
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
            label = new Label();
            label6 = new Label();
            label3 = new Label();
            txtSoLuongTon = new TextBox();
            txtGiaBan = new TextBox();
            txtMaSach = new TextBox();
            btnXoa = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnHuy = new Button();
            btnSua = new Button();
            label5 = new Label();
            txtGhiChu = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnTimKiem = new Button();
            label2 = new Label();
            txtTimKiem = new TextBox();
            dgvSach = new DataGridView();
            MSach = new DataGridViewTextBoxColumn();
            MaDM = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            TenDanhMuc = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            TacGia = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtTenSach = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            txtTacGia = new TextBox();
            cboDanhMuc = new ComboBox();
            label7 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 240);
            label.Name = "label";
            label.Size = new Size(64, 20);
            label.TabIndex = 0;
            label.Text = "Giá Bán ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 8);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 0;
            label6.Text = "Mã Sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 298);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 0;
            label3.Text = "Số Lượng Tồn";
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.Location = new Point(12, 321);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.ReadOnly = true;
            txtSoLuongTon.Size = new Size(268, 27);
            txtSoLuongTon.TabIndex = 8;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(12, 263);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(268, 27);
            txtGiaBan.TabIndex = 7;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(12, 33);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(268, 27);
            txtMaSach.TabIndex = 4;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(150, 451);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(125, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(12, 487);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(132, 29);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 416);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(263, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm Sách";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(150, 486);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(125, 29);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(12, 452);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(132, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 356);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 0;
            label5.Text = "Ghi Chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(12, 379);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(268, 27);
            txtGhiChu.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgvSach);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(287, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 525);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnTimKiem);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtTimKiem);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(770, 40);
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
            txtTimKiem.Text = "Nhập Tên Sách Cần Tìm";
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.ColumnHeadersHeight = 29;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { MSach, MaDM, TenSach, TenDanhMuc, GiaBan, SoLuongTon, TacGia, GhiChu });
            dgvSach.Dock = DockStyle.Bottom;
            dgvSach.Location = new Point(0, 40);
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.RowHeadersWidth = 51;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(770, 485);
            dgvSach.TabIndex = 0;
            // 
            // MSach
            // 
            MSach.DataPropertyName = "MaSach";
            MSach.HeaderText = "Mã Sách";
            MSach.MinimumWidth = 6;
            MSach.Name = "MSach";
            MSach.ReadOnly = true;
            // 
            // MaDM
            // 
            MaDM.DataPropertyName = "MaDM";
            MaDM.HeaderText = "Mã DM";
            MaDM.MinimumWidth = 6;
            MaDM.Name = "MaDM";
            MaDM.ReadOnly = true;
            // 
            // TenSach
            // 
            TenSach.DataPropertyName = "TenSach";
            TenSach.HeaderText = "Tên Sách";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            TenSach.ReadOnly = true;
            // 
            // TenDanhMuc
            // 
            TenDanhMuc.DataPropertyName = "TenDanhMuc";
            TenDanhMuc.HeaderText = "Danh Mục";
            TenDanhMuc.MinimumWidth = 6;
            TenDanhMuc.Name = "TenDanhMuc";
            TenDanhMuc.ReadOnly = true;
            // 
            // GiaBan
            // 
            GiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            GiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            GiaBan.HeaderText = "Giá ";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            SoLuongTon.HeaderText = "Tồn Kho";
            SoLuongTon.MinimumWidth = 6;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.ReadOnly = true;
            // 
            // TacGia
            // 
            TacGia.DataPropertyName = "TacGia";
            TacGia.HeaderText = "Tác Giả";
            TacGia.MinimumWidth = 6;
            TacGia.Name = "TacGia";
            TacGia.ReadOnly = true;
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi Chú";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            GhiChu.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Sách";
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(12, 91);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(268, 27);
            txtTenSach.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTacGia);
            panel1.Controls.Add(cboDanhMuc);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSoLuongTon);
            panel1.Controls.Add(txtGiaBan);
            panel1.Controls.Add(txtMaSach);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTenSach);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 525);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 187);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 17;
            label4.Text = "Tác Giả";
            // 
            // txtTacGia
            // 
            txtTacGia.Location = new Point(13, 210);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(268, 27);
            txtTacGia.TabIndex = 18;
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(12, 149);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(263, 28);
            cboDanhMuc.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 126);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 15;
            label7.Tag = "";
            label7.Text = "Danh Mục";
            // 
            // KhoSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 525);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KhoSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kho Sách";
            Load += KhoSach_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label;
        private Label label6;
        private Label label3;
        private TextBox txtSoLuongTon;
        private TextBox txtGiaBan;
        private TextBox txtMaSach;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnThem;
        private Button btnHuy;
        private Button btnSua;
        private Label label5;
        private TextBox txtGhiChu;
        private Panel panel2;
        private Panel panel3;
        private Button btnTimKiem;
        private Label label2;
        private TextBox txtTimKiem;
        private Label label1;
        private TextBox txtTenSach;
        private Panel panel1;
        private ComboBox cboDanhMuc;
        private Label label7;
        private DataGridView dgvSach;
        private DataGridViewTextBoxColumn MSach;
        private DataGridViewTextBoxColumn MaDM;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn TenDanhMuc;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridViewTextBoxColumn TacGia;
        private DataGridViewTextBoxColumn GhiChu;
        private Label label4;
        private TextBox txtTacGia;
    }
}