using QLBS;
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
    public partial class DanhMucSach : Form
    {
        MyDataTable dataTable = new MyDataTable();
        string maDM = ""; // Lưu mã cũ khi sửa/xóa
        bool isThem = false; // Biến cờ kiểm tra đang Thêm hay Sửa
        public DanhMucSach()
        {
            InitializeComponent();
            // Mở kết nối ngay khi khởi tạo form
            dataTable.OpenConnection();
        }
        private void LayDuLieu()
        {// 1. Lấy dữ liệu từ SQL đổ vào dataTable
            SqlCommand cmd = new SqlCommand("SELECT * FROM DanhMuc");
            dataTable.Fill(cmd);

            // 2. Tạo BindingSource để kết nối dữ liệu
            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;

            // 3. Đổ dữ liệu vào DataGridView
            dgvDanhMuc.DataSource = binding;

            // 4. Binding dữ liệu vào TextBox (Code tay như Buoi08 trang 4-5)
            txtMaDM.DataBindings.Clear();
            txtTenDM.DataBindings.Clear();

            // Lưu ý: "MaDM" và "TenDanhMuc" là tên cột trong SQL của bạn
            txtMaDM.DataBindings.Add("Text", binding, "MaDM", true, DataSourceUpdateMode.Never);
            txtTenDM.DataBindings.Add("Text", binding, "TenDanhMuc", true, DataSourceUpdateMode.Never);
        }
        

        private void BatTat(bool giatri)
        {
            txtTenDM.Enabled = giatri;

            btnLuu.Enabled = giatri;
            btnHuy.Enabled = giatri;

            btnThem.Enabled = !giatri;
            btnSua.Enabled = !giatri;
            btnXoa.Enabled = !giatri;
        }

        private void DanhMucSach_Load(object sender, EventArgs e)
        {
            dgvDanhMuc.AutoGenerateColumns = false; // Tắt tự sinh cột
            LayDuLieu();
            BatTat(false); // Mặc định là chế độ Xem
        }


        private void btnThem_Click_1(object sender, EventArgs e)
        {
            // 1. Đánh dấu là đang THÊM MỚI
            isThem = true;

            // 2. Xóa trắng ô nhập liệu để người dùng nhập mới
            txtMaDM.Text = ""; // Mã để trống (SQL tự sinh)
            txtTenDM.Clear();

            // 3. Bật chế độ nhập liệu (Sáng nút Lưu/Hủy)
            BatTat(true);

            // 4. Đưa con trỏ chuột vào ô Tên cho tiện
            txtTenDM.Focus();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn dòng nào chưa
            if (string.IsNullOrEmpty(txtMaDM.Text))
            {
                MessageBox.Show("Vui lòng chọn danh mục cần sửa!");
                return;
            }

            // 1. Đánh dấu là đang SỬA (CẬP NHẬT)
            isThem = false;

            // 2. Không xóa ô text, giữ nguyên dữ liệu cũ để người dùng sửa
            // 3. Bật chế độ nhập liệu
            BatTat(true);

            txtTenDM.Focus();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu rỗng (Validate)
            if (string.IsNullOrWhiteSpace(txtTenDM.Text))
            {
                MessageBox.Show("Tên danh mục không được để trống!");
                txtTenDM.Focus();
                return;
            }

            try
            {
                string sql = "";
                SqlCommand cmd = new SqlCommand();

                // 2. Quyết định câu lệnh SQL
                if (isThem == true)
                {
                    // Thêm mới: Chỉ cần INSERT tên, Mã tự động tăng
                    sql = "INSERT INTO DanhMuc (TenDanhMuc) VALUES (@TenDM)";
                    cmd.Parameters.Add("@TenDM", SqlDbType.NVarChar).Value = txtTenDM.Text;
                }
                else
                {
                    // Cập nhật: Phải có WHERE theo Mã
                    sql = "UPDATE DanhMuc SET TenDanhMuc = @TenDM WHERE MaDM = @MaDM";
                    cmd.Parameters.Add("@TenDM", SqlDbType.NVarChar).Value = txtTenDM.Text;
                    cmd.Parameters.Add("@MaDM", SqlDbType.Int).Value = int.Parse(txtMaDM.Text);
                }

                cmd.CommandText = sql;

                // 3. Gọi hàm thực thi bên MyDataTable
                if (dataTable.Update(cmd) > 0)
                {
                    MessageBox.Show("Lưu thành công!");

                    // 4. Tải lại dữ liệu lên lưới để thấy thay đổi
                    LayDuLieu();

                    // 5. Quay về chế độ xem bình thường
                    BatTat(false);
                }
                else
                {
                    MessageBox.Show("Lưu thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            // 1. Tắt chế độ nhập liệu
            BatTat(false);

            // 2. Reset lại dữ liệu trong ô text về dòng đang chọn trên lưới
            if (dgvDanhMuc.CurrentRow != null)
            {
                txtMaDM.Text = dgvDanhMuc.CurrentRow.Cells["MaDM"].Value.ToString();
                txtTenDM.Text = dgvDanhMuc.CurrentRow.Cells["TenDanhMuc"].Value.ToString();
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn dòng chưa
            if (string.IsNullOrEmpty(txtMaDM.Text)) return;

            // 1. Hiện hộp thoại xác nhận
            DialogResult traloi = MessageBox.Show("Bạn chắc chắn muốn xóa danh mục: " + txtTenDM.Text + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (traloi == DialogResult.Yes)
            {
                try
                {
                    // 2. Thực hiện xóa
                    string sql = "DELETE FROM DanhMuc WHERE MaDM = @MaDM";
                    SqlCommand cmd = new SqlCommand(sql);
                    cmd.Parameters.Add("@MaDM", SqlDbType.Int).Value = int.Parse(txtMaDM.Text);

                    if (dataTable.Update(cmd) > 0)
                    {
                        MessageBox.Show("Đã xóa xong!");
                        LayDuLieu(); // Load lại lưới

                        // Reset lại ô nhập liệu
                        txtMaDM.Clear();
                        txtTenDM.Clear();
                    }
                }
                catch (Exception ex)
                {
                    // 3. Bắt lỗi quan hệ (Ví dụ: Danh mục Sách Giáo Khoa đang có sách thì không xóa được)
                    MessageBox.Show("Không thể xóa danh mục này vì dữ liệu đang được sử dụng!\n" + ex.Message, "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
