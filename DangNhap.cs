using System;
using System.Data;
using System.Data.SqlClient; // Thư viện kết nối SQL
using System.Windows.Forms;
using System.Threading.Tasks;

namespace QLBS
{
    public partial class DangNhap : Form
    {
        private const string con = @"Server=.\SQLEXPRESS;Database=QLBS;Integrated Security=True";
        public string LoggedInUsername { get; private set; }
        public DangNhap()
        {
            InitializeComponent();
        }

        // Hàm quản lý hiển thị loading
        private void ToggleLoading(bool isLoading)
        {
            pnlLoading.Visible = isLoading;
            // Đảm bảo Form được cập nhật ngay lập tức
            this.Refresh();

            txtTenDangNhap.Enabled = !isLoading;
            txtMatKhau.Enabled = !isLoading;
            btnDangNhap.Enabled = !isLoading;
            btnHuyBo.Enabled = !isLoading; // Vô hiệu hóa nút Hủy bỏ
        }

        // Hàm mô phỏng kiểm tra đăng nhập (Thay thế bằng Database/API)
        private async Task<bool> PerformLoginCheck(string username, string password)
        {
            // Loại bỏ dấu cách thừa khỏi Tên đăng nhập và Mật khẩu
            string trimmedUsername = username.Trim();
            string trimmedPassword = password.Trim();

            // Chuỗi truy vấn an toàn (Sử dụng tham số để tránh SQL Injection)
            string query = "SELECT COUNT(1) FROM TaiKhoan WHERE Account = @user AND MatKhau = @pass";

            using (SqlConnection conn = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // 1. Sử dụng tham số để truyền giá trị
                    cmd.Parameters.AddWithValue("@user", trimmedUsername);
                    cmd.Parameters.AddWithValue("@pass", trimmedPassword); // *Giả sử mật khẩu chưa mã hóa*

                    try
                    {
                        // Mô phỏng độ trễ MẠNG (nếu cần) + mở kết nối
                        await Task.Delay(500); // Có thể giữ một độ trễ nhỏ để loading mượt hơn
                        await conn.OpenAsync();

                        // 2. Thực thi truy vấn và lấy kết quả (số lượng hàng khớp)
                        int count = (int)await cmd.ExecuteScalarAsync();

                        // Trả về true nếu tìm thấy 1 hàng khớp (đăng nhập thành công)
                        return count == 1;
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi kết nối/Database
                        MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    finally
                    {
                        // Đảm bảo kết nối được đóng
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Bật Loading
            ToggleLoading(true);

            // 2. Chờ kết quả kiểm tra
            bool success = await PerformLoginCheck(username, password);

            // 3. Tắt Loading
            ToggleLoading(false);

            // 4. Xử lý kết quả
            if (success)
            {
                // ✅ LƯU tên người dùng đã nhập thành công (đã được Trim trong PerformLoginCheck)
                this.LoggedInUsername = username;

                // ✅ Thiết lập DialogResult để Form main biết thành công
                this.DialogResult = DialogResult.OK;
                this.Close(); // Đóng Form Đăng nhập
            }
            else
            {
                // Thất bại
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi Đăng nhập",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtTenDangNhap.Focus();
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}