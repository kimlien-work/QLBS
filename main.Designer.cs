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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            mnuDanhNhap = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuDangXuat = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            mnuDanhMucSach = new ToolStripMenuItem();
            mnuKhoSach = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuKhachHang = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuTaiKhoan = new ToolStripMenuItem();
            báoCáoThốngKêToolStripMenuItem = new ToolStripMenuItem();
            mnuBanHang = new ToolStripMenuItem();
            mnuDoanhThu = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            gioithieiu = new ToolStripMenuItem();
            mnuHDSD = new ToolStripMenuItem();
            mnuThongTinPM = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, báoCáoThốngKêToolStripMenuItem, trợGiúpToolStripMenuItem, gioithieiu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuDanhNhap, toolStripSeparator1, mnuDangXuat, mnuThoat });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuDanhNhap
            // 
            mnuDanhNhap.Image = (Image)resources.GetObject("mnuDanhNhap.Image");
            mnuDanhNhap.Name = "mnuDanhNhap";
            mnuDanhNhap.Size = new Size(165, 26);
            mnuDanhNhap.Text = "Đăng nhập";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(162, 6);
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Image = (Image)resources.GetObject("mnuDangXuat.Image");
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(165, 26);
            mnuDangXuat.Text = "Đăng xuất";
            // 
            // mnuThoat
            // 
            mnuThoat.Image = (Image)resources.GetObject("mnuThoat.Image");
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(165, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuDanhMucSach, mnuKhoSach, toolStripSeparator3, mnuKhachHang, toolStripSeparator2, mnuTaiKhoan });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(73, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // mnuDanhMucSach
            // 
            mnuDanhMucSach.Image = (Image)resources.GetObject("mnuDanhMucSach.Image");
            mnuDanhMucSach.Name = "mnuDanhMucSach";
            mnuDanhMucSach.Size = new Size(192, 26);
            mnuDanhMucSach.Text = "Danh mục sách";
            mnuDanhMucSach.Click += mnuDanhMucSach_Click;
            // 
            // mnuKhoSach
            // 
            mnuKhoSach.Image = (Image)resources.GetObject("mnuKhoSach.Image");
            mnuKhoSach.Name = "mnuKhoSach";
            mnuKhoSach.Size = new Size(192, 26);
            mnuKhoSach.Text = "Kho sách";
            mnuKhoSach.Click += mnuKhoSach_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(189, 6);
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Image = (Image)resources.GetObject("mnuKhachHang.Image");
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(192, 26);
            mnuKhachHang.Text = "Khách hàng";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(189, 6);
            // 
            // mnuTaiKhoan
            // 
            mnuTaiKhoan.Image = (Image)resources.GetObject("mnuTaiKhoan.Image");
            mnuTaiKhoan.Name = "mnuTaiKhoan";
            mnuTaiKhoan.Size = new Size(192, 26);
            mnuTaiKhoan.Text = "Tài khoản";
            mnuTaiKhoan.Click += mnuTaiKhoan_Click;
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            báoCáoThốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuBanHang, mnuDoanhThu });
            báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            báoCáoThốngKêToolStripMenuItem.Size = new Size(152, 24);
            báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo - Thống kê";
            // 
            // mnuBanHang
            // 
            mnuBanHang.Image = (Image)resources.GetObject("mnuBanHang.Image");
            mnuBanHang.Name = "mnuBanHang";
            mnuBanHang.Size = new Size(161, 26);
            mnuBanHang.Text = "Bán hàng";
            mnuBanHang.Click += mnuBanHang_Click;
            // 
            // mnuDoanhThu
            // 
            mnuDoanhThu.Image = (Image)resources.GetObject("mnuDoanhThu.Image");
            mnuDoanhThu.Name = "mnuDoanhThu";
            mnuDoanhThu.Size = new Size(161, 26);
            mnuDoanhThu.Text = "Doanh thu";
            mnuDoanhThu.Click += mnuDoanhThu_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(78, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // gioithieiu
            // 
            gioithieiu.DropDownItems.AddRange(new ToolStripItem[] { mnuHDSD, mnuThongTinPM });
            gioithieiu.Name = "gioithieiu";
            gioithieiu.Size = new Size(181, 24);
            gioithieiu.Text = "Giới thiệu về phần mềm";
            // 
            // mnuHDSD
            // 
            mnuHDSD.Image = (Image)resources.GetObject("mnuHDSD.Image");
            mnuHDSD.Name = "mnuHDSD";
            mnuHDSD.Size = new Size(230, 26);
            mnuHDSD.Text = "Hướng dẫn sử dụng";
            mnuHDSD.Click += mnuHDSD_Click;
            // 
            // mnuThongTinPM
            // 
            mnuThongTinPM.Image = (Image)resources.GetObject("mnuThongTinPM.Image");
            mnuThongTinPM.Name = "mnuThongTinPM";
            mnuThongTinPM.Size = new Size(230, 26);
            mnuThongTinPM.Text = "Thông tin phần mềm";
            mnuThongTinPM.Click += mnuThongTinPM_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
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
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(151, 20);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(151, 20);
            toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý bán sách";
            WindowState = FormWindowState.Maximized;
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
        private ToolStripMenuItem menuDoanhThu;
        private ToolStripMenuItem menuBanhang;
        private ToolStripMenuItem menuTroGiup;
        private ToolStripMenuItem menuHDSD;
        private ToolStripMenuItem menuThongTinPM;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem mnuDanhNhap;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem gioithieiu;
        private ToolStripMenuItem mnuDanhMucSach;
        private ToolStripMenuItem mnuKhoSach;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuBanHang;
        private ToolStripMenuItem mnuDoanhThu;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuHDSD;
        private ToolStripMenuItem mnuThongTinPM;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuTaiKhoan;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
    }
}