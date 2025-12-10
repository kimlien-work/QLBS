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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            btnXemBC = new Button();
            panel2 = new Panel();
            dgvDoanhThu = new DataGridView();
            MaHD = new DataGridViewTextBoxColumn();
            NgayTao = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            btnThoat = new Button();
            label = new Label();
            label3 = new Label();
            txtSlSachBan = new TextBox();
            txtTongDonHang = new TextBox();
            label4 = new Label();
            txtTongDoanhThu = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 35);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Từ Ngày:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 35);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "Đến Ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(431, 32);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(250, 27);
            dtpDenNgay.TabIndex = 0;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(85, 32);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(250, 27);
            dtpTuNgay.TabIndex = 0;
            // 
            // btnXemBC
            // 
            btnXemBC.Location = new Point(687, 32);
            btnXemBC.Name = "btnXemBC";
            btnXemBC.Size = new Size(143, 29);
            btnXemBC.TabIndex = 3;
            btnXemBC.Text = "Xem Báo Cáo";
            btnXemBC.UseVisualStyleBackColor = true;
            btnXemBC.Click += btnXemBC_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label);
            panel2.Controls.Add(dgvDoanhThu);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtSlSachBan);
            panel2.Controls.Add(dtpDenNgay);
            panel2.Controls.Add(txtTongDonHang);
            panel2.Controls.Add(btnXemBC);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtTongDoanhThu);
            panel2.Controls.Add(dtpTuNgay);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 474);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dgvDoanhThu
            // 
            dgvDoanhThu.AllowUserToAddRows = false;
            dgvDoanhThu.AllowUserToDeleteRows = false;
            dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhThu.Columns.AddRange(new DataGridViewColumn[] { MaHD, NgayTao, TenKH, TenNhanVien, TongTien, TrangThai });
            dgvDoanhThu.Location = new Point(372, 91);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.ReadOnly = true;
            dgvDoanhThu.RowHeadersWidth = 51;
            dgvDoanhThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoanhThu.Size = new Size(335, 147);
            dgvDoanhThu.TabIndex = 3;
            // 
            // MaHD
            // 
            MaHD.DataPropertyName = "MaHD";
            MaHD.HeaderText = "Mã Hóa Đơn";
            MaHD.MinimumWidth = 6;
            MaHD.Name = "MaHD";
            MaHD.ReadOnly = true;
            // 
            // NgayTao
            // 
            NgayTao.DataPropertyName = "NgayTao";
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
            dataGridViewCellStyle2.Format = "N0";
            TongTien.DefaultCellStyle = dataGridViewCellStyle2;
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
            // btnThoat
            // 
            btnThoat.Location = new Point(694, 333);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(151, 29);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(47, 312);
            label.Name = "label";
            label.Size = new Size(115, 20);
            label.TabIndex = 9;
            label.Text = "Tổng Đơn Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 312);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 10;
            label3.Text = "SL Sách Bán";
            // 
            // txtSlSachBan
            // 
            txtSlSachBan.Location = new Point(265, 335);
            txtSlSachBan.Name = "txtSlSachBan";
            txtSlSachBan.ReadOnly = true;
            txtSlSachBan.Size = new Size(185, 27);
            txtSlSachBan.TabIndex = 14;
            // 
            // txtTongDonHang
            // 
            txtTongDonHang.Location = new Point(47, 335);
            txtTongDonHang.Name = "txtTongDonHang";
            txtTongDonHang.ReadOnly = true;
            txtTongDonHang.Size = new Size(185, 27);
            txtTongDonHang.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(483, 312);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 11;
            label4.Tag = "";
            label4.Text = "Tổng Doanh Thu";
            // 
            // txtTongDoanhThu
            // 
            txtTongDoanhThu.Location = new Point(483, 335);
            txtTongDoanhThu.Name = "txtTongDoanhThu";
            txtTongDoanhThu.Size = new Size(185, 27);
            txtTongDoanhThu.TabIndex = 12;
            // 
            // DoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 474);
            Controls.Add(panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doanh Thu";
            Load += DoanhThu_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private Panel panel2;
        private Label label2;
        private Button btnXemBC;
        private DataGridView dgvDoanhThu;
        private Label label;
        private Label label3;
        private TextBox txtSlSachBan;
        private TextBox txtTongDonHang;
        private Label label4;
        private TextBox txtTongDoanhThu;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn NgayTao;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn TrangThai;
        private Button btnThoat;
    }
}