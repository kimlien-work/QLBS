using System;
using System.Data;
using System.Data.SqlClient; // Thư viện kết nối SQL
using System.Windows.Forms;
using System.Threading.Tasks;

namespace QLBS
{
    public partial class DangNhap : Form
    {
        public string LoggedInUsername { get; private set; }
        public string LoggedInPassword { get; private set; }
        public DangNhap()
        {
            InitializeComponent();
        }

        // Hàm quản lý hiển thị loading
        private void ToggleLoading(bool isLoading)
        {
            pnlLoading.Visible = isLoading;
            this.Refresh();
            txtTenDangNhap.Enabled = !isLoading;
            txtMatKhau.Enabled = !isLoading;
            btnDangNhap.Enabled = !isLoading;
            btnHuyBo.Enabled = !isLoading;
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

            // 1. Bật Loading (Mô phỏng)
            ToggleLoading(true);

            // Tạm dừng 500ms để người dùng thấy trạng thái loading
            await Task.Delay(500);

            // 2. LƯU Tên đăng nhập và Mật khẩu
            this.LoggedInUsername = username.Trim();
            this.LoggedInPassword = password.Trim();

            // 3. Tắt Loading
            ToggleLoading(false);

            // 4. Trả về DialogResult.OK cho Form main xử lý
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}