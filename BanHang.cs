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
        KhachHang khachHang = new KhachHang();
        private int maKhachHangHienTai = 1;
        DataTable dtSach = new DataTable();
        DataTable dtKhachHang = new DataTable();

        public BanHang()
        {
            InitializeComponent();
            dataTable.OpenConnection();

            dgvGioHang.AutoGenerateColumns = false;
            dgvSach.AutoGenerateColumns = false;
            dgvKhachHang.AutoGenerateColumns = false;
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
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
            dtSach.Clear();

            using (SqlConnection conn = new SqlConnection(dataTable.ConnectionString()))
            {
                conn.Open();
                cmd.Connection = conn;
                new SqlDataAdapter(cmd).Fill(dtSach); // Điền vào dtSach (biến cấp lớp)
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

        private void dgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnThemGioHang_Click(object sender, EventArgs e)
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

        private void btnXoa_Click_1(object sender, EventArgs e)
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
                                     VALUES (GETDATE(), 'admin', @MaKH, @TongTien, N'Đã thanh toán');
                                     SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdHD = new SqlCommand(sqlHD, conn, transaction);
                    decimal tongTien = decimal.Parse(lblThanhTien.Text.Replace(".", "").Replace(",", ""));
                    cmdHD.Parameters.AddWithValue("@TongTien", tongTien);
                    cmdHD.Parameters.AddWithValue("@MaKH", maKhachHangHienTai);

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

                    if (maKhachHangHienTai > 1)
                    {
                        // 1. Tính điểm mới: Mỗi 10,000 VND = 1 điểm
                        // Math.Floor đảm bảo chỉ tính điểm cho các bội số nguyên của 10000
                        int diemMoi = (int)Math.Floor(tongTien / 10000);

                        if (diemMoi > 0)
                        {
                            string sqlUpdateDiem = @"UPDATE KhachHang SET DiemTich = DiemTich + @DiemMoi 
                                            WHERE MaKH = @MaKH";

                            SqlCommand cmdUpdateDiem = new SqlCommand(sqlUpdateDiem, conn);
                            cmdUpdateDiem.Parameters.AddWithValue("@DiemMoi", diemMoi);
                            cmdUpdateDiem.Parameters.AddWithValue("@MaKH", maKhachHangHienTai);
                            cmdUpdateDiem.ExecuteNonQuery();

                            MessageBox.Show($"Khách hàng tích lũy thêm **{diemMoi}** điểm!");
                        }
                    }
                    MessageBox.Show("Thanh toán thành công! Mã HĐ: " + maHD);

                    dtGioHang.Clear();
                    lblThanhTien.Text = "0";
                    // Đặt lại MaKH về mặc định sau khi thanh toán xong
                    maKhachHangHienTai = 1;

                    LoadDanhSachSach();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi thanh toán: " + ex.Message);
                }
            }
        }
        #region Tìm kiếm
        private void btnTimSDT_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimSDT.Text.Trim();

            if (tuKhoa == "")
            {
                LayDuLieuKhachHang();
                return;
            }

            // Đã sửa SELECT chỉ lấy các cột cần thiết (MaKH, TenKH, SDT, DiemTich)
            string sql = @"SELECT MaKH, TenKH, SDT, DiemTichLuy
                   FROM KhachHang
                   WHERE SDT LIKE N'%' + @TuKhoa + '%'";

            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = tuKhoa;

            // *** SỬ DỤNG dtKhachHang ĐỘC LẬP ***
            dtKhachHang.Clear();
            using (SqlConnection conn = new SqlConnection(dataTable.ConnectionString()))
            {
                conn.Open();
                cmd.Connection = conn;
                new SqlDataAdapter(cmd).Fill(dtKhachHang); // Điền dữ liệu vào dtKhachHang
            }
            dgvKhachHang.DataSource = dtKhachHang; // Gán dtKhachHang cho dgvKhachHang

            // Cập nhật maKhachHangHienTai nếu tìm thấy
            if (dtKhachHang.Rows.Count > 0)
            {
                maKhachHangHienTai = Convert.ToInt32(dtKhachHang.Rows[0]["MaKH"]);
            }
            else
            {
                maKhachHangHienTai = 1; // Khách vãng lai
            }
        }

        public void LayDuLieuKhachHang()
        {
            string sqlKhachHang = @"SELECT MaKH, TenKH, SDT, DiemTichLuy FROM KhachHang";

            SqlCommand cmd = new SqlCommand(sqlKhachHang);

            dtKhachHang.Clear(); // Dọn dẹp dữ liệu cũ trong dtKhachHang

            using (SqlConnection conn = new SqlConnection(dataTable.ConnectionString()))
            {
                conn.Open();
                cmd.Connection = conn;
                new SqlDataAdapter(cmd).Fill(dtKhachHang); // Điền dữ liệu vào dtKhachHang (biến cấp lớp)
            }

            dgvKhachHang.DataSource = dtKhachHang; // Gán nguồn dữ liệu độc lập

            // Đặt lại MaKH về khách vãng lai (MaKH = 1)
            maKhachHangHienTai = 1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (tuKhoa == "")
            {
                //LayDuLieuSach(); // Hoặc LoadDanhSachSach() tùy bạn muốn hiển thị toàn bộ hay chỉ sách > 0 tồn kho
                LoadDanhSachSach();
                return;
            }

            string sql = @"SELECT S.MaSach, S.TenSach, S.TacGia, S.GiaBan, S.SoLuongTon, S.GhiChu, S.MaDM, D.TenDanhMuc
                   FROM Sach S 
                   INNER JOIN DanhMuc D ON S.MaDM = D.MaDM
                   WHERE S.TenSach LIKE N'%' + @TuKhoa + '%' 
                      OR S.MaSach LIKE '%' + @TuKhoa + '%'
                      OR S.TacGia LIKE N'%' + @TuKhoa + '%'";

            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = tuKhoa;

            // *** SỬ DỤNG dtSach ĐỘC LẬP ***
            dtSach.Clear();
            using (SqlConnection conn = new SqlConnection(dataTable.ConnectionString()))
            {
                conn.Open();
                cmd.Connection = conn;
                new SqlDataAdapter(cmd).Fill(dtSach); // Điền dữ liệu vào dtSach
            }
            dgvSach.DataSource = dtSach; // Gán dtSach cho dgvSach
        }

        public void LayDuLieuSach()
        {
            string sqlSach = @"SELECT S.MaSach, S.TenSach, S.TacGia, S.GiaBan, S.SoLuongTon, S.GhiChu, S.MaDM, D.TenDanhMuc 
                       FROM Sach S 
                       INNER JOIN DanhMuc D ON S.MaDM = D.MaDM";

            SqlCommand cmd = new SqlCommand(sqlSach);

            dtSach.Clear(); // Sử dụng dtSach cấp lớp

            using (SqlConnection conn = new SqlConnection(dataTable.ConnectionString()))
            {
                conn.Open();
                cmd.Connection = conn;
                new SqlDataAdapter(cmd).Fill(dtSach);
            }

            dgvSach.DataSource = dtSach; // Gán nguồn dữ liệu độc lập
        }

        #endregion


        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang formKH = new KhachHang();
            formKH.ShowDialog();
        }

        private void btnTichDiem_Click(object sender, EventArgs e)
        {
            // Kiểm tra: Phải là khách hàng thành viên (MaKH > 1)
            if (maKhachHangHienTai <= 1)
            {
                MessageBox.Show("Vui lòng tìm kiếm và chọn Khách hàng thành viên để tích điểm.", "Lỗi tích điểm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tongTien = 0;
            try
            {
                // 1. Lấy Tổng Tiền từ lblThanhTien
                // Cần loại bỏ dấu phân cách (thường là '.' hoặc ',') trước khi chuyển đổi
                string tienText = lblThanhTien.Text.Replace(".", "").Replace(",", "");
                tongTien = decimal.Parse(tienText);
            }
            catch
            {
                MessageBox.Show("Tổng tiền không hợp lệ hoặc không có hàng trong giỏ.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra Tổng tiền
            if (tongTien < 10000)
            {
                MessageBox.Show("Tổng tiền phải từ 10,000 VND trở lên để được tích điểm.", "Tích điểm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Tính toán điểm mới: Cứ 10,000 VND được 1 điểm
            // Math.Floor đảm bảo chỉ tính điểm cho các bội số nguyên của 10000
            int diemMoi = (int)Math.Floor(tongTien / 10000);

            if (diemMoi > 0)
            {
                string sqlUpdateDiem = @"UPDATE KhachHang 
                                SET DiemTich = DiemTich + @DiemMoi 
                                WHERE MaKH = @MaKH";

                using (SqlConnection conn = new SqlConnection(dataTable.ConnectionString()))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmdUpdateDiem = new SqlCommand(sqlUpdateDiem, conn);

                        cmdUpdateDiem.Parameters.AddWithValue("@DiemMoi", diemMoi);
                        cmdUpdateDiem.Parameters.AddWithValue("@MaKH", maKhachHangHienTai);

                        int rowsAffected = cmdUpdateDiem.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Đã tích lũy thành công **{diemMoi}** điểm cho Khách hàng!.", "Tích điểm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Cập nhật lại giao diện (dgvKhachHang) nếu cần để hiển thị điểm mới
                            // Ví dụ: Load lại thông tin Khách hàng
                            // btnTimSDT_Click(null, null); 
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi cập nhật điểm vào database: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
