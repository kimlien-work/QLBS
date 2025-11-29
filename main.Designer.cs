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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            khoSáchToolStripMenuItem = new ToolStripMenuItem();
            danhMụcSáchToolStripMenuItem = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            kinhDoanhToolStripMenuItem = new ToolStripMenuItem();
            trợToolStripMenuItem = new ToolStripMenuItem();
            doanhThuToolStripMenuItem = new ToolStripMenuItem();
            bánHàngToolStripMenuItem = new ToolStripMenuItem();
            hDSDPMToolStripMenuItem = new ToolStripMenuItem();
            thôngTinPMToolStripMenuItem = new ToolStripMenuItem();
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
            // hệThốngToolStripMenuItem
            // 
            menuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { menuKhachHang, menuTaiKhoan, menuKhoSach, menuDanhMucSach });
            menuQuanLy.Name = "menuQuanLy";
            menuQuanLy.Size = new Size(75, 24);
            menuQuanLy.Text = "Quản Lý";
            // 
            // menuKhachHang
            // 
            đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            đăngNhậpToolStripMenuItem.Size = new Size(224, 26);
            đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            // 
            // menuTaiKhoan
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // menuKhoSach
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(224, 26);
            thoátToolStripMenuItem.Text = "Thoát";
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
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(224, 26);
            kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            // 
            // menuDoanhThu
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(224, 26);
            nhânViênToolStripMenuItem.Text = "Nhân Viên";
            // 
            // menuKinhDoanh
            // 
            khoSáchToolStripMenuItem.Name = "khoSáchToolStripMenuItem";
            khoSáchToolStripMenuItem.Size = new Size(224, 26);
            khoSáchToolStripMenuItem.Text = "Kho Sách";
            // 
            // menuBanhang
            // 
            danhMụcSáchToolStripMenuItem.Name = "danhMụcSáchToolStripMenuItem";
            danhMụcSáchToolStripMenuItem.Size = new Size(224, 26);
            danhMụcSáchToolStripMenuItem.Text = "Danh Mục Sách";
            // 
            // menuTroGiup
            // 
            menuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { menuHDSD, menuThongTinPM });
            menuTroGiup.Name = "menuTroGiup";
            menuTroGiup.Size = new Size(83, 24);
            menuTroGiup.Text = " Trợ Giúp";
            // 
            // kinhDoanhToolStripMenuItem
            // 
            menuHDSD.Name = "menuHDSD";
            menuHDSD.Size = new Size(224, 26);
            menuHDSD.Text = "HDSD PM";
            // 
            // trợToolStripMenuItem
            // 
            menuThongTinPM.Name = "menuThongTinPM";
            menuThongTinPM.Size = new Size(224, 26);
            menuThongTinPM.Text = "Thông Tin PM";
            menuThongTinPM.Click += menuThongTinPM_Click;
            // 
            // doanhThuToolStripMenuItem
            // 
            doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            doanhThuToolStripMenuItem.Size = new Size(224, 26);
            doanhThuToolStripMenuItem.Text = "Doanh Thu";
            // 
            // bánHàngToolStripMenuItem
            // 
            bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            bánHàngToolStripMenuItem.Size = new Size(224, 26);
            bánHàngToolStripMenuItem.Text = "Bán Hàng";
            // 
            // hDSDPMToolStripMenuItem
            // 
            hDSDPMToolStripMenuItem.Name = "hDSDPMToolStripMenuItem";
            hDSDPMToolStripMenuItem.Size = new Size(224, 26);
            hDSDPMToolStripMenuItem.Text = "HDSD PM";
            // 
            // toolStripStatusLabel2
            // 
            thôngTinPMToolStripMenuItem.Name = "thôngTinPMToolStripMenuItem";
            thôngTinPMToolStripMenuItem.Size = new Size(224, 26);
            thôngTinPMToolStripMenuItem.Text = "Thông Tin PM";
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