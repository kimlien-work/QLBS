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
            panel3 = new Panel();
            btnTichDiem = new Button();
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
            dgvGioHang = new DataGridView();
            idsach = new DataGridViewTextBoxColumn();
            namesach = new DataGridViewTextBoxColumn();
            slsach = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            thtien = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
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
            panel3.Size = new Size(746, 110);
            panel3.TabIndex = 2;
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
            // panel2
            // 
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(746, 718);
            panel2.TabIndex = 4;
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Dock = DockStyle.Top;
            dgvSach.Location = new Point(0, 41);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(746, 217);
            dgvSach.TabIndex = 24;
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
            dgvGioHang.Size = new Size(746, 260);
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
            price.HeaderText = "Đơn Giá ";
            price.MinimumWidth = 6;
            price.Name = "price";
            // 
            // thtien
            // 
            thtien.DataPropertyName = "ThanhTien";
            thtien.HeaderText = "Thành Tiền";
            thtien.MinimumWidth = 6;
            thtien.Name = "thtien";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 275);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 272);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 312);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 0;
            label4.Text = "label1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 309);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 275);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 0;
            label5.Text = "label1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 312);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 0;
            label6.Text = "label1";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(391, 272);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(391, 309);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 1;
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 718);
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
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
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
        
        private Button btnTichDiem;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label6;
        private Label label5;
    }
}