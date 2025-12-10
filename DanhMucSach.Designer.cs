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
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            btnThoat = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            label6 = new Label();
            btnThem = new Button();
            btnHuy = new Button();
            txtTenDM = new TextBox();
            txtMaDM = new TextBox();
            dgvDanhMuc = new DataGridView();
            MDM = new DataGridViewTextBoxColumn();
            TenDanhMuc = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(btnThoat);
            splitContainer1.Panel1.Controls.Add(btnXoa);
            splitContainer1.Panel1.Controls.Add(btnLuu);
            splitContainer1.Panel1.Controls.Add(btnSua);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(btnThem);
            splitContainer1.Panel1.Controls.Add(btnHuy);
            splitContainer1.Panel1.Controls.Add(txtTenDM);
            splitContainer1.Panel1.Controls.Add(txtMaDM);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvDanhMuc);
            splitContainer1.Size = new Size(351, 475);
            splitContainer1.SplitterDistance = 206;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(27, 45);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 18;
            label1.Text = "Tên Danh Mục:";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top;
            btnThoat.Location = new Point(27, 163);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(297, 29);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(227, 93);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(97, 29);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.Location = new Point(27, 128);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(128, 29);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Location = new Point(129, 93);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(27, 14);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 17;
            label6.Text = "Mã Danh Mục:";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(27, 93);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Top;
            btnHuy.Location = new Point(196, 128);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(128, 29);
            btnHuy.TabIndex = 15;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // txtTenDM
            // 
            txtTenDM.Anchor = AnchorStyles.Top;
            txtTenDM.Location = new Point(139, 45);
            txtTenDM.Name = "txtTenDM";
            txtTenDM.Size = new Size(185, 27);
            txtTenDM.TabIndex = 11;
            // 
            // txtMaDM
            // 
            txtMaDM.Anchor = AnchorStyles.Top;
            txtMaDM.Location = new Point(139, 14);
            txtMaDM.Name = "txtMaDM";
            txtMaDM.Size = new Size(185, 27);
            txtMaDM.TabIndex = 9;
            // 
            // dgvDanhMuc
            // 
            dgvDanhMuc.AllowUserToAddRows = false;
            dgvDanhMuc.AllowUserToDeleteRows = false;
            dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhMuc.Columns.AddRange(new DataGridViewColumn[] { MDM, TenDanhMuc });
            dgvDanhMuc.Dock = DockStyle.Fill;
            dgvDanhMuc.Location = new Point(0, 0);
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.ReadOnly = true;
            dgvDanhMuc.RowHeadersWidth = 51;
            dgvDanhMuc.ScrollBars = ScrollBars.Vertical;
            dgvDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhMuc.Size = new Size(351, 265);
            dgvDanhMuc.TabIndex = 13;
            // 
            // MDM
            // 
            MDM.DataPropertyName = "MaDM";
            MDM.FillWeight = 80F;
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
            // DanhMucSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 475);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(369, 522);
            Name = "DanhMucSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh Mục Sách";
            Load += DanhMucSach_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn TenDM;
        private SplitContainer splitContainer1;
        private Label label1;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
        private Label label6;
        private Button btnThem;
        private Button btnHuy;
        private TextBox txtTenDM;
        private TextBox txtMaDM;
        private DataGridView dgvDanhMuc;
        private DataGridViewTextBoxColumn MDM;
        private DataGridViewTextBoxColumn TenDanhMuc;
    }
}