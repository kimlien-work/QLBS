using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBS
{
    public partial class KhoSach : Form
    {
        // Khai báo biến toàn cục
        MyDataTable dataTable = new MyDataTable();
        BindingSource binding = new BindingSource();

        public KhoSach()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }

        // --- 1. HÀM LẤY DỮ LIỆU CHUNG ---
        private void LayDuLieu()
        {

            DataTable dtDanhMuc = new DataTable();
            string sqlDanhMuc = "SELECT * FROM DanhMuc";
            SqlDataAdapter daDM = new SqlDataAdapter(sqlDanhMuc, dataTable.ConnectionString());
            daDM.Fill(dtDanhMuc);

            cboDanhMuc.DataSource = dtDanhMuc;
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.ValueMember = "MaDM";

            string sqlSach = @"SELECT S.MaSach, S.TenSach, S.TacGia, S.GiaBan, S.SoLuongTon, S.GhiChu, S.MaDM, D.TenDanhMuc 
                               FROM Sach S 
                               INNER JOIN DanhMuc D ON S.MaDM = D.MaDM";

            SqlCommand cmd = new SqlCommand(sqlSach);
            dataTable.Fill(cmd);

            binding.DataSource = dataTable;
            dgvSach.DataSource = binding;

            LienKetDuLieu();
        }

        // --- 2. HÀM BINDING (Code binding tách riêng để dùng lại) ---
        private void LienKetDuLieu()
        {
            txtMaSach.DataBindings.Clear();
            txtTenSach.DataBindings.Clear();
            txtTacGia.DataBindings.Clear(); // Thêm binding Tác Giả
            txtGiaBan.DataBindings.Clear();
            txtSoLuongTon.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();
            cboDanhMuc.DataBindings.Clear();


            txtMaSach.DataBindings.Add("Text", binding, "MaSach", true, DataSourceUpdateMode.Never);
            txtTenSach.DataBindings.Add("Text", binding, "TenSach", true, DataSourceUpdateMode.Never);
            txtTacGia.DataBindings.Add("Text", binding, "TacGia", true, DataSourceUpdateMode.Never); // Thêm
            txtGiaBan.DataBindings.Add("Text", binding, "GiaBan", true, DataSourceUpdateMode.Never);
            txtSoLuongTon.DataBindings.Add("Text", binding, "SoLuongTon", true, DataSourceUpdateMode.Never);
            txtGhiChu.DataBindings.Add("Text", binding, "GhiChu", true, DataSourceUpdateMode.Never);

            cboDanhMuc.DataBindings.Add("SelectedValue", binding, "MaDM", true, DataSourceUpdateMode.Never);
        }

        // --- 3. HÀM BẬT TẮT ---
        private void BatTat(bool giaTri)
        {
            txtMaSach.Enabled = giaTri;
            txtTenSach.Enabled = giaTri;
            txtTacGia.Enabled = giaTri; // Thêm
            cboDanhMuc.Enabled = giaTri;
            txtGiaBan.Enabled = giaTri;
            txtGhiChu.Enabled = giaTri;

            txtSoLuongTon.Enabled = false;

            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void KhoSach_Load(object sender, EventArgs e)
        {
            dgvSach.AutoGenerateColumns = false;
            LayDuLieu();
            BatTat(false);
        }

        // --- NÚT THÊM ---
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtGiaBan.Clear();
            txtGhiChu.Clear();
            txtSoLuongTon.Text = "0";

            if (cboDanhMuc.Items.Count > 0) cboDanhMuc.SelectedIndex = 0;

            BatTat(true);
            txtMaSach.Focus();
        }

        // --- NÚT SỬA ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa!", "Thông báo");
                return;
            }

            BatTat(true);
            txtMaSach.Enabled = false; // Không cho sửa Mã Sách (Khóa chính)
        }

        // --- NÚT XÓA ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSach.Text)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa sách " + txtTenSach.Text + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM Sach WHERE MaSach = @MaSach";
                    SqlCommand cmd = new SqlCommand(sql);
                    cmd.Parameters.Add("@MaSach", SqlDbType.NVarChar, 20).Value = txtMaSach.Text;

                    dataTable.Update(cmd);

                    MessageBox.Show("Đã xóa thành công!");
                    LayDuLieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa sách này (Có thể do sách đã bán).\nLỗi: " + ex.Message);
                }
            }
        }

        // --- NÚT LƯU (QUAN TRỌNG NHẤT: Thêm cột TacGia) ---
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Validate dữ liệu
            if (txtMaSach.Text.Trim() == "") { MessageBox.Show("Chưa nhập Mã sách!"); txtMaSach.Focus(); return; }
            if (txtTenSach.Text.Trim() == "") { MessageBox.Show("Chưa nhập Tên sách!"); txtTenSach.Focus(); return; }
            if (cboDanhMuc.SelectedValue == null) { MessageBox.Show("Chưa chọn Danh mục!"); cboDanhMuc.Focus(); return; }
            if (txtGiaBan.Text.Trim() == "") { MessageBox.Show("Chưa nhập Giá bán!"); txtGiaBan.Focus(); return; }

            try
            {
                string sql = "";
                SqlCommand cmd = new SqlCommand();

                if (txtMaSach.Enabled == true)
                {
                    // --- TRƯỜNG HỢP THÊM MỚI ---
                    sql = @"INSERT INTO Sach (MaSach, TenSach, TacGia, MaDM, GiaBan, SoLuongTon, GhiChu) 
                            VALUES (@Ma, @Ten, @TacGia, @DM, @Gia, 0, @GhiChu)";
                }
                else
                {
                    // --- TRƯỜNG HỢP SỬA ---
                    sql = @"UPDATE Sach 
                            SET TenSach = @Ten, 
                                TacGia = @TacGia,
                                MaDM = @DM, 
                                GiaBan = @Gia, 
                                GhiChu = @GhiChu
                            WHERE MaSach = @Ma";
                }

                cmd.CommandText = sql;

                // Truyền tham số (Bao gồm TacGia mới thêm)
                cmd.Parameters.Add("@Ma", SqlDbType.NVarChar, 20).Value = txtMaSach.Text;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = txtTenSach.Text;
                cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar, 100).Value = txtTacGia.Text; // Tham số tác giả
                cmd.Parameters.Add("@DM", SqlDbType.Int).Value = cboDanhMuc.SelectedValue;
                cmd.Parameters.Add("@Gia", SqlDbType.Money).Value = decimal.Parse(txtGiaBan.Text);
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = txtGhiChu.Text;

                dataTable.Update(cmd);

                MessageBox.Show("Lưu dữ liệu thành công!");
                LayDuLieu();
                BatTat(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // --- NÚT HỦY ---
        private void btnHuy_Click(object sender, EventArgs e)
        {
            binding.CancelEdit(); // Hủy bỏ chỉnh sửa trên Binding
            BatTat(false);
            LayDuLieu();
        }

        // --- TÌM KIẾM ---
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (tuKhoa == "")
            {
                LayDuLieu();
                return;
            }

            // SQL Tìm kiếm (Đã thêm tìm theo Tác giả)
            string sql = @"SELECT S.*, D.TenDanhMuc 
                           FROM Sach S 
                           INNER JOIN DanhMuc D ON S.MaDM = D.MaDM
                           WHERE S.TenSach LIKE N'%' + @TuKhoa + '%' 
                              OR S.MaSach LIKE '%' + @TuKhoa + '%'
                              OR S.TacGia LIKE N'%' + @TuKhoa + '%'";

            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = tuKhoa;

            dataTable.Fill(cmd);
        }
    }
}