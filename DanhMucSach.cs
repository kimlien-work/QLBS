using QLHS;
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
        bool isThem = false;
        string maDM = "";
        public DanhMucSach()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }
        private void LayDuLieu()
        {
            string sql = "SELECT * FROM DanhMuc";
            SqlCommand cmd = new SqlCommand(sql);
            dataTable.Fill(cmd);
            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;
            dgvDanhMuc.DataSource = binding;

            dgvDanhMuc.DataSource = binding;

            txtMaDM.DataBindings.Clear();   
            txtTenDM.DataBindings.Clear();
            txtMaDM.DataBindings.Add("Text", binding, "MaDM");
            txtTenDM.DataBindings.Add("Text", binding, "TenDanhMuc");
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
            dgvDanhMuc.AutoGenerateColumns = false;
            dgvDanhMuc.AllowUserToAddRows = false;
            dgvDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhMuc.MultiSelect = false;

            LayDuLieu();
            BatTat(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;

            txtMaDM.Text = ""; // Xóa mã cũ
            txtTenDM.Clear();

            txtTenDM.Focus();
            BatTat(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maDM))
            {
                MessageBox.Show("Vui lòng chọn danh mục cần sửa!");
                return;
            }
            isThem = false;
            BatTat(true);
            txtTenDM.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDM.Text.Trim() == "")
            {
                MessageBox.Show("Tên danh mục không được để trống!");
                return;
            }

            try
            {
                if (isThem) // --- TRƯỜNG HỢP THÊM MỚI ---
                {
                    // Không cần thêm MaDM vì SQL tự sinh số
                    string sql = "INSERT INTO DanhMuc (TenDanhMuc) VALUES (@TenDanhMuc)";
                    SqlCommand cmd = new SqlCommand(sql);
                    cmd.Parameters.Add("@TenDanhMuc", SqlDbType.NVarChar, 100).Value = txtTenDM.Text;

                    dataTable.Update(cmd);
                }
                else // --- TRƯỜNG HỢP SỬA ---
                {
                    // Lấy MaDM từ chính txtMaDM trên màn hình
                    string sql = "UPDATE DanhMuc SET TenDanhMuc = @TenDanhMuc WHERE MaDM = @MaDM";
                    SqlCommand cmd = new SqlCommand(sql);

                    // Tham số tên mới
                    cmd.Parameters.Add("@TenDanhMuc", SqlDbType.NVarChar, 100).Value = txtTenDM.Text;

                    // Tham số Mã (Lấy từ TextBox, chuyển sang số nguyên)
                    cmd.Parameters.Add("@MaDM", SqlDbType.Int).Value = int.Parse(txtMaDM.Text);

                    dataTable.Update(cmd);
                }

                LayDuLieu();   // Load lại lưới
                BatTat(false); // Khóa lại
                MessageBox.Show("Lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maDM)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa danh mục này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM DanhMuc WHERE MaDM = @MaDM";
                    SqlCommand cmd = new SqlCommand(sql);
                    cmd.Parameters.Add("@MaDM", SqlDbType.Int).Value = int.Parse(maDM);

                    dataTable.Update(cmd);
                    LayDuLieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa danh mục này (có thể do đang chứa sách). \nChi tiết: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTat(false);
            if (dgvDanhMuc.CurrentRow != null)
            {
                txtTenDM.Text = dgvDanhMuc.CurrentRow.Cells["TenDanhMuc"].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maDM = dgvDanhMuc.Rows[e.RowIndex].Cells["MDM"].Value.ToString();
            }
        }

        private void dgvDanhMuc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhMuc.CurrentRow != null)
            {
                maDM = dgvDanhMuc.CurrentRow.Cells["MDM"].Value.ToString();
            }
        }
    }
}
