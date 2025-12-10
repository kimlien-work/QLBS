namespace QLBS
{
    partial class DoanhThu
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            dtpDenNgay = new DateTimePicker();
            btnXemBC = new Button();
            dtpTuNgay = new DateTimePicker();
            panel2 = new Panel();
            btnThoat = new Button();
            label = new Label();
            label3 = new Label();
            txtSlSachBan = new TextBox();
            txtTongDonHang = new TextBox();
            label4 = new Label();
            txtTongDoanhThu = new TextBox();
            dgvDoanhThu = new DataGridView();
            MaHD = new DataGridViewTextBoxColumn();
            NgayTao = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(btnXemBC);
            panel1.Controls.Add(dtpTuNgay);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 60);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(10, 19);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 36;
            label2.Text = "Từ Ngày:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(344, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 37;
            label1.Text = "Đến Ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Anchor = AnchorStyles.None;
            dtpDenNgay.Location = new Point(430, 16);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(250, 27);
            dtpDenNgay.TabIndex = 34;
            // 
            // btnXemBC
            // 
            btnXemBC.Anchor = AnchorStyles.None;
            btnXemBC.Location = new Point(688, 16);
            btnXemBC.Name = "btnXemBC";
            btnXemBC.Size = new Size(143, 29);
            btnXemBC.TabIndex = 38;
            btnXemBC.Text = "Xem Báo Cáo";
            btnXemBC.UseVisualStyleBackColor = true;
            btnXemBC.Click += btnXemBC_Click;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Anchor = AnchorStyles.None;
            dtpTuNgay.Location = new Point(86, 16);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(250, 27);
            dtpTuNgay.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(label);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtSlSachBan);
            panel2.Controls.Add(txtTongDonHang);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtTongDoanhThu);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 391);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 83);
            panel2.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.Location = new Point(668, 40);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(151, 29);
            btnThoat.TabIndex = 41;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.None;
            label.AutoSize = true;
            label.Location = new Point(23, 13);
            label.Name = "label";
            label.Size = new Size(115, 20);
            label.TabIndex = 42;
            label.Text = "Tổng Đơn Hàng";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(238, 13);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 43;
            label3.Text = "SL Sách Bán";
            // 
            // txtSlSachBan
            // 
            txtSlSachBan.Anchor = AnchorStyles.None;
            txtSlSachBan.Location = new Point(238, 41);
            txtSlSachBan.Name = "txtSlSachBan";
            txtSlSachBan.ReadOnly = true;
            txtSlSachBan.Size = new Size(185, 27);
            txtSlSachBan.TabIndex = 47;
            // 
            // txtTongDonHang
            // 
            txtTongDonHang.Anchor = AnchorStyles.None;
            txtTongDonHang.Location = new Point(23, 41);
            txtTongDonHang.Name = "txtTongDonHang";
            txtTongDonHang.ReadOnly = true;
            txtTongDonHang.Size = new Size(185, 27);
            txtTongDonHang.TabIndex = 46;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(453, 13);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 44;
            label4.Tag = "";
            label4.Text = "Tổng Doanh Thu";
            // 
            // txtTongDoanhThu
            // 
            txtTongDoanhThu.Anchor = AnchorStyles.None;
            txtTongDoanhThu.Location = new Point(453, 41);
            txtTongDoanhThu.Name = "txtTongDoanhThu";
            txtTongDoanhThu.Size = new Size(185, 27);
            txtTongDoanhThu.TabIndex = 45;
            // 
            // dgvDoanhThu
            // 
            dgvDoanhThu.AllowUserToAddRows = false;
            dgvDoanhThu.AllowUserToDeleteRows = false;
            dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhThu.Columns.AddRange(new DataGridViewColumn[] { MaHD, NgayTao, TenKH, TenNhanVien, TongTien, TrangThai });
            dgvDoanhThu.Dock = DockStyle.Fill;
            dgvDoanhThu.Location = new Point(0, 60);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.ReadOnly = true;
            dgvDoanhThu.RowHeadersWidth = 51;
            dgvDoanhThu.ScrollBars = ScrollBars.Vertical;
            dgvDoanhThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoanhThu.Size = new Size(842, 331);
            dgvDoanhThu.TabIndex = 32;
            // 
            // MaHD
            // 
            MaHD.DataPropertyName = "MaHD";
            MaHD.FillWeight = 60F;
            MaHD.HeaderText = "Mã HĐ";
            MaHD.MinimumWidth = 6;
            MaHD.Name = "MaHD";
            MaHD.ReadOnly = true;
            // 
            // NgayTao
            // 
            NgayTao.DataPropertyName = "NgayTao";
            NgayTao.FillWeight = 70F;
            NgayTao.HeaderText = "Ngày Bán";
            NgayTao.MinimumWidth = 6;
            NgayTao.Name = "NgayTao";
            NgayTao.ReadOnly = true;
            // 
            // TenKH
            // 
            TenKH.DataPropertyName = "TenKH";
            TenKH.HeaderText = "Khách Hàng";
            TenKH.MinimumWidth = 6;
            TenKH.Name = "TenKH";
            TenKH.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Nhân Viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            TenNhanVien.ReadOnly = true;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle1.Format = "N0";
            TongTien.DefaultCellStyle = dataGridViewCellStyle1;
            TongTien.FillWeight = 80F;
            TongTien.HeaderText = "Tổng Tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng Thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            // 
            // DoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 474);
            Controls.Add(dgvDoanhThu);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(860, 521);
            Name = "DoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doanh Thu";
            Load += DoanhThu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpDenNgay;
        private Button btnXemBC;
        private DateTimePicker dtpTuNgay;
        private Panel panel2;
        private Button btnThoat;
        private Label label;
        private Label label3;
        private TextBox txtSlSachBan;
        private TextBox txtTongDonHang;
        private Label label4;
        private TextBox txtTongDoanhThu;
        private DataGridView dgvDoanhThu;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn NgayTao;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn TrangThai;
    }
}