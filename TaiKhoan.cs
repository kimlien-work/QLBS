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
    public partial class TaiKhoan : Form
    {
        MyDataTable dataTable = new MyDataTable();
        string iD = "";
        public TaiKhoan()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }
        private void LayDuLieu()
        {
            dgvTaiKhoan.AutoGenerateColumns = false;

            SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan");

            dataTable.Fill(cmd);
            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;

            dgvTaiKhoan.DataSource = binding;

            txtID.DataBindings.Clear();
            txtAccount.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Clear();
            cboChucVu.DataBindings.Clear();

            txtID.DataBindings.Add("Text", binding, "ID");

            txtAccount.DataBindings.Add("Text", binding, "Account");

            txtMatKhau.DataBindings.Add("Text", binding, "MatKhau");

            txtTenNhanVien.DataBindings.Add("Text", binding, "TenNhanVien");

            cboChucVu.DataBindings.Add("SelectedValue", binding, "ChucVu");
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

            txtID.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtAccount.Clear();
            txtMatKhau.Clear();
            txtTenNhanVien.Clear();

            if (cboChucVu.Items.Count > 0) cboChucVu.SelectedIndex = 0;
            txtAccount.Focus();
            BatTat(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa trên danh sách!", "Thông báo");
                return;
            }
            BatTat(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LayDuLieu();
            BatTat(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text.Trim() == "")
            {
                MessageBox.Show("Tên tài khoản không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAccount.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }
            if (txtTenNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNhanVien.Focus();
                return;
            }

            try
            {
                SqlCommand cmd;
                string sql;

                // 2. Xử lý lưu xuống CSDL

                // TRƯỜNG HỢP: THÊM MỚI (Dựa vào việc txtID đang rỗng)
                if (txtID.Text == "")
                {
                    // Lưu ý: KHÔNG INSERT cột ID vì là IDENTITY (Tự tăng)
                    sql = @"INSERT INTO TaiKhoan (Account, MatKhau, TenNhanVien, ChucVu) 
                    VALUES(@Account, @MatKhau, @TenNhanVien, @ChucVu)";

                    cmd = new SqlCommand(sql);
                }
                // TRƯỜNG HỢP: SỬA (Dựa vào việc txtID đang có số)
                else
                {
                    sql = @"UPDATE TaiKhoan
                    SET Account = @Account,
                        MatKhau = @MatKhau,
                        TenNhanVien = @TenNhanVien,
                        ChucVu = @ChucVu
                    WHERE ID = @ID";

                    cmd = new SqlCommand(sql);
                    // UPDATE cần thêm tham số ID
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(txtID.Text);
                }

                // --- ÁNH XẠ THAM SỐ CHUNG ---
                cmd.Parameters.Add("@Account", SqlDbType.NVarChar, 50).Value = txtAccount.Text;
                cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 100).Value = txtMatKhau.Text;
                cmd.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar, 100).Value = txtTenNhanVien.Text;

                // Lấy Chức vụ từ ComboBox (Giả sử ValueMember là 0 hoặc 1)
                // Nếu dùng SelectedIndex: cmd.Parameters.Add("@ChucVu", SqlDbType.Int).Value = cboChucVu.SelectedIndex;
                cmd.Parameters.Add("@ChucVu", SqlDbType.Int).Value = cboChucVu.SelectedValue ?? 0;

                // Thực thi lệnh
                dataTable.Update(cmd);

                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại form
                LayDuLieu();
                BatTat(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa chọn ID thì không làm gì cả
            if (txtID.Text == "") return;

            // Hiển thị hộp thoại xác nhận
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xoá nhân viên " + txtTenNhanVien.Text + " không?",
                                              "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                try
                {
                    // Câu lệnh Delete cho bảng TaiKhoan
                    string sql = @"DELETE FROM TaiKhoan WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(sql);

                    // Tham số ID lấy từ Textbox (Khóa chính int)
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(txtID.Text);

                    dataTable.Update(cmd);

                    // Tải lại dữ liệu
                    LayDuLieu();
                    BatTat(false);

                    // Xóa trắng các ô sau khi xóa thành công
                    txtID.Clear();
                    txtAccount.Clear();
                    txtMatKhau.Clear();
                    txtTenNhanVien.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa nhân viên này (Có thể tài khoản này đang gắn với hóa đơn).", "Lỗi CSDL");
                }
            }
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            LayDuLieu();
            BatTat(false);
        }
    }
}
