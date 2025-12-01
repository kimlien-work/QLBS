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

        public main()
        {
            Flash flash = new Flash();
            flash.ShowDialog();

            InitializeComponent();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {

        }

        private void mnuDanhMucSach_Click(object sender, EventArgs e)
        {
            if(danhMuc == null || danhMuc.IsDisposed)
            {
                danhMuc = new DanhMucSach();
                danhMuc.MdiParent = this;
                danhMuc.Show();
            }
        }

        private void mnuKhoSach_Click(object sender, EventArgs e)
        {
            if(khoSach == null || khoSach.IsDisposed)
            {
                khoSach = new KhoSach();
                khoSach .MdiParent = this;
                khoSach .Show();
            }
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
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
            if (banHang == null || banHang.IsDisposed)
            {
                banHang = new BanHang();
                banHang.MdiParent = this;
                banHang.Show();
            }
        }

        private void mnuDoanhThu_Click(object sender, EventArgs e)
        {
            if (doanhThu == null || doanhThu.IsDisposed)
            {
                doanhThu = new DoanhThu();
                doanhThu.MdiParent = this;
                doanhThu.Show();
            }
        }

        private void mnuHDSD_Click(object sender, EventArgs e)
        {

        }

        private void mnuThongTinPM_Click(object sender, EventArgs e)
        {

        }

        public void ChuaDangNhap()
        {
            
        }
    }
}
