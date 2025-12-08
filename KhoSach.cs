using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBS
{
    public partial class KhoSach : Form
    {
        MyDataTable dataTable = new MyDataTable();
        BindingSource binding = new BindingSource();

        public KhoSach()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }

        private void LayDuLieu()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LienKetDuLieu()
        {
            txtMaSach.DataBindings.Clear();
            txtTenSach.DataBindings.Clear();
            txtTacGia.DataBindings.Clear();
            txtGiaBan.DataBindings.Clear();
            txtSoLuongTon.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();
            cboDanhMuc.DataBindings.Clear();

            txtMaSach.DataBindings.Add("Text", binding, "MaSach", true, DataSourceUpdateMode.Never);
            txtTenSach.DataBindings.Add("Text", binding, "TenSach", true, DataSourceUpdateMode.Never);
            txtTacGia.DataBindings.Add("Text", binding, "TacGia", true, DataSourceUpdateMode.Never);
            txtGiaBan.DataBindings.Add("Text", binding, "GiaBan", true, DataSourceUpdateMode.Never);
            txtSoLuongTon.DataBindings.Add("Text", binding, "SoLuongTon", true, DataSourceUpdateMode.Never);
            txtGhiChu.DataBindings.Add("Text", binding, "GhiChu", true, DataSourceUpdateMode.Never);
            cboDanhMuc.DataBindings.Add("SelectedValue", binding, "MaDM", true, DataSourceUpdateMode.Never);
        }

        private void BatTat(bool giaTri)
        {
            txtMaSach.Enabled = giaTri;
            txtTenSach.Enabled = giaTri;
            txtTacGia.Enabled = giaTri;
            cboDanhMuc.Enabled = giaTri;
            txtGiaBan.Enabled = giaTri;
            txtSoLuongTon.Enabled = giaTri; // Đã sửa dòng này
            txtGhiChu.Enabled = giaTri;

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSach.ResetText();
            txtTenSach.ResetText();
            txtTacGia.ResetText();
            txtGiaBan.ResetText();
            txtGhiChu.ResetText();
            txtSoLuongTon.Text = "0";

            if (cboDanhMuc.Items.Count > 0) cboDanhMuc.SelectedIndex = 0;

            BatTat(true);
            txtMaSach.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSach.Text)) return;

            BatTat(true);
            txtMaSach.Enabled = false;
            txtTenSach.Focus();
        }

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
                    LayDuLieu();
                    BatTat(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text.Trim() == "") { txtMaSach.Focus(); return; }
            if (txtTenSach.Text.Trim() == "") { txtTenSach.Focus(); return; }
            if (txtTacGia.Text.Trim() == "") { txtTacGia.Focus(); return; }
            if (txtGiaBan.Text.Trim() == "") { txtGiaBan.Focus(); return; }
            if (txtSoLuongTon.Text.Trim() == "") { txtSoLuongTon.Text = "0"; }

            try
            {
                string sql = "";
                SqlCommand cmd = new SqlCommand();

                if (txtMaSach.Enabled == true)
                {
                    sql = @"INSERT INTO Sach (MaSach, TenSach, TacGia, MaDM, GiaBan, SoLuongTon, GhiChu) 
                            VALUES (@Ma, @Ten, @TacGia, @DM, @Gia, @SoLuong, @GhiChu)";
                }
                else
                {
                    sql = @"UPDATE Sach 
                            SET TenSach = @Ten, 
                                TacGia = @TacGia,
                                MaDM = @DM, 
                                GiaBan = @Gia, 
                                SoLuongTon = @SoLuong,
                                GhiChu = @GhiChu
                            WHERE MaSach = @Ma";
                }

                cmd.CommandText = sql;
                cmd.Parameters.Add("@Ma", SqlDbType.NVarChar, 20).Value = txtMaSach.Text;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = txtTenSach.Text;
                cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar, 100).Value = txtTacGia.Text;
                cmd.Parameters.Add("@DM", SqlDbType.Int).Value = cboDanhMuc.SelectedValue;

                decimal giaBan = 0;
                decimal.TryParse(txtGiaBan.Text, out giaBan);
                cmd.Parameters.Add("@Gia", SqlDbType.Money).Value = giaBan;

                int soLuong = 0;
                int.TryParse(txtSoLuongTon.Text, out soLuong);
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soLuong;

                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = txtGhiChu.Text;

                dataTable.Update(cmd);
                LayDuLieu();
                BatTat(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            binding.CancelEdit();
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

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }
    }
}