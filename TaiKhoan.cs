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
    public partial class TaiKhoan : Form
    {
        // Khởi tạo lớp kết nối CSDL (Đảm bảo lớp MyDataTable của bạn đã hoạt động đúng)
        MyDataTable dataTable = new MyDataTable();

        // Biến BindingSource để quản lý việc đồng bộ dữ liệu giữa Grid và Textbox
        BindingSource binding = new BindingSource();

        public TaiKhoan()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            // 1. Nạp dữ liệu cho ComboBox chức vụ trước
            LoadComboBoxChucVu();

            // 2. Lấy dữ liệu lên Grid và Binding
            LayDuLieu();

            // 3. Thiết lập trạng thái ban đầu
            BatTat(false);
        }

        // Hàm tạo dữ liệu giả cho ComboBox Chức vụ (Admin/Nhân viên)
        private void LoadComboBoxChucVu()
        {
            DataTable dtChucVu = new DataTable();
            dtChucVu.Columns.Add("MaCV", typeof(int));
            dtChucVu.Columns.Add("TenCV", typeof(string));

            // Thêm dòng dữ liệu: 1 là Admin, 0 là Nhân viên (Khớp với quy ước trong SQL)
            dtChucVu.Rows.Add(1, "Quản Lý (Admin)");
            dtChucVu.Rows.Add(0, "Nhân Viên");

            cboChucVu.DataSource = dtChucVu;
            cboChucVu.DisplayMember = "TenCV"; // Hiển thị tên
            cboChucVu.ValueMember = "MaCV";    // Giá trị ngầm là số (int)
        }

        private void LayDuLieu()
        {
            // Ngăn Grid tự tạo cột linh tinh, chỉ dùng cột đã thiết kế trong Design
            dgvTaiKhoan.AutoGenerateColumns = false;

            // Lấy dữ liệu từ SQL
            SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan");
            dataTable.Fill(cmd);

            // Gán dữ liệu vào BindingSource
            binding.DataSource = dataTable;

            // Gán BindingSource vào DataGridView
            dgvTaiKhoan.DataSource = binding;

            // --- XÓA BINDING CŨ TRƯỚC KHI ADD MỚI (Tránh lỗi trùng lặp) ---
            txtID.DataBindings.Clear();
            txtAccount.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Clear();
            cboChucVu.DataBindings.Clear();

            // --- THIẾT LẬP BINDING MỚI ---
            // Tham số thứ 3 ("Account", "MatKhau"...) phải khớp với tên cột trong SQL Table
            txtID.DataBindings.Add("Text", binding, "ID", true, DataSourceUpdateMode.Never);
            txtAccount.DataBindings.Add("Text", binding, "Account", true, DataSourceUpdateMode.Never);
            txtMatKhau.DataBindings.Add("Text", binding, "MatKhau", true, DataSourceUpdateMode.Never);
            txtTenNhanVien.DataBindings.Add("Text", binding, "TenNhanVien", true, DataSourceUpdateMode.Never);

            // Binding cho ComboBox (SelectedValue sẽ ăn theo cột ChucVu của dòng đang chọn)
            cboChucVu.DataBindings.Add("SelectedValue", binding, "ChucVu", true, DataSourceUpdateMode.Never);
        }

        private void BatTat(bool giaTri)
        {
            txtTenNhanVien.Enabled = giaTri;
            txtAccount.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboChucVu.Enabled = giaTri;

            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;

            // ID luôn luôn bị khóa (vì là tự tăng)
            txtID.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Xóa trắng các ô nhập liệu để nhập mới
            txtID.Text = ""; // ID rỗng để nhận biết là đang Thêm mới
            txtAccount.Text = "";
            txtMatKhau.Text = "";
            txtTenNhanVien.Text = "";
            if (cboChucVu.Items.Count > 0) cboChucVu.SelectedIndex = 1; // Mặc định chọn Nhân viên

            BatTat(true);
            txtAccount.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Nếu không có ID (chưa chọn dòng nào) thì báo lỗi
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa trên danh sách!", "Thông báo");
                return;
            }
            BatTat(true);
            // Khi sửa thì không cho sửa Tên đăng nhập (Account) - Tùy nghiệp vụ
            txtAccount.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Hủy bỏ thao tác, load lại dữ liệu gốc từ Binding
            binding.CancelEdit();
            LayDuLieu();
            BatTat(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu rỗng
            if (string.IsNullOrWhiteSpace(txtAccount.Text)) { MessageBox.Show("Chưa nhập tài khoản!"); txtAccount.Focus(); return; }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text)) { MessageBox.Show("Chưa nhập mật khẩu!"); txtMatKhau.Focus(); return; }
            if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text)) { MessageBox.Show("Chưa nhập tên nhân viên!"); txtTenNhanVien.Focus(); return; }

            try
            {
                SqlCommand cmd;
                string sql;

                // --- TRƯỜNG HỢP THÊM MỚI (txtID rỗng) ---
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    sql = @"INSERT INTO TaiKhoan (Account, MatKhau, TenNhanVien, ChucVu) 
                            VALUES(@Account, @MatKhau, @TenNhanVien, @ChucVu)";
                    cmd = new SqlCommand(sql);
                }
                // --- TRƯỜNG HỢP SỬA (txtID có số) ---
                else
                {
                    sql = @"UPDATE TaiKhoan 
                            SET MatKhau = @MatKhau, 
                                TenNhanVien = @TenNhanVien, 
                                ChucVu = @ChucVu 
                            WHERE ID = @ID";
                    cmd = new SqlCommand(sql);
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(txtID.Text);
                }

                // Gán tham số chung
                cmd.Parameters.Add("@Account", SqlDbType.NVarChar, 50).Value = txtAccount.Text;
                cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 100).Value = txtMatKhau.Text;
                cmd.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar, 100).Value = txtTenNhanVien.Text;

                // Lấy giá trị int từ ComboBox (0 hoặc 1)
                cmd.Parameters.Add("@ChucVu", SqlDbType.Int).Value = cboChucVu.SelectedValue;

                // Thực thi Update xuống CSDL
                dataTable.Update(cmd);

                MessageBox.Show("Lưu thành công!", "Thông báo");
                LayDuLieu(); // Tải lại để cập nhật Grid và ID mới
                BatTat(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;

            if (MessageBox.Show("Bạn có chắc muốn xoá " + txtTenNhanVien.Text + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM TaiKhoan WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(sql);
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(txtID.Text);

                    dataTable.Update(cmd);
                    LayDuLieu();
                    BatTat(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa (Có thể tài khoản này đã tạo hóa đơn): " + ex.Message);
                }
            }
        }
    }
}