using QLBS;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBS
{
    public partial class BanHang : Form
    {
        MyDataTable dataTable = new MyDataTable();
        DataTable dtGioHang = new DataTable();
        int currentTonKho = 0;

        public BanHang()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            dgvGioHang.AutoGenerateColumns = false;

            LoadDanhSachSach();
            KhoiTaoGioHang();
        }

        private void LoadDanhSachSach()
        {
            string sql = @"SELECT S.MaSach, S.TenSach, D.TenDanhMuc, S.GiaBan, S.SoLuongTon 
                           FROM Sach S 
                           LEFT JOIN DanhMuc D ON S.MaDM = D.MaDM 
                           WHERE S.SoLuongTon > 0";

            SqlCommand cmd = new SqlCommand(sql);
            DataTable dtSach = new DataTable();

            using (SqlConnection conn = new SqlConnection(dataTable.ConnectionString()))
            {
                conn.Open();
                cmd.Connection = conn;
                new SqlDataAdapter(cmd).Fill(dtSach);
            }

            dgvSach.DataSource = dtSach;
        }

        #region KHỞI TẠO GIỎ HÀNG ẢO
        private void KhoiTaoGioHang()
        {
            // 1. Tạo cấu trúc bảng ảo (Giữ nguyên để khớp với DataPropertyName vừa điền)
            dtGioHang.Columns.Add("MaSach", typeof(string));
            dtGioHang.Columns.Add("TenSach", typeof(string));
            dtGioHang.Columns.Add("SoLuong", typeof(int));
            dtGioHang.Columns.Add("DonGia", typeof(decimal));
            dtGioHang.Columns.Add("ThanhTien", typeof(decimal), "SoLuong * DonGia");

            // 2. Gán vào lưới
            dgvGioHang.DataSource = dtGioHang;
        }
        #endregion
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSach.Rows.Count)
            {
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];

                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();

                if (row.Cells["GiaBan"].Value != DBNull.Value)
                {
                    decimal gia = Convert.ToDecimal(row.Cells["GiaBan"].Value);
                    txtGiaBan.Text = gia.ToString("N0");
                }

                if (row.Cells["SoLuongTon"].Value != DBNull.Value)
                {
                    currentTonKho = Convert.ToInt32(row.Cells["SoLuongTon"].Value);
                }
                else
                {
                    currentTonKho = 0;
                }

                numSoLuong.Value = 1;

                if (currentTonKho > 0)
                    numSoLuong.Maximum = currentTonKho;
                else
                    numSoLuong.Maximum = 0;
            }
        }

        private void btnThemGiohang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách cần mua!");
                return;
            }

            int soLuongMua = (int)numSoLuong.Value;

            if (soLuongMua > currentTonKho || soLuongMua <= 0)
            {
                MessageBox.Show($"Số lượng không hợp lệ! Kho chỉ còn {currentTonKho} cuốn.");
                return;
            }

            string maSach = txtMaSach.Text;
            string tenSach = txtTenSach.Text;
            decimal giaBan = 0;
            try
            {
                giaBan = decimal.Parse(txtGiaBan.Text.Replace(".", "").Replace(",", ""));
            }
            catch { giaBan = 0; }

            bool daCo = false;
            foreach (DataRow row in dtGioHang.Rows)
            {
                if (row["MaSach"].ToString() == maSach)
                {
                    row["SoLuong"] = (int)row["SoLuong"] + soLuongMua;
                    daCo = true;
                    break;
                }
            }

            if (!daCo)
            {
                dtGioHang.Rows.Add(maSach, tenSach, soLuongMua, giaBan);
            }

            CapNhatTongTien();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow != null)
            {
                dgvGioHang.Rows.RemoveAt(dgvGioHang.CurrentRow.Index);
                CapNhatTongTien();
            }
        }

        #region Cập NhậT Tổng Tiền
        private void CapNhatTongTien()
        {
            decimal tong = 0;
            foreach (DataRow row in dtGioHang.Rows)
            {

                if (row["ThanhTien"] != DBNull.Value)
                {
                    tong += Convert.ToDecimal(row["ThanhTien"]);
                }
            }

            lblThanhTien.Text = tong.ToString("N0");
        }
        #endregion
        

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtGioHang.Rows.Count == 0) return;

            using (SqlConnection conn = new SqlConnection(dataTable.ConnectionString()))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {

                    string sqlHD = @"INSERT INTO HoaDon (NgayTao, NguoiTao, MaKH, TongTien, TrangThai) 
                                     VALUES (GETDATE(), 'admin', 1, @TongTien, N'Đã thanh toán');
                                     SELECT SCOPE_IDENTITY();"; // Lấy về Mã HD vừa tạo

                    SqlCommand cmdHD = new SqlCommand(sqlHD, conn, transaction);

                    decimal tongTien = decimal.Parse(lblThanhTien.Text.Replace(".", "").Replace(",", ""));
                    cmdHD.Parameters.AddWithValue("@TongTien", tongTien);

                    int maHD = Convert.ToInt32(cmdHD.ExecuteScalar());

                    // BƯỚC 2: LƯU CHI TIẾT & TRỪ KHO
                    foreach (DataRow row in dtGioHang.Rows)
                    {
                        string maSach = row["MaSach"].ToString();
                        int soLuong = (int)row["SoLuong"];
                        decimal donGia = (decimal)row["DonGia"];
                        decimal thanhTien = (decimal)row["ThanhTien"];

                        // a. Lưu Chi tiết hóa đơn
                        string sqlCT = @"INSERT INTO ChiTietHoaDon (MaHD, MaSach, SoLuong, DonGia, ThanhTien)
                                         VALUES (@MaHD, @MaSach, @SoLuong, @DonGia, @ThanhTien)";

                        SqlCommand cmdCT = new SqlCommand(sqlCT, conn, transaction);
                        cmdCT.Parameters.AddWithValue("@MaHD", maHD);
                        cmdCT.Parameters.AddWithValue("@MaSach", maSach);
                        cmdCT.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmdCT.Parameters.AddWithValue("@DonGia", donGia);
                        cmdCT.Parameters.AddWithValue("@ThanhTien", thanhTien);
                        cmdCT.ExecuteNonQuery();

                        // b. Trừ Tồn Kho
                        string sqlKho = "UPDATE Sach SET SoLuongTon = SoLuongTon - @SL WHERE MaSach = @MaSach";
                        SqlCommand cmdKho = new SqlCommand(sqlKho, conn, transaction);
                        cmdKho.Parameters.AddWithValue("@SL", soLuong);
                        cmdKho.Parameters.AddWithValue("@MaSach", maSach);
                        cmdKho.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Thanh toán thành công! Mã HĐ: " + maHD);

                    dtGioHang.Clear();
                    lblThanhTien.Text = "0";

                    LoadDanhSachSach();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi thanh toán: " + ex.Message);
                }
            }
        }

        private void btnThemGiohang_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách cần mua!");
                return;
            }

            int soLuongMua = (int)numSoLuong.Value;

            if (soLuongMua > currentTonKho || soLuongMua <= 0)
            {
                MessageBox.Show($"Số lượng không hợp lệ! Kho chỉ còn {currentTonKho} cuốn.");
                return;
            }

            string maSach = txtMaSach.Text;
            string tenSach = txtTenSach.Text;
            decimal giaBan = 0;
            try
            {
                giaBan = decimal.Parse(txtGiaBan.Text.Replace(".", "").Replace(",", ""));
            }
            catch { giaBan = 0; }

            bool daCo = false;
            foreach (DataRow row in dtGioHang.Rows)
            {
                if (row["MaSach"].ToString() == maSach)
                {
                    row["SoLuong"] = (int)row["SoLuong"] + soLuongMua;
                    daCo = true;
                    break;
                }
            }

            if (!daCo)
            {
                dtGioHang.Rows.Add(maSach, tenSach, soLuongMua, giaBan);
            }

            CapNhatTongTien();
        }
    }
}