namespace QLBS
{
    partial class main
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
            menuStrip1 = new MenuStrip();
            menuHeThong = new ToolStripMenuItem();
            menuDangNhap = new ToolStripMenuItem();
            menuDangXuat = new ToolStripMenuItem();
            menuThoat = new ToolStripMenuItem();
            menuQuanLy = new ToolStripMenuItem();
            menuKhachHang = new ToolStripMenuItem();
            menuTaiKhoan = new ToolStripMenuItem();
            menuKhoSach = new ToolStripMenuItem();
            menuDanhMucSach = new ToolStripMenuItem();
            menuThongKe = new ToolStripMenuItem();
            menuDoanhThu = new ToolStripMenuItem();
            menuKinhDoanh = new ToolStripMenuItem();
            menuBanhang = new ToolStripMenuItem();
            menuTroGiup = new ToolStripMenuItem();
            menuHDSD = new ToolStripMenuItem();
            menuThongTinPM = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuHeThong, menuQuanLy, menuThongKe, menuKinhDoanh, menuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            menuHeThong.DropDownItems.AddRange(new ToolStripItem[] { menuDangNhap, menuDangXuat, menuThoat });
            menuHeThong.Name = "menuHeThong";
            menuHeThong.Size = new Size(88, 24);
            menuHeThong.Text = "Hệ Thống";
            // 
            // menuDangNhap
            // 
            menuDangNhap.Name = "menuDangNhap";
            menuDangNhap.Size = new Size(168, 26);
            menuDangNhap.Text = "Đăng Nhập";
            menuDangNhap.Click += menuDangNhap_Click;
            // 
            // menuDangXuat
            // 
            menuDangXuat.Name = "menuDangXuat";
            menuDangXuat.Size = new Size(168, 26);
            menuDangXuat.Text = "Đăng Xuất";
            menuDangXuat.Click += menuDangXuat_Click;
            // 
            // menuThoat
            // 
            menuThoat.Name = "menuThoat";
            menuThoat.Size = new Size(168, 26);
            menuThoat.Text = "Thoát";
            menuThoat.Click += menuThoat_Click;
            // 
            // menuQuanLy
            // 
            menuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { menuKhachHang, menuTaiKhoan, menuKhoSach, menuDanhMucSach });
            menuQuanLy.Name = "menuQuanLy";
            menuQuanLy.Size = new Size(75, 24);
            menuQuanLy.Text = "Quản Lý";
            // 
            // menuKhachHang
            // 
            menuKhachHang.Name = "menuKhachHang";
            menuKhachHang.Size = new Size(224, 26);
            menuKhachHang.Text = "Khách Hàng";
            menuKhachHang.Click += menuKhachHang_Click;
            // 
            // menuTaiKhoan
            // 
            menuTaiKhoan.Name = "menuTaiKhoan";
            menuTaiKhoan.Size = new Size(224, 26);
            menuTaiKhoan.Text = "Tài Khoản";
            // 
            // menuKhoSach
            // 
            menuKhoSach.Name = "menuKhoSach";
            menuKhoSach.Size = new Size(224, 26);
            menuKhoSach.Text = "Kho Sách";
            menuKhoSach.Click += menuKhoSach_Click;
            // 
            // menuDanhMucSach
            // 
            menuDanhMucSach.Name = "menuDanhMucSach";
            menuDanhMucSach.Size = new Size(224, 26);
            menuDanhMucSach.Text = "Danh Mục Sách";
            menuDanhMucSach.Click += menuDanhMucSach_Click;
            // 
            // menuThongKe
            // 
            menuThongKe.DropDownItems.AddRange(new ToolStripItem[] { menuDoanhThu });
            menuThongKe.Name = "menuThongKe";
            menuThongKe.Size = new Size(152, 24);
            menuThongKe.Text = "Báo Cáo -Thống Kê";
            // 
            // menuDoanhThu
            // 
            menuDoanhThu.Name = "menuDoanhThu";
            menuDoanhThu.Size = new Size(164, 26);
            menuDoanhThu.Text = "Doanh Thu";
            menuDoanhThu.Click += menuDoanhThu_Click;
            // 
            // menuKinhDoanh
            // 
            menuKinhDoanh.DropDownItems.AddRange(new ToolStripItem[] { menuBanhang });
            menuKinhDoanh.Name = "menuKinhDoanh";
            menuKinhDoanh.Size = new Size(100, 24);
            menuKinhDoanh.Text = "Kinh Doanh";
            // 
            // menuBanhang
            // 
            menuBanhang.Name = "menuBanhang";
            menuBanhang.Size = new Size(157, 26);
            menuBanhang.Text = "Bán Hàng";
            menuBanhang.Click += menuBanhang_Click;
            // 
            // menuTroGiup
            // 
            menuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { menuHDSD, menuThongTinPM });
            menuTroGiup.Name = "menuTroGiup";
            menuTroGiup.Size = new Size(83, 24);
            menuTroGiup.Text = " Trợ Giúp";
            // 
            // menuHDSD
            // 
            menuHDSD.Name = "menuHDSD";
            menuHDSD.Size = new Size(224, 26);
            menuHDSD.Text = "HDSD PM";
            // 
            // menuThongTinPM
            // 
            menuThongTinPM.Name = "menuThongTinPM";
            menuThongTinPM.Size = new Size(224, 26);
            menuThongTinPM.Text = "Thông Tin PM";
            menuThongTinPM.Click += menuThongTinPM_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 18);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(151, 20);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "main";
            Text = "main";
            Load += main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuHeThong;
        private ToolStripMenuItem menuDangNhap;
        private ToolStripMenuItem menuDangXuat;
        private ToolStripMenuItem menuThoat;
        private ToolStripMenuItem menuQuanLy;
        private ToolStripMenuItem menuKhachHang;
        private ToolStripMenuItem menuTaiKhoan;
        private ToolStripMenuItem menuKhoSach;
        private ToolStripMenuItem menuDanhMucSach;
        private ToolStripMenuItem menuThongKe;
        private ToolStripMenuItem menuKinhDoanh;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripMenuItem menuDoanhThu;
        private ToolStripMenuItem menuBanhang;
        private ToolStripMenuItem menuTroGiup;
        private ToolStripMenuItem menuHDSD;
        private ToolStripMenuItem menuThongTinPM;
    }
}