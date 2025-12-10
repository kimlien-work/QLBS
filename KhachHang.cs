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
    public partial class KhachHang : Form
    {
        MyDataTable dataTable = new MyDataTable();
        string maKhachHang = "";
        private string placeholderText = "Nhập tên khách cần tìm...";
        public KhachHang()
        {
            InitializeComponent();
            dataTable.OpenConnection();

            txtTimKiem.Text = placeholderText;
            txtTimKiem.ForeColor = Color.Gray;
        }
        #region Lấy Dữ Liệu
        private void LayDuLieu()
        {
            dgvKhachHang.AutoGenerateColumns = false;

            SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang");

            dataTable.Fill(cmd);
            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;

            dgvKhachHang.DataSource = binding;

            txtMaKH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtDiemTichLuy.DataBindings.Clear();

            txtMaKH.DataBindings.Add("Text", binding, "MaKH");
            txtTenKH.DataBindings.Add("Text", binding, "TenKH");
            txtSDT.DataBindings.Add("Text", binding, "SDT");
            txtEmail.DataBindings.Add("Text", binding, "Email");
            txtDiaChi.DataBindings.Add("Text", binding, "DiaChi");
            txtDiemTichLuy.DataBindings.Add("Text", binding, "DiemTichLuy");
        }
        #endregion

        #region Bật Tắt
        private void BatTat(bool giaTri)
        {
            txtTenKH.Enabled = giaTri;
            txtSDT.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtEmail.Enabled = giaTri;


            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;

            txtMaKH.Enabled = false;
            txtDiemTichLuy.Enabled = false;
            txtSDT.Enabled = false;
        }
        #endregion


        private void KhachHang_Load(object sender, EventArgs e)
        {
            LayDuLieu();
            BatTat(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            maKhachHang = "";

            txtTenKH.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtDiemTichLuy.Text = "0";

            txtTenKH.Focus();

            BatTat(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            maKhachHang = txtMaKH.Text;
            BatTat(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "") return;

            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xoá khách hàng " + txtTenKH.Text + " không?",
                                              "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                try
                {
                    string sql = @"DELETE FROM KhachHang WHERE MaKH = @MaKH";
                    SqlCommand cmd = new SqlCommand(sql);
                    cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = int.Parse(txtMaKH.Text);

                    dataTable.Update(cmd);

                    LayDuLieu();
                    BatTat(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa khách hàng này (Có thể do họ đã có hóa đơn mua hàng).", "Lỗi CSDL");
                }
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTat(false);
            LayDuLieu();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (tuKhoa == "")
            {
                LayDuLieu();
                return;
            }
            string sql = @"SELECT * FROM KhachHang 
                   WHERE TenKH LIKE N'%' + @TuKhoa + '%' 
                   OR SDT LIKE '%' + @TuKhoa + '%'";

            SqlCommand cmd = new SqlCommand(sql);

            cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = tuKhoa;

            dataTable.Fill(cmd);

            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;

            dgvKhachHang.DataSource = binding;

            txtMaKH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtDiemTichLuy.DataBindings.Clear();

            txtMaKH.DataBindings.Add("Text", binding, "MaKH");
            txtTenKH.DataBindings.Add("Text", binding, "TenKH");
            txtSDT.DataBindings.Add("Text", binding, "SDT");
            txtEmail.DataBindings.Add("Text", binding, "Email");
            txtDiaChi.DataBindings.Add("Text", binding, "DiaChi");
            txtDiemTichLuy.DataBindings.Add("Text", binding, "DiemTichLuy");
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Tên khách hàng không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKH.Focus();
                return;
            }
            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return;
            }

            try
            {
                if (maKhachHang == "")
                {
                    string sql = @"INSERT INTO KhachHang (TenKH, SDT, Email, DiaChi, DiemTichLuy) 
                           VALUES(@TenKH, @SDT, @Email, @DiaChi, 0)";

                    SqlCommand cmd = new SqlCommand(sql);
                    cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar, 100).Value = txtTenKH.Text;
                    cmd.Parameters.Add("@SDT", SqlDbType.NVarChar, 20).Value = txtSDT.Text;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = txtEmail.Text;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200).Value = txtDiaChi.Text;

                    dataTable.Update(cmd);
                }
                else

                {
                    #region Trường hợp: SỬA
                    string sql = @"UPDATE KhachHang
                                   SET TenKH = @TenKH,
                                       SDT = @SDT,
                                       Email = @Email,
                                       DiaChi = @DiaChi
                                   WHERE MaKH = @MaKH";

                    SqlCommand cmd = new SqlCommand(sql);

                    cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = int.Parse(maKhachHang);
                    cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar, 100).Value = txtTenKH.Text;
                    //cmd.Parameters.Add("@SDT", SqlDbType.NVarChar, 20).Value = txtSDT.Text;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = txtEmail.Text;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200).Value = txtDiaChi.Text;

                    dataTable.Update(cmd);
                    #endregion
                }

                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LayDuLieu();
                BatTat(false);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == placeholderText)
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black; // Đổi màu chữ thành đen để nhập liệu
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = placeholderText; // Gán lại chuỗi gợi ý
                txtTimKiem.ForeColor = Color.Gray; // Đặt lại màu chữ xám
            }
        }
    }
}
