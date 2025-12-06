using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBS
{
    public partial class DanhMucSach : Form
    {
        MyDataTable dataTable = new MyDataTable();
        string maDM = "";
        public DanhMucSach()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }

        private void DanhMucSach_Load(object sender, EventArgs e)
        {
            dgvDanhMuc.AutoGenerateColumns = false;

            LayDuLieu();
            BatTat(false);
        }
        #region HÀM LẤY DỮ LIỆU
        private void LayDuLieu()
                {
                    dataTable.OpenConnection();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM DanhMuc");
                    dataTable.Fill(cmd);

                    BindingSource binding = new BindingSource();
                    binding.DataSource = dataTable;

                    dgvDanhMuc.DataSource = binding;

                    txtMaDM.DataBindings.Clear();
                    txtTenDM.DataBindings.Clear();

                    txtMaDM.DataBindings.Add("Text", binding, "MaDM");
                    txtTenDM.DataBindings.Add("Text", binding, "TenDanhMuc");
                }
        #endregion

        #region HÀM BẬT TẮT
        private void BatTat(bool giaTri)
                {
                    txtMaDM.Enabled = false;
                    txtTenDM.Enabled = giaTri;

                    btnLuu.Enabled = giaTri;
                    btnHuy.Enabled = giaTri;

                    btnThem.Enabled = !giaTri;
                    btnSua.Enabled = !giaTri;
                    btnXoa.Enabled = !giaTri;
                }
        #endregion

        // --- NÚT THÊM ---
        private void btnThem_Click(object sender, EventArgs e)
        {
            maDM = "";

            txtMaDM.DataBindings.Clear();
            txtTenDM.DataBindings.Clear();

            txtMaDM.Text = "";
            txtTenDM.Text = "";

            txtTenDM.Focus();

            BatTat(true);
        }

        // --- NÚT SỬA ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            maDM = txtMaDM.Text;

            if (string.IsNullOrEmpty(maDM))
            {
                MessageBox.Show("Vui lòng chọn danh mục cần sửa!", "Thông báo");
                return;
            }
            BatTat(true);
            txtTenDM.Focus();
        }

        // --- NÚT HỦY ---
        private void btnHuy_Click(object sender, EventArgs e)
        {
            LayDuLieu();
            BatTat(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDM.Text.Trim() == "")
            {
                MessageBox.Show("Tên danh mục không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDM.Focus();
                return;
            }

            try
            {
                #region TRƯỜNG HỢP THÊM MỚI
                if (maDM == "")
                                {
                                    string sql = "INSERT INTO DanhMuc(TenDanhMuc) VALUES(@TenDanhMuc)";
                                    SqlCommand cmd = new SqlCommand(sql);

                                    cmd.Parameters.Add("@TenDanhMuc", SqlDbType.NVarChar, 100).Value = txtTenDM.Text;

                                    dataTable.Update(cmd);
                                }
                #endregion

                #region TRƯỜNG HỢP SỬA
                else
                                {
                                    string sql = "UPDATE DanhMuc SET TenDanhMuc = @TenDanhMuc WHERE MaDM = @MaDM";
                                    SqlCommand cmd = new SqlCommand(sql);

                                    cmd.Parameters.Add("@TenDanhMuc", SqlDbType.NVarChar, 100).Value = txtTenDM.Text;
                                    cmd.Parameters.Add("@MaDM", SqlDbType.Int).Value = Convert.ToInt32(maDM); // Convert về int vì SQL là int

                                    dataTable.Update(cmd);
                                }

                                MessageBox.Show("Lưu thành công!", "Thông báo");

                                LayDuLieu();
                                BatTat(false);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi: " + ex.Message);
                            }
                #endregion

                
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDM.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa danh mục: " + txtTenDM.Text + "?",
                                              "Xác nhận xóa",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM DanhMuc WHERE MaDM = @MaDM";
                    SqlCommand cmd = new SqlCommand(sql);
                    cmd.Parameters.Add("@MaDM", SqlDbType.Int).Value = Convert.ToInt32(txtMaDM.Text);

                    dataTable.Update(cmd);

                    // Load lại form
                    LayDuLieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa danh mục này (có thể do đang chứa sách). \nChi tiết: " + ex.Message);
                }
            }
        }
    }
}