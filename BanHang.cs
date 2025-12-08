using QLBS;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using System.ComponentModel;

namespace QLBS
{
    public partial class BanHang : Form
    {
        MyDataTable dataTable = new MyDataTable();
        DataTable dtGioHang = new DataTable();
        int currentTonKho = 0;
        private int maKhachHangHienTai = 1; // MaKH=1 là khách vãng lai
        DataTable dtSach = new DataTable();
        DataTable dtKhachHang = new DataTable();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal string CurrentNguoiBan { get; set; } = "admin";

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

            txtMaSach.ReadOnly = true;
            txtTenSach.ReadOnly = true;
            txtGiaBan.ReadOnly = true;
            lblThanhTien.Text = "0"; // đặt giá trị ban đầu là 0

            numSoLuong.Minimum = 1;
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
            dtGioHang.Columns.Add("MaSach", typeof(string));
            dtGioHang.Columns.Add("TenSach", typeof(string));
            dtGioHang.Columns.Add("SoLuong", typeof(int));
            dtGioHang.Columns.Add("DonGia", typeof(decimal));
            dtGioHang.Columns.Add("ThanhTien", typeof(decimal), "SoLuong * DonGia");
            dgvGioHang.DataSource = dtGioHang;
        }
        #endregion


        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            // >>> SỬA ĐIỀU KIỆN 1: Kiểm tra TextBox Mã Sách (đã được đổ dữ liệu khi click sách)
            if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách cần mua trước khi thêm vào giỏ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra CurrentRow lần nữa để đảm bảo lấy được dữ liệu.
            if (dgvSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần mua!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int soLuongMua = (int)numSoLuong.Value;
            if (soLuongMua <= 0)
            {
                MessageBox.Show("Số lượng mua phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Lấy dữ liệu sách đang chọn (Sử dụng CurrentRow là đúng)
            string maSach = dgvSach.CurrentRow.Cells["MaSach"].Value.ToString();
            string tenSach = dgvSach.CurrentRow.Cells["TenSach"].Value.ToString();
            decimal donGia = Convert.ToDecimal(dgvSach.CurrentRow.Cells["GiaBan"].Value);
            // Lấy Tồn Kho thực tế từ dtSach (đã load)
            int tonKho = Convert.ToInt32(dgvSach.CurrentRow.Cells["SoLuongTon"].Value);

            // 3. Kiểm tra và CỘNG DỒN số lượng trong giỏ hàng
            DataRow existingRow = dtGioHang.AsEnumerable()
                                             .FirstOrDefault(row => row.Field<string>("MaSach") == maSach);

            if (existingRow != null)
            {
                // ĐÃ CÓ TRONG GIỎ -> Cộng dồn
                int slCu = existingRow.Field<int>("SoLuong");
                int slMoi = slCu + soLuongMua;

                // KIỂM TRA TỒN KHO TRƯỚC KHI CẬP NHẬT
                if (slMoi > tonKho)
                {
                    MessageBox.Show($"Số lượng yêu cầu ({slMoi}) vượt quá tồn kho hiện tại ({tonKho}).", "Lỗi Tồn Kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                existingRow["SoLuong"] = slMoi;
            }
            else
            {
                // CHƯA CÓ TRONG GIỎ -> Thêm dòng mới
                // KIỂM TRA TỒN KHO CHO LẦN THÊM MỚI
                if (soLuongMua > tonKho)
                {
                    MessageBox.Show($"Số lượng yêu cầu ({soLuongMua}) vượt quá tồn kho hiện tại ({tonKho}).", "Lỗi Tồn Kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow newRow = dtGioHang.NewRow();
                newRow["MaSach"] = maSach;
                newRow["TenSach"] = tenSach;
                newRow["SoLuong"] = soLuongMua;
                newRow["DonGia"] = donGia;

                dtGioHang.Rows.Add(newRow);
            }

            // 4. Tính tổng tiền hóa đơn
            CapNhatTongTien();

            // 5. Làm sạch control sau khi thêm thành công (Đã sửa: reset tất cả controls)
            txtMaSach.Text = string.Empty; // <<< QUAN TRỌNG: Ngăn thêm lần 2
            txtTenSach.Text = string.Empty;
            txtGiaBan.Text = string.Empty;
            numSoLuong.Value = 1; // Đảm bảo số lượng luôn reset về 1
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra giỏ hàng
            if (dtGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống, không thể thanh toán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(dataTable.ConnectionString()))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Lấy tổng tiền (đã loại bỏ dấu phân cách)
                    string cleanedTongTienText = System.Text.RegularExpressions.Regex.Replace(lblThanhTien.Text, "[^0-9]", "");
                    if (!decimal.TryParse(cleanedTongTienText, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal tongTien))
                    {
                        // Xử lý trường hợp không parse được (ví dụ: "VND")
                        MessageBox.Show("Tổng tiền không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // BƯỚC 1: TẠO HÓA ĐƠN
                    string sqlHD = @"INSERT INTO HoaDon (NgayTao, NguoiTao, MaKH, TongTien, TrangThai) 
                 VALUES (GETDATE(), @NguoiTao, @MaKH, @TongTien, N'Đã thanh toán');
                 SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdHD = new SqlCommand(sqlHD, conn, transaction);

                    cmdHD.Parameters.AddWithValue("@NguoiTao", this.CurrentNguoiBan);

                    cmdHD.Parameters.AddWithValue("@TongTien", tongTien);
                    cmdHD.Parameters.AddWithValue("@MaKH", maKhachHangHienTai);

                    int maHD = Convert.ToInt32(cmdHD.ExecuteScalar());

                    // BƯỚC 2: LƯU CHI TIẾT & TRỪ KHO
                    foreach (DataRow row in dtGioHang.Rows)
                    {
                        string maSach = row["MaSach"].ToString();
                        int soLuong = (int)row["SoLuong"];
                        decimal donGia = (decimal)row["DonGia"];
                        decimal thanhTienCT = (decimal)row["ThanhTien"];

                        // a. Lưu Chi tiết hóa đơn
                        string sqlCT = @"INSERT INTO ChiTietHoaDon (MaHD, MaSach, SoLuong, DonGia, ThanhTien)
                                 VALUES (@MaHD, @MaSach, @SoLuong, @DonGia, @ThanhTien)";

                        SqlCommand cmdCT = new SqlCommand(sqlCT, conn, transaction);
                        cmdCT.Parameters.AddWithValue("@MaHD", maHD);
                        cmdCT.Parameters.AddWithValue("@MaSach", maSach);
                        cmdCT.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmdCT.Parameters.AddWithValue("@DonGia", donGia);
                        cmdCT.Parameters.AddWithValue("@ThanhTien", thanhTienCT);
                        cmdCT.ExecuteNonQuery();

                        // b. Trừ Tồn Kho
                        string sqlKho = "UPDATE Sach SET SoLuongTon = SoLuongTon - @SL WHERE MaSach = @MaSach";
                        SqlCommand cmdKho = new SqlCommand(sqlKho, conn, transaction);
                        cmdKho.Parameters.AddWithValue("@SL", soLuong);
                        cmdKho.Parameters.AddWithValue("@MaSach", maSach);
                        cmdKho.ExecuteNonQuery();
                    }

                    // Hoàn tất giao dịch hóa đơn và cập nhật kho
                    transaction.Commit();

                    // ----------------------------------------------------------------------------------
                    // BƯỚC 3: TÍCH ĐIỂM TỰ ĐỘNG (THỰC THI NGOÀI TRANSACTION CHÍNH)
                    // ----------------------------------------------------------------------------------
                    if (maKhachHangHienTai > 1) // Chỉ tích điểm cho khách hàng có đăng ký
                    {
                        // Công thức tích điểm: 1 điểm cho mỗi 10,000 VND
                        int diemMoi = (int)Math.Floor(tongTien / 10000);

                        if (diemMoi > 0)
                        {
                            string sqlUpdateDiem = @"UPDATE KhachHang SET DiemTichLuy = DiemTichLuy + @DiemMoi  
                                             WHERE MaKH = @MaKH";

                            SqlCommand cmdUpdateDiem = new SqlCommand(sqlUpdateDiem, conn);
                            cmdUpdateDiem.Parameters.AddWithValue("@DiemMoi", diemMoi);
                            cmdUpdateDiem.Parameters.AddWithValue("@MaKH", maKhachHangHienTai);
                            cmdUpdateDiem.ExecuteNonQuery();

                            MessageBox.Show($"Thanh toán thành công! Mã HĐ: {maHD}\nKhách hàng tích lũy thêm **{diemMoi}** điểm!");
                        }
                        else
                        {
                            MessageBox.Show($"Thanh toán thành công! Mã HĐ: {maHD}");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Thanh toán thành công! Mã HĐ: {maHD}");
                    }


                    // BƯỚC 4: RESET GIAO DIỆN SAU THANH TOÁN
                    dtGioHang.Clear();
                    lblThanhTien.Text = "0"; // Đặt lại đơn vị

                    // Reset thông tin khách hàng về vãng lai (MaKH=1)
                    maKhachHangHienTai = 1;
                    txtTimSDT.Text = string.Empty;
                    dgvKhachHang.DataSource = null; // Xóa kết quả tìm kiếm KH
                    txtTimKiem.Text = string.Empty;
                    dgvGioHang.DataSource = null;

                    // Load lại danh sách sách để cập nhật tồn kho mới
                    LoadDanhSachSach();
                }
                catch (Exception ex)
                {
                    // Nếu có lỗi, rollback transaction (hủy bỏ BƯỚC 1 và BƯỚC 2)
                    transaction.Rollback();
                    MessageBox.Show("Lỗi thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Đã sửa SELECT chỉ lấy các cột cần thiết (MaKH, TenKH, SDT, DiemTichLuy)
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

        private void dgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Đảm bảo dòng đang được chọn
            if (dgvSach.CurrentRow == null) return;

            DoDuLieuVaoControls();
        }

        private void DoDuLieuVaoControls()
        {
            try
            {
                DataGridViewRow row = dgvSach.CurrentRow;

                // 1. Đổ dữ liệu vào các TextBox
                // KIỂM TRA ĐẢM BẢO TÊN CỘT TRONG DATAGRIDVIEW LÀ "MaSach", "TenSach"
                txtMaSach.Text = row.Cells["MaSach"].Value?.ToString() ?? string.Empty;
                txtTenSach.Text = row.Cells["TenSach"].Value?.ToString() ?? string.Empty;

                // 2. Xử lý Giá bán và Tồn kho
                // KIỂM TRA ĐẢM BẢO TÊN CỘT TRONG DATAGRIDVIEW LÀ "GiaBan", "SoLuongTon"
                decimal giaBan = 0;
                if (row.Cells["GiaBan"].Value != DBNull.Value)
                {
                    giaBan = Convert.ToDecimal(row.Cells["GiaBan"].Value);
                    txtGiaBan.Text = giaBan.ToString("N0"); // Hiển thị có định dạng 
                }
                else
                {
                    txtGiaBan.Text = "0";
                }

                currentTonKho = 0;
                if (row.Cells["SoLuongTon"].Value != DBNull.Value)
                {
                    currentTonKho = Convert.ToInt32(row.Cells["SoLuongTon"].Value);
                }

                // 3. Tự động đặt Số lượng là 1 và thiết lập Max
                numSoLuong.Value = 1; // Đảm bảo số lượng luôn reset về 1 khi chọn sách mới
                numSoLuong.Maximum = currentTonKho > 0 ? currentTonKho : 1; // Max là Tồn kho (hoặc 1 nếu tồn kho = 0)
                numSoLuong.Enabled = currentTonKho > 0; // Chỉ cho phép mua khi có tồn kho
            }
            catch (Exception ex)
            {
                // NẾU LỖI NÀY XẢY RA, NGHĨA LÀ TÊN CỘT SAI. VUI LÒNG KIỂM TRA DATAPROPERTYNAME CỦA CÁC CỘT TRONG DESIGNER.
                MessageBox.Show("Lỗi lấy dữ liệu sách: Vui lòng kiểm tra lại tên cột trong DataGridView. Chi tiết lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng sách trong giỏ hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sách này khỏi giỏ hàng?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Lấy DataRow tương ứng
                DataRowView drv = (DataRowView)dgvGioHang.CurrentRow.DataBoundItem;
                drv.Row.Delete();

                // Áp dụng thay đổi vào DataTable
                dtGioHang.AcceptChanges();

                // Cập nhật lại tổng tiền
                CapNhatTongTien();
            }
        }
    }
}
