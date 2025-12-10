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
            splitContainer1 = new SplitContainer();
            btnThoat = new Button();
            txtMaSach = new TextBox();
            txtTenSach = new TextBox();
            label4 = new Label();
            label1 = new Label();
            txtTacGia = new TextBox();
            txtGhiChu = new TextBox();
            cboDanhMuc = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            btnSua = new Button();
            label = new Label();
            btnHuy = new Button();
            label6 = new Label();
            btnThem = new Button();
            label3 = new Label();
            btnLuu = new Button();
            txtSoLuongTon = new TextBox();
            btnXoa = new Button();
            txtGiaBan = new TextBox();
            dgvSach = new DataGridView();
            MSach = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            TenDanhMuc = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            TacGia = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(btnThoat);
            splitContainer1.Panel1.Controls.Add(txtMaSach);
            splitContainer1.Panel1.Controls.Add(txtTenSach);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txtTacGia);
            splitContainer1.Panel1.Controls.Add(txtGhiChu);
            splitContainer1.Panel1.Controls.Add(cboDanhMuc);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(btnSua);
            splitContainer1.Panel1.Controls.Add(label);
            splitContainer1.Panel1.Controls.Add(btnHuy);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(btnThem);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(btnLuu);
            splitContainer1.Panel1.Controls.Add(txtSoLuongTon);
            splitContainer1.Panel1.Controls.Add(btnXoa);
            splitContainer1.Panel1.Controls.Add(txtGiaBan);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvSach);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1321, 564);
            splitContainer1.SplitterDistance = 289;
            splitContainer1.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(153, 523);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(125, 29);
            btnThoat.TabIndex = 64;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(10, 37);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(268, 27);
            txtMaSach.TabIndex = 51;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(10, 95);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(268, 27);
            txtTenSach.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 191);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 62;
            label4.Text = "Tác Giả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 72);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 46;
            label1.Text = "Tên Sách";
            // 
            // txtTacGia
            // 
            txtTacGia.Location = new Point(10, 214);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(268, 27);
            txtTacGia.TabIndex = 63;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(10, 383);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(268, 27);
            txtGhiChu.TabIndex = 55;
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(10, 153);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(268, 28);
            cboDanhMuc.TabIndex = 61;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 360);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 45;
            label5.Text = "Ghi Chú";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 130);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 60;
            label7.Tag = "";
            label7.Text = "Danh Mục";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(10, 483);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(132, 29);
            btnSua.TabIndex = 59;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(10, 244);
            label.Name = "label";
            label.Size = new Size(64, 20);
            label.TabIndex = 47;
            label.Text = "Giá Bán ";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(153, 483);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(125, 29);
            btnHuy.TabIndex = 57;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 12);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 48;
            label6.Text = "Mã Sách";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(10, 443);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(132, 29);
            btnThem.TabIndex = 50;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 302);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 49;
            label3.Text = "Số Lượng Tồn";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(10, 523);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(132, 29);
            btnLuu.TabIndex = 56;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.Location = new Point(10, 325);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.Size = new Size(268, 27);
            txtSoLuongTon.TabIndex = 54;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(153, 443);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(125, 29);
            btnXoa.TabIndex = 58;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(10, 267);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(268, 27);
            txtGiaBan.TabIndex = 53;
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.ColumnHeadersHeight = 29;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { MSach, TenSach, TenDanhMuc, GiaBan, SoLuongTon, TacGia, GhiChu });
            dgvSach.Dock = DockStyle.Fill;
            dgvSach.Location = new Point(0, 64);
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.RowHeadersWidth = 51;
            dgvSach.ScrollBars = ScrollBars.Vertical;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(1028, 500);
            dgvSach.TabIndex = 44;
            // 
            // MSach
            // 
            MSach.DataPropertyName = "MaSach";
            MSach.FillWeight = 50F;
            MSach.HeaderText = "Mã Sách";
            MSach.MinimumWidth = 6;
            MSach.Name = "MSach";
            MSach.ReadOnly = true;
            // 
            // TenSach
            // 
            TenSach.DataPropertyName = "TenSach";
            TenSach.FillWeight = 150F;
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
            GiaBan.FillWeight = 70F;
            GiaBan.HeaderText = "Giá ";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            SoLuongTon.FillWeight = 50F;
            SoLuongTon.HeaderText = "Tồn Kho";
            SoLuongTon.MinimumWidth = 6;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.ReadOnly = true;
            // 
            // TacGia
            // 
            TacGia.DataPropertyName = "TacGia";
            TacGia.FillWeight = 125F;
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
            // panel1
            // 
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 64);
            panel1.TabIndex = 45;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.Location = new Point(726, 18);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 46;
            btnTimKiem.Text = "Tim Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.ForeColor = SystemColors.ControlDark;
            txtTimKiem.Location = new Point(333, 18);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(387, 27);
            txtTimKiem.TabIndex = 45;
            txtTimKiem.Leave += txtTimKiem_Leave;
            txtTimKiem.Enter += txtTimKiem_Enter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(208, 21);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 44;
            label2.Text = "Tìm Kiếm";
            // 
            // KhoSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 564);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(1339, 611);
            Name = "KhoSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kho Sách";
            Load += KhoSach_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnThoat;
        private TextBox txtMaSach;
        private TextBox txtTenSach;
        private Label label4;
        private Label label1;
        private TextBox txtTacGia;
        private TextBox txtGhiChu;
        private ComboBox cboDanhMuc;
        private Label label5;
        private Label label7;
        private Button btnSua;
        private Label label;
        private Button btnHuy;
        private Label label6;
        private Button btnThem;
        private Label label3;
        private Button btnLuu;
        private TextBox txtSoLuongTon;
        private Button btnXoa;
        private TextBox txtGiaBan;
        private DataGridView dgvSach;
        private Panel panel1;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label2;
        private DataGridViewTextBoxColumn MSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn TenDanhMuc;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridViewTextBoxColumn TacGia;
        private DataGridViewTextBoxColumn GhiChu;
    }
}