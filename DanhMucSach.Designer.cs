namespace QLBS
{
    partial class DanhMucSach
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
            label6 = new Label();
            txtMaDM = new TextBox();
            label1 = new Label();
            txtTenDM = new TextBox();
            dgvDanhMuc = new DataGridView();
            MDM = new DataGridViewTextBoxColumn();
            TenDanhMuc = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnXoa = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnSua = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtMaDM);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTenDM);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 81);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 15);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 6;
            label6.Text = "Mã Sách";
            // 
            // txtMaDM
            // 
            txtMaDM.Location = new Point(127, 12);
            txtMaDM.Name = "txtMaDM";
            txtMaDM.Size = new Size(185, 27);
            txtMaDM.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 48);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 7;
            label1.Text = "Tên Sách";
            // 
            // txtTenDM
            // 
            txtTenDM.Location = new Point(127, 45);
            txtTenDM.Name = "txtTenDM";
            txtTenDM.Size = new Size(185, 27);
            txtTenDM.TabIndex = 9;
            // 
            // dgvDanhMuc
            // 
            dgvDanhMuc.AllowUserToAddRows = false;
            dgvDanhMuc.AllowUserToDeleteRows = false;
            dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhMuc.Columns.AddRange(new DataGridViewColumn[] { MDM, TenDanhMuc });
            dgvDanhMuc.Dock = DockStyle.Bottom;
            dgvDanhMuc.Location = new Point(0, 189);
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.ReadOnly = true;
            dgvDanhMuc.RowHeadersWidth = 51;
            dgvDanhMuc.Size = new Size(351, 286);
            dgvDanhMuc.TabIndex = 19;
            // 
            // MDM
            // 
            MDM.DataPropertyName = "MaDM";
            MDM.HeaderText = "Mã Danh Mục";
            MDM.MinimumWidth = 6;
            MDM.Name = "MDM";
            MDM.ReadOnly = true;
            // 
            // TenDanhMuc
            // 
            TenDanhMuc.DataPropertyName = "TenDanhMuc";
            TenDanhMuc.HeaderText = "Tên Danh Mục";
            TenDanhMuc.MinimumWidth = 6;
            TenDanhMuc.Name = "TenDanhMuc";
            TenDanhMuc.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnHuy);
            panel2.Controls.Add(btnSua);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(351, 108);
            panel2.TabIndex = 20;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(234, 6);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(78, 29);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(46, 38);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(119, 29);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(46, 6);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(76, 29);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(46, 73);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(266, 29);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(204, 38);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(108, 29);
            btnHuy.TabIndex = 16;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(137, 6);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 29);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // DanhMucSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 475);
            Controls.Add(panel2);
            Controls.Add(dgvDanhMuc);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DanhMucSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh Mục Sách";
            Load += DanhMucSach_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView dgvDanhMuc;
        private DataGridViewTextBoxColumn TenDM;
        private DataGridViewTextBoxColumn MDM;
        private DataGridViewTextBoxColumn TenDanhMuc;
        private Panel panel2;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnThem;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnSua;
        private Label label6;
        private TextBox txtMaDM;
        private Label label1;
        private TextBox txtTenDM;
    }
}