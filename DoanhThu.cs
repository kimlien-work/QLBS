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
    public partial class DoanhThu : Form
    {
        MyDataTable dataTable = new MyDataTable();
        public DoanhThu()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }


        private void TinhTongKet(DataTable dt)
        {
            txtTongDonHang.Text = dt.Rows.Count.ToString();

            decimal tongTien = 0;
            if (dt.Rows.Count > 0)
            {
                object sumResult = dt.Compute("SUM(TongTien)", "");
                if (sumResult != DBNull.Value)
                    tongTien = Convert.ToDecimal(sumResult);
            }

            txtTongDoanhThu.Text = tongTien.ToString("N0");

            LayTongSoLuongSach();
        }

        private void LayTongSoLuongSach()
        {
            try
            {
                string sql = @"SELECT SUM(CT.SoLuong) 
                               FROM ChiTietHoaDon CT
                               JOIN HoaDon H ON CT.MaHD = H.MaHD
                               WHERE H.NgayTao BETWEEN @TuNgay AND @DenNgay";

                using (SqlConnection conn = new SqlConnection(dataTable.ConnectionString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@TuNgay", SqlDbType.DateTime).Value = dtpTuNgay.Value.Date;
                    cmd.Parameters.Add("@DenNgay", SqlDbType.DateTime).Value = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                        txtSlSachBan.Text = result.ToString();
                    else
                        txtSlSachBan.Text = "0";
                }
            }
            catch
            {
                txtSlSachBan.Text = "0";
            }
        }


        private void DoanhThu_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1);
            dtpDenNgay.Value = today;

            dgvDoanhThu.AutoGenerateColumns = false;
            btnXemBC_Click(sender, e);
        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"SELECT 
                                H.MaHD, 
                                H.NgayTao, 
                                K.TenKH, 
                                T.TenNhanVien, 
                                H.TongTien, 
                                H.TrangThai
                               FROM HoaDon H
                               LEFT JOIN KhachHang K ON H.MaKH = K.MaKH
                               LEFT JOIN TaiKhoan T ON H.NguoiTao = T.Account
                               WHERE H.NgayTao BETWEEN @TuNgay AND @DenNgay";

                SqlCommand cmd = new SqlCommand(sql);
                // Xử lý tham số ngày: Từ 00:00:00 ngày đầu đến 23:59:59 ngày cuối
                cmd.Parameters.Add("@TuNgay", SqlDbType.DateTime).Value = dtpTuNgay.Value.Date;
                cmd.Parameters.Add("@DenNgay", SqlDbType.DateTime).Value = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

                DataTable dtBaoCao = new DataTable();

                using (SqlConnection conn = new SqlConnection(dataTable.ConnectionString()))
                {
                    conn.Open();
                    cmd.Connection = conn;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dtBaoCao);
                }

                dgvDoanhThu.DataSource = dtBaoCao;

                TinhTongKet(dtBaoCao);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo: " + ex.Message);
            }
        }
    }
}
