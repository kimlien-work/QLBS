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
using BC = BCrypt.Net.BCrypt;

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

            mnuDangNhap.Enabled = true;
            mnuDangXuat.Enabled = false;
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
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }

            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnDanhMucSach.Enabled = false;
            btnKhoSach.Enabled = false;
            btnKhachHang.Enabled = false;
            btnTaiKhoan.Enabled = true;
            btnBanHang.Enabled = false;
            btnDoanhThu.Enabled = true;

            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;
            mnuDanhMucSach.Enabled = false;
            mnuKhoSach.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuTaiKhoan.Enabled = true;
            mnuBanHang.Enabled = false;
            mnuDoanhThu.Enabled = true;

            lblTrangThai.Text = "Quản trị viên " + hoVaTen;
        }

        public void NhanVien()
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }

            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnDanhMucSach.Enabled = true;
            btnKhoSach.Enabled = true;
            btnKhachHang.Enabled = true;
            btnTaiKhoan.Enabled = false;
            btnBanHang.Enabled = true;
            btnDoanhThu.Enabled = false;

            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;
            mnuDanhMucSach.Enabled = true;
            mnuKhoSach.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuTaiKhoan.Enabled = false;
            mnuBanHang.Enabled = true;
            mnuDoanhThu.Enabled = false;

            lblTrangThai.Text = "Nhân viên " + hoVaTen;
        }

        private void DangNhap()
        {
            /*LamLai:
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
                }*/
            // Đảm bảo Form DangNhap luôn được tạo mới hoặc xử lý đúng cách
            if (dangNhap == null || dangNhap.IsDisposed)
            {
                dangNhap = new DangNhap();
            }

            // Sử dụng vòng lặp while để thay thế cho goto
            while (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string username = dangNhap.txtTenDangNhap.Text.Trim(); // Trim() để loại bỏ khoảng trắng
                string password = dangNhap.txtMatKhau.Text;

                // 1. Kiểm tra rỗng
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue; // Quay lại hiển thị Form DangNhap
                }
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue; // Quay lại hiển thị Form DangNhap
                }

                // 2. Truy vấn Database và Xác thực
                DataTable dtAccount = new DataTable();
                MyDataTable dataTable = new MyDataTable(); // Giả định MyDataTable có chứa ConnectionString()
                string connectionString = dataTable.ConnectionString();

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString)) // Đảm bảo kết nối được đóng
                    {
                        conn.Open();
                        // Chỉ cần tìm Account (Tên đăng nhập) để lấy mật khẩu băm
                        string sql = "SELECT TenNhanVien, ChucVu, MatKhau FROM TaiKhoan WHERE Account = @TDN";

                        using (SqlCommand cmd = new SqlCommand(sql, conn)) // Đảm bảo SqlCommand được giải phóng
                        {
                            cmd.Parameters.Add("@TDN", SqlDbType.NVarChar, 50).Value = username;
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dtAccount);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Lỗi nghiêm trọng, thoát khỏi hàm
                }

                // 3. Xử lý kết quả truy vấn
                if (dtAccount.Rows.Count > 0)
                {
                    string matKhauMaHoa = dtAccount.Rows[0]["MatKhau"].ToString();

                    // 4. Xác thực BCrypt
                    if (BC.Verify(password, matKhauMaHoa))
                    {
                        // Đăng nhập thành công
                        hoVaTen = dtAccount.Rows[0]["TenNhanVien"].ToString();
                        string quyenHan = dtAccount.Rows[0]["ChucVu"].ToString();

                        // Hiển thị màn hình chào mừng (nếu cần)
                        using (WelcomeForm welcomeForm = new WelcomeForm(hoVaTen))
                        {
                            welcomeForm.ShowDialog();
                        }

                        // Phân quyền
                        if (quyenHan == "1")
                            QuanTriVien();
                        else if (quyenHan == "0")
                            NhanVien();
                        else
                            ChuaDangNhap();

                        return; // Thoát khỏi vòng lặp và hàm DangNhap khi thành công
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Vòng lặp tiếp tục, hiển thị lại form đăng nhập
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Vòng lặp tiếp tục, hiển thị lại form đăng nhập
                }

                // Tái tạo form Đăng nhập để đảm bảo Form State sạch sẽ
                // (Tùy chọn, nếu bạn muốn form cũ đóng hẳn)
                if (dangNhap != null && !dangNhap.IsDisposed)
                {
                    dangNhap.Dispose();
                }
                dangNhap = new DangNhap();
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
