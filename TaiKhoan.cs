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
    public partial class TaiKhoan : Form
    {
        MyDataTable dataTable = new MyDataTable();
        BindingSource binding = new BindingSource();
        string maTaiKhoan = "";

        public TaiKhoan()
        {
            InitializeComponent();
            dataTable.OpenConnection();
            dgvTaiKhoan.AutoGenerateColumns = false;
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            LoadComboBoxChucVu();
            LayDuLieu();
            BatTat(false);
        }

        private void LoadComboBoxChucVu()
        {
            DataTable dtChucVu = new DataTable();
            dtChucVu.Columns.Add("MaCV", typeof(int));
            dtChucVu.Columns.Add("TenCV", typeof(string));

            dtChucVu.Rows.Add(1, "Quản Lý (Admin)");
            dtChucVu.Rows.Add(0, "Nhân Viên");

            cboChucVu.DataSource = dtChucVu;
            cboChucVu.DisplayMember = "TenCV";
            cboChucVu.ValueMember = "MaCV";
        }

        private void LayDuLieu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan");
            dataTable.Fill(cmd);

            binding.DataSource = dataTable;

            dgvTaiKhoan.DataSource = binding;

            // --- XÓA BINDING CŨ TRƯỚC KHI ADD MỚI (Tránh lỗi trùng lặp) ---
            txtID.DataBindings.Clear();
            txtAccount.DataBindings.Clear();
            //txtMatKhau.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Clear();
            cboChucVu.DataBindings.Clear();

            // --- THIẾT LẬP BINDING MỚI ---
            txtID.DataBindings.Add("Text", binding, "ID", true, DataSourceUpdateMode.Never);
            txtAccount.DataBindings.Add("Text", binding, "Account", true, DataSourceUpdateMode.Never);
            //txtMatKhau.DataBindings.Add("Text", binding, "MatKhau", true, DataSourceUpdateMode.Never);
            txtTenNhanVien.DataBindings.Add("Text", binding, "TenNhanVien", true, DataSourceUpdateMode.Never);

            // Binding cho ComboBox
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
            txtID.Text = "";
            txtAccount.Text = "";
            txtMatKhau.Text = "";
            txtTenNhanVien.Text = "";
            if (cboChucVu.Items.Count > 0) cboChucVu.SelectedIndex = 1;

            BatTat(true);
            txtAccount.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa trên danh sách!", "Thông báo");
                return;
            }
            BatTat(true);
            txtAccount.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            binding.CancelEdit();
            LayDuLieu();
            BatTat(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
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

                cmd.Parameters.Add("@Account", SqlDbType.NVarChar, 50).Value = txtAccount.Text;
                cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 100).Value = BC.HashPassword(txtMatKhau.Text);
                cmd.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar, 100).Value = txtTenNhanVien.Text;

                // Lấy giá trị int từ ComboBox (0 hoặc 1)
                cmd.Parameters.Add("@ChucVu", SqlDbType.Int).Value = cboChucVu.SelectedValue;

                // Thực thi Update xuống CSDL
                dataTable.Update(cmd);

                MessageBox.Show("Lưu thành công!", "Thông báo");
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

        private void dgvTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTaiKhoan.Columns[e.ColumnIndex].Name == "MatKhau")
            {
                e.Value = "••••••••••";
            }
        }
    }
}