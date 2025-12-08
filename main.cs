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

        string taiKhoanHienTai = "";
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
            while (true) // Chạy vòng lặp cho đến khi đăng nhập thành công hoặc Cancel
            {
                // 1. KHỞI TẠO FORM VÀ HIỂN THỊ
                DangNhap loginForm = new DangNhap();

                // Hiển thị Form đăng nhập. Nếu người dùng nhấn Cancel, thoát khỏi hàm.
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                // 2. LẤY DỮ LIỆU ĐÃ ĐƯỢC XÁC THỰC LÀ ĐÃ NHẬP
                string username = loginForm.LoggedInUsername;
                string password = loginForm.LoggedInPassword;

                // Vì Form DangNhap đã đóng/Dispose, phải kiểm tra dữ liệu trước.
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    // Nếu dữ liệu bị mất (dù DialogResult=OK), hiển thị lỗi chung và tiếp tục.
                    MessageBox.Show("Đã xảy ra lỗi hệ thống khi lấy thông tin đăng nhập. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                // 3. TRUY VẤN DATABASE VÀ XÁC THỰC

                MyDataTable dtAccount = new MyDataTable();

                try
                {
                    if (!dtAccount.OpenConnection())
                    {
                        MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra Connection String.", "Lỗi Kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string sql = "SELECT * FROM TaiKhoan WHERE Account = @TDN";

                    SqlCommand cmd = new SqlCommand(sql);
                    cmd.Parameters.Add("@TDN", SqlDbType.NVarChar, 50).Value = username;

                    // Dùng hàm Fill của MyDataTable để đổ dữ liệu vào dtAccount
                    dtAccount.Fill(cmd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi trong quá trình truy vấn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4. Xử lý kết quả truy vấn và Xác thực
                if (dtAccount.Rows.Count > 0)
                {
                    string matKhauMaHoa = dtAccount.Rows[0]["MatKhau"].ToString();
                    string quyenHan = dtAccount.Rows[0]["ChucVu"].ToString();
                    
                    // ... (đoạn kiểm tra mật khẩu rỗng giữ nguyên) ...

                    // 5. Xác thực BCrypt
                    if (BC.Verify(password, matKhauMaHoa))
                    {
                        // ĐĂNG NHẬP THÀNH CÔNG
                        hoVaTen = dtAccount.Rows[0]["TenNhanVien"].ToString();
                        
                        // Lưu lại Account để dùng cho việc ghi hóa đơn (Khớp với khóa ngoại SQL)
                        taiKhoanHienTai = dtAccount.Rows[0]["Account"].ToString(); 

                        using (WelcomeForm welcomeForm = new WelcomeForm(hoVaTen))
                        {
                            welcomeForm.ShowDialog();
                        }

                        if (quyenHan == "1")
                            QuanTriVien();
                        else if (quyenHan == "0")
                            NhanVien();
                        else
                            ChuaDangNhap();

                        return; // Thoát khỏi hàm DangNhap khi thành công
                    }
                    else
                    {
                        // MẬT KHẨU SAI
                        MessageBox.Show("Mật khẩu không chính xác! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Form DangNhap đã đóng, cần mở lại trong vòng lặp tiếp theo
                        // Chúng ta không thể truy cập txtMatKhau.Focus() nữa, nên chỉ cần continue.
                        continue;
                    }
                }
                else
                {
                    // TÊN ĐĂNG NHẬP SAI
                    MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Form DangNhap đã đóng, chỉ cần continue để tạo Form mới.
                    continue;
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
            /*
            if (banHang == null || banHang.IsDisposed)
            {
                banHang = new BanHang();
                banHang.MdiParent = this;
                banHang.Show();
            }
            */
            if (banHang == null || banHang.IsDisposed)
            {
                banHang = new BanHang();

                // --- THÊM DÒNG NÀY ---
                // Truyền tài khoản đang đăng nhập sang form Bán Hàng
                banHang.CurrentNguoiBan = taiKhoanHienTai;

                banHang.MdiParent = this;
                banHang.Show();
            }
            else // Trường hợp form đã mở nhưng bị ẩn, cần kích hoạt lại và cập nhật người bán
            {
                banHang.CurrentNguoiBan = taiKhoanHienTai;
                banHang.Activate();
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
            if (banHang == null || banHang.IsDisposed)
            {
                banHang = new BanHang();

                // --- THÊM DÒNG NÀY ---
                // Truyền tài khoản đang đăng nhập sang form Bán Hàng
                banHang.CurrentNguoiBan = taiKhoanHienTai;

                banHang.MdiParent = this;
                banHang.Show();
            }
            else // Trường hợp form đã mở nhưng bị ẩn, cần kích hoạt lại và cập nhật người bán
            {
                banHang.CurrentNguoiBan = taiKhoanHienTai;
                banHang.Activate();
            }
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
