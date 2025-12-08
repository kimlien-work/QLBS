using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLBS
{
    internal class MyDataTable : DataTable
    {
        // Biến toàn cục
        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommand command;
        // Lấy chuỗi kết nối

        public string ConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["Server"] = @"./SQLEXPRESS";
            builder["Database"] = "QLBS";
            builder["Integrated Security"] = "True";
            return builder.ConnectionString;
        }
        // Mở kết nối
        public bool OpenConnection()
        {
            try
            {
                // 1. Khởi tạo đối tượng kết nối nếu nó chưa tồn tại
                if (connection == null)
                    connection = new SqlConnection(ConnectionString());

                // 2. Chỉ mở nếu đang đóng (Tránh lỗi "Connection already open")
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                return true;
            }
            catch (SqlException ex) // Bắt lỗi SQL cụ thể
            {
                // 3. Ngắt kết nối an toàn (Nếu nó đã được khởi tạo)
                if (connection != null && connection.State != ConnectionState.Closed)
                    connection.Close();

                // 4. HIỂN THỊ CHI TIẾT LỖI GỐC CỦA SQL SERVER
                MessageBox.Show($"Lỗi kết nối CSDL!\nVui lòng kiểm tra Server Name và Service SQL Server đã chạy chưa.\nChi tiết: {ex.Message}",
                                "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                // Bắt các lỗi khác (như lỗi cấu hình)
                MessageBox.Show($"Lỗi chung khi mở kết nối.\nChi tiết: {ex.Message}", "Lỗi Kết Nối Chung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // Thực thi câu lệnh Select
        public void Fill(SqlCommand selectCommand)
        {
            command = selectCommand;
            try
            {
                command.Connection = connection;
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                this.Clear();

                adapter.Fill(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public int Update(SqlCommand insertUpdateDeleteCommand)
        {
            int result = 0;
            SqlTransaction transaction = null;
            try
            {
                transaction = connection.BeginTransaction();
                insertUpdateDeleteCommand.Connection = connection;
                insertUpdateDeleteCommand.Transaction = transaction;
                result = insertUpdateDeleteCommand.ExecuteNonQuery();
                this.AcceptChanges();
                transaction.Commit();
            }
            catch (Exception e)
            {
                if (transaction != null)
                    transaction.Rollback();
                MessageBox.Show("Lỗi: " + e.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}