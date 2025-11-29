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
        public static int QuyenHan = -1;
        public static string TenNhanVien = "";
        public main()
        {
            Flash flash = new Flash();
            flash.ShowDialog();

            InitializeComponent();
        }
        private void KhoaChucNang(bool khoa)
        {
            menuQuanLy.Enabled = !khoa;
            menuKinhDoanh.Enabled = !khoa;
            menuThongKe.Enabled = !khoa;

            menuDangNhap.Enabled = khoa;
            menuDangXuat.Enabled = !khoa;
        }


        private void MoForm(Form frm)
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

        private void main_Load(object sender, EventArgs e)
        {
            KhoaChucNang(true);
        }

        private void menuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap frm = new DangNhap();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Sau khi đăng nhập thành công
                KhoaChucNang(false);
                Text = "Quản lý Bán Sách - Xin chào: " + TenNhanVien;

                // Phân quyền: Nếu là Nhân viên (0) thì ẩn Thống kê và Quản lý NV
                if (QuyenHan == 0)
                {
                    menuThongKe.Visible = false;
                    menuQuanLy.Visible = false;
                }
                else
                {
                    menuThongKe.Visible = true;
                    menuQuanLy.Visible = true;
                }
            }
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
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

                KhoaChucNang(true);
            }
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuKhoSach_Click(object sender, EventArgs e)
        {
            MoForm(new KhoSach());
        }

        private void menuBanhang_Click(object sender, EventArgs e)
        {
            MoForm(new BanHang());
        }

        private void menuKhachHang_Click(object sender, EventArgs e)
        {
            MoForm(new KhachHang());
        }

        private void menuDoanhThu_Click(object sender, EventArgs e)
        {
            MoForm(new DoanhThu());
        }

        private void menuDanhMucSach_Click(object sender, EventArgs e)
        {
            MoForm(new DanhMucSach());
        }

        private void menuThongTinPM_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.ShowDialog();
        }
    }
}
