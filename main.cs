using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBS
{
    public partial class main : Form
    {
        #region Biến toàn cục
        DanhMucSach danhMuc = null;
        KhoSach khoSach = null;
        KhachHang khachHang = null;
        TaiKhoan taiKhoan = null;
        BanHang banHang = null;
        DoanhThu doanhThu = null;
        DangNhap dangNhap = null;
        string hoVaTen = "";
        #endregion

        #region Hệ thống
        public main()
        {
            Flash flash = new Flash();
            flash.ShowDialog();

            InitializeComponent();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ChuaDangNhap()
        {
            btnDangNhap.Enabled = true;

            btnDangXuat.Enabled = false;
            btnDanhMucSach.Enabled = false;
            btnKhoSach.Enabled = false;
            btnKhachHang.Enabled = false;
            btnTaiKhoan.Enabled = false;
            btnBanHang.Enabled = false;
            btnDoanhThu.Enabled = false;

            
            mnuDangXuat.Enabled = true;
            mnuDanhMucSach.Enabled = false;
            mnuKhoSach.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuTaiKhoan.Enabled = false;
            mnuBanHang.Enabled = false;
            mnuDoanhThu.Enabled = false;

            lblTrangThai.Text = "Chưa đăng nhập";
        }

        public void QuanTriVien()
        {
            btnDangNhap.Enabled = false;

            btnDangXuat.Enabled = true;
            btnDanhMucSach.Enabled = false;
            btnKhoSach.Enabled = false;
            btnKhachHang.Enabled = false;
            btnTaiKhoan.Enabled = true;
            btnBanHang.Enabled = false;
            btnDoanhThu.Enabled = false;

            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;
            mnuDanhMucSach.Enabled = false;
            mnuKhoSach.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuTaiKhoan.Enabled = true;
            mnuBanHang.Enabled = false;
            mnuDoanhThu.Enabled = false;

            lblTrangThai.Text = "Quản trị viên " + hoVaTen;
        }

        public void NhanVien()
        {
            btnDangNhap.Enabled = false;

            btnDangXuat.Enabled = true;
            btnDanhMucSach.Enabled = true;
            btnKhoSach.Enabled = true;
            btnKhachHang.Enabled = true;
            btnTaiKhoan.Enabled = false;
            btnBanHang.Enabled = true;
            btnDoanhThu.Enabled = true;

            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;
            mnuDanhMucSach.Enabled = true;
            mnuKhoSach.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuTaiKhoan.Enabled = false;
            mnuBanHang.Enabled = true;
            mnuDoanhThu.Enabled = true;

            lblTrangThai.Text = "Nhân viên " + hoVaTen;
        }

        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new DangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.LoggedInUsername;
                if (dangNhap.txtTenDangNhap.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (dangNhap.txtMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else
                {
                    MyDataTable dataTable = new MyDataTable();
                    dataTable.OpenConnection();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE Account = @TDN AND MatKhau = @MK");
                    cmd.Parameters.Add("@TDN", SqlDbType.NVarChar, 50).Value = dangNhap.txtTenDangNhap.Text;
                    cmd.Parameters.Add("@MK", SqlDbType.NVarChar, 100).Value = dangNhap.txtMatKhau.Text;
                    dataTable.Fill(cmd);
                    if (dataTable.Rows.Count > 0)
                    {
                        hoVaTen = dataTable.Rows[0]["TenNhanVien"].ToString();
                        string quyenHan = dataTable.Rows[0]["ChucVu"].ToString();

                        using (WelcomeForm welcomeForm = new WelcomeForm(hoVaTen))
                        {
                            welcomeForm.ShowDialog(); // Chặn Form main
                        }

                        if (quyenHan == "1")
                            QuanTriVien();
                        else if (quyenHan == "0")
                            NhanVien();
                        else
                            ChuaDangNhap();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                }
            }
        }
        #endregion

        #region Quản lý
        private void mnuDanhMucSach_Click(object sender, EventArgs e)
        {
            if (danhMuc == null || danhMuc.IsDisposed)
            {
                danhMuc = new DanhMucSach();
                danhMuc.MdiParent = this;
                danhMuc.Show();
            }
        }

        private void mnuKhoSach_Click(object sender, EventArgs e)
        {
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

        private void mnuDanhNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void main_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }
        #endregion

        #region ToolBar

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            mnuDangXuat_Click(sender, e);
        }

        private void btnDanhMucSach_Click(object sender, EventArgs e)
        {
            mnuDanhMucSach_Click(sender, e);
        }

        private void btnKhoSach_Click(object sender, EventArgs e)
        {
            mnuKhoSach_Click(sender, e);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            mnuKhachHang_Click(sender, e);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            mnuTaiKhoan_Click(sender, e);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            mnuBanHang_Click(sender, e);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            mnuDoanhThu_Click(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            mnuThoat_Click(sender, e);
        }
        #endregion
    }
}
