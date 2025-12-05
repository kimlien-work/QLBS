using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBS
{
    public partial class DanhMucSach : Form
    {
        // 1. Khai báo biến toàn cục
        MyDataTable dataTable = new MyDataTable();
        BindingSource binding = new BindingSource();

        // Biến cờ hiệu để biết đang Thêm hay đang Sửa
        bool isThem = false;

        public DanhMucSach()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }

        private void DanhMucSach_Load(object sender, EventArgs e)
        {
            dgvDanhMuc.AutoGenerateColumns = false;

            LayDuLieu();
            BatTat(false); // Mặc định khóa các ô nhập
        }

        // --- HÀM LẤY DỮ LIỆU ---
        private void LayDuLieu()
        {
            // Lấy dữ liệu từ SQL
            SqlCommand cmd = new SqlCommand("SELECT * FROM DanhMuc");
            dataTable.Fill(cmd);

            binding.DataSource = dataTable;
            dgvDanhMuc.DataSource = binding;

            txtMaDM.DataBindings.Clear();
            txtTenDM.DataBindings.Clear();

            txtMaDM.DataBindings.Add("Text", binding, "MaDM", true, DataSourceUpdateMode.Never);
            txtTenDM.DataBindings.Add("Text", binding, "TenDanhMuc", true, DataSourceUpdateMode.Never);
        }

        // --- HÀM BẬT TẮT ---
        private void BatTat(bool cheDoNhap)
        {
            txtTenDM.Enabled = cheDoNhap;

            txtMaDM.Enabled = false;

            btnLuu.Enabled = cheDoNhap;
            btnHuy.Enabled = cheDoNhap;

            btnThem.Enabled = !cheDoNhap;
            btnSua.Enabled = !cheDoNhap;
            btnXoa.Enabled = !cheDoNhap;
        }

        // --- NÚT THÊM ---
        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true; // Đánh dấu đang thêm mới

            // Xóa trắng ô nhập liệu
            txtMaDM.Text = "";
            txtTenDM.Text = "";

            BatTat(true);
            txtTenDM.Focus();
        }

        // --- NÚT SỬA ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDM.Text))
            {
                MessageBox.Show("Vui lòng chọn danh mục cần sửa!", "Thông báo");
                return;
            }

            isThem = false; // Đánh dấu đang sửa
            BatTat(true);
            txtTenDM.Focus();
        }

        // --- NÚT HỦY ---
        private void btnHuy_Click(object sender, EventArgs e)
        {
            LayDuLieu();
            BatTat(false);
        }

        // --- NÚT LƯU ---
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDM.Text))
            {
                MessageBox.Show("Tên danh mục không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDM.Focus();
                return;
            }

            try
            {
                string sql = "";
                SqlCommand cmd = new SqlCommand();

                if (isThem)
                {
                    // TRƯỜNG HỢP THÊM:
                    sql = "INSERT INTO DanhMuc (TenDanhMuc) VALUES (@Ten)";
                    cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 100).Value = txtTenDM.Text;
                }
                else
                {
                    // TRƯỜNG HỢP SỬA:
                    sql = "UPDATE DanhMuc SET TenDanhMuc = @Ten WHERE MaDM = @Ma";
                    cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 100).Value = txtTenDM.Text;
                    cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = int.Parse(txtMaDM.Text);
                }

                cmd.CommandText = sql;

                // Thực thi lệnh
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

        // --- NÚT XÓA ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDM.Text)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa danh mục: " + txtTenDM.Text + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM DanhMuc WHERE MaDM = @Ma";
                    SqlCommand cmd = new SqlCommand(sql);
                    cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = int.Parse(txtMaDM.Text);

                    dataTable.Update(cmd);

                    MessageBox.Show("Xóa thành công!");
                    LayDuLieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa (Có thể danh mục này đang chứa Sách). Lỗi: " + ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}