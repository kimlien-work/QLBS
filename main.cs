using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBS
{
    public partial class main : Form
    {
        DanhMucSach danhMuc = null;
        KhoSach khoSach = null;
        KhachHang khachHang = null;
        TaiKhoan taiKhoan = null;
        BanHang banHang = null;
        DoanhThu doanhThu = null;
        DangNhap dangNhap = null;
        string hoVaTen = "";


        //public static int QuyenHan = -1;
        //public static string TenNhanVien = "";
        public main()
        {
            Flash flash = new Flash();
            flash.ShowDialog();

            InitializeComponent();
        }

        /*
        private void BatTat(bool giatri)
        {
            mnuQuanLy.Enabled = !giatri;
            mnuThongKe.Enabled = !giatri;

            mnuDangNhap.Enabled = giatri;
            mnuDangXuat.Enabled = !giatri;
        }
        
        private void MoFormCon(Form frm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == frm.Name)
                {
                    f.Activate();
                    return;
                }
            }
            frm.MdiParent = this;
            frm.Show();
        }
        */
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuDanhMucSach_Click(object sender, EventArgs e)
        {
            //MoFormCon(new DanhMucSach());
            if (danhMuc == null || danhMuc.IsDisposed)
            {
                danhMuc = new DanhMucSach();
                danhMuc.MdiParent = this;
                danhMuc.Show();
            }
        }

        private void mnuKhoSach_Click(object sender, EventArgs e)
        {
            //MoFormCon(new KhoSach());
            if (khoSach == null || khoSach.IsDisposed)
            {
                khoSach = new KhoSach();
                khoSach.MdiParent = this;
                khoSach.Show();
            }
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            //MoFormCon(new KhachHang());
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new KhachHang();
                khachHang.MdiParent = this;
                khachHang.Show();
            }
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            if (taiKhoan == null || taiKhoan.IsDisposed)
            {
                taiKhoan = new TaiKhoan();
                taiKhoan.MdiParent = this;
                taiKhoan.Show();
            }
        }

        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            //MoFormCon(new BanHang());
            if (banHang == null || banHang.IsDisposed)
            {
                banHang = new BanHang();
                banHang.MdiParent = this;
                banHang.Show();
            }
        }

        private void mnuDoanhThu_Click(object sender, EventArgs e)
        {
            //MoFormCon(new DoanhThu());
            if (doanhThu == null || doanhThu.IsDisposed)
            {
                doanhThu = new DoanhThu();
                doanhThu.MdiParent = this;
                doanhThu.Show();
            }
        }

        private void mnuThongTinPM_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.ShowDialog();
        }

        public void ChuaDangNhap()
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
           //BatTat(true);
        }
        
        private void mnuDanhNhap_Click(object sender, EventArgs e)
        {
            /*
            DangNhap frm = new DangNhap();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BatTat(false);
                Text = "Quản lý Bán Sách - Xin chào: " + TenNhanVien;

                if (QuyenHan == 0)
                {
                    menuThongKe.Visible = false;
                    menuTaiKhoan.Visible = false;
                }
                else
                {
                    menuThongKe.Visible = true;
                    menuTaiKhoan.Visible = true;
                }
            }
            */
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            /*
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                QuyenHan = -1;
                TenNhanVien = "";
                Text = "Quản lý Bán Sách";

                // Đóng tất cả form con đang mở
                foreach (Form f in this.MdiChildren)
                {
                    f.Close();
                }

                BatTat(true);
            }
            */
        }
    }
}
