using Microsoft.VisualBasic;
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
    public partial class KhoSach : Form
    {
        MyDataTable dataTable = new MyDataTable();
        string maSach = "";
        public KhoSach()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }

        private void LayDuLieu()
        {
            DataTable dtDanhMucRieng = new DataTable();
            System.Data.DataTable dtDanhMuc = new System.Data.DataTable();

            string sqlDanhMuc = "SELECT * FROM DanhMuc";
            SqlDataAdapter daDM = new SqlDataAdapter(sqlDanhMuc, dataTable.ConnectionString());
            daDM.Fill(dtDanhMucRieng);

            cboDanhMuc.DataSource = dtDanhMucRieng;
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.ValueMember = "MaDM";

            string sqlSach = @"SELECT S.*, D.TenDanhMuc 
                       FROM Sach S 
                       INNER JOIN DanhMuc D ON S.MaDM = D.MaDM";

            SqlCommand cmd = new SqlCommand(sqlSach);
            dataTable.Fill(cmd);

            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;
            dgvSach.DataSource = binding;

            txtMaSach.DataBindings.Clear();
            txtTenSach.DataBindings.Clear();
            txtGiaBan.DataBindings.Clear();
            txtSoLuongTon.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();
            cboDanhMuc.DataBindings.Clear();


            txtMaSach.DataBindings.Add("Text", binding, "MaSach");
            txtTenSach.DataBindings.Add("Text", binding, "TenSach");
            txtGiaBan.DataBindings.Add("Text", binding, "GiaBan");
            txtSoLuongTon.DataBindings.Add("Text", binding, "SoLuongTon");
            txtGhiChu.DataBindings.Add("Text", binding, "GhiChu");

            cboDanhMuc.DataBindings.Add("SelectedValue", binding, "MaDM");
        }

        private void BatTat(bool giaTri)
        {
            txtMaSach.Enabled = giaTri;
            txtTenSach.Enabled = giaTri;
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

        private void btnThem_Click(object sender, EventArgs e)
        {

            txtMaSach.Clear();
            txtTenSach.Clear();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            txtGhiChu.Clear();
            txtSoLuongTon.Text = "0";

            BatTat(true);

            txtMaSach.Enabled = true;
            txtMaSach.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa!", "Thông báo");
                return;
            }

            BatTat(true);

            txtMaSach.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "") return;

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
                    MessageBox.Show("Không thể xóa sách này (Có thể do sách đã phát sinh hóa đơn bán hàng).\nLỗi: " + ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
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
                    sql = @"INSERT INTO Sach (MaSach, TenSach, MaDM, GiaBan, SoLuongTon, GhiChu) 
                    VALUES (@Ma, @Ten, @DM, @Gia, 0, @GhiChu)";
                }
                else
                {
                    // --- TRƯỜNG HỢP SỬA ---
                    sql = @"UPDATE Sach 
                    SET TenSach = @Ten, 
                        MaDM = @DM, 
                        GiaBan = @Gia, 
                        GhiChu = @GhiChu
                    WHERE MaSach = @Ma";
                }

                cmd.CommandText = sql;

                // Truyền tham số
                cmd.Parameters.Add("@Ma", SqlDbType.NVarChar, 20).Value = txtMaSach.Text;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = txtTenSach.Text;
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTat(false);
            LayDuLieu();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick(); // Tự động bấm nút Tìm Kiếm
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

            string sql = @"SELECT S.*, D.TenDanhMuc 
                   FROM Sach S 
                   INNER JOIN DanhMuc D ON S.MaDM = D.MaDM
                   WHERE S.TenSach LIKE N'%' + @TuKhoa + '%' 
                      OR S.MaSach LIKE '%' + @TuKhoa + '%'";

            SqlCommand cmd = new SqlCommand(sql);

            cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = tuKhoa;

            dataTable.Fill(cmd); // Hàm Fill trong class MyDataTable của bạn

            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;

            dgvSach.DataSource = binding;

            txtMaSach.DataBindings.Clear();
            txtTenSach.DataBindings.Clear();
            cboDanhMuc.DataBindings.Clear();
            txtGiaBan.DataBindings.Clear();
            txtSoLuongTon.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();

            txtMaSach.DataBindings.Add("Text", binding, "MaSach");
            txtTenSach.DataBindings.Add("Text", binding, "TenSach");
            txtGiaBan.DataBindings.Add("Text", binding, "GiaBan");
            txtSoLuongTon.DataBindings.Add("Text", binding, "SoLuongTon");
            txtGhiChu.DataBindings.Add("Text", binding, "GhiChu");

            cboDanhMuc.DataBindings.Add("SelectedValue", binding, "MaDM");
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
