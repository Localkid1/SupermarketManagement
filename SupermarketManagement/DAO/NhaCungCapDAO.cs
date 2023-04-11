using SupermarketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SupermarketManagement.DAO
{
    public class NhaCungCapDAO
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True");
        public List<NhaCungCapDTO> proc_supplier()
        {
            List<NhaCungCapDTO> supplier = new List<NhaCungCapDTO>();

            using (conn)
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("proc_supplier", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NhaCungCapDTO suppliers = new NhaCungCapDTO();
                            suppliers.OrderID = reader.GetString(reader.GetOrdinal("OrderID"));
                            suppliers.OrdderName = reader.GetString(reader.GetOrdinal("OrderName"));
                         
                            suppliers.Address = reader.GetString(reader.GetOrdinal("Address"));
                           
                            suppliers.PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                           

                            supplier.Add(suppliers);
                        }
                    }
                }
            }

            return supplier;
        }

        private int GetOrderCount()
        {
            int count = 0;
            // Tạo kết nối đến cơ sở dữ liệu

            conn.Open();
            // Tạo câu lệnh SQL để lấy số lượng nhân viên
            string sql = "SELECT COUNT(*) FROM NhaCungCap";
            SqlCommand cmd = new SqlCommand(sql, conn);
            // Thực thi câu lệnh SQL và lấy kết quả
            count = (int)cmd.ExecuteScalar();


            // Đóng kết nối
            conn.Close();

            return count;
        }
        public bool AddSupplier(NhaCungCapDTO supplier)
        {
            try
            {
                int count = 0;
                // Lấy số lượng nhân viên hiện có trong cơ sở dữ liệu
                count = GetOrderCount();

                // Tính toán mã nhân viên mới
                string newOrderID = "NCC" + (count + 1).ToString("00");

                SqlCommand cmd = new SqlCommand("INSERT INTO NhaCungCap (OrderID, OrderName, Address, PhoneNumber) VALUES (@OrderID, @OrderName, @Address, @PhoneNumber)", conn);

                cmd.Parameters.AddWithValue("@OrderID", newOrderID);
                cmd.Parameters.AddWithValue("@OrderName", supplier.OrdderName);
                cmd.Parameters.AddWithValue("@Address", supplier.Address);
                cmd.Parameters.AddWithValue("@PhoneNumber", supplier.PhoneNumber);


                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool UpdateSupplier(NhaCungCapDTO supplier)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE NhaCungCap SET OrderName = @OrderName, Address = @Address, PhoneNumber = @PhoneNumber WHERE OrderID = @OrderID", conn);

                cmd.Parameters.AddWithValue("@OrderID", supplier.OrderID);
                cmd.Parameters.AddWithValue("@OrderName", supplier.OrdderName);
                cmd.Parameters.AddWithValue("@Address", supplier.Address);
                cmd.Parameters.AddWithValue("@PhoneNumber", supplier.PhoneNumber);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool DeleteSupplier(NhaCungCapDTO supplier)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM NhaCungCap WHERE OrderID = @OrderID", conn);
                cmd.Parameters.AddWithValue("@OrderID", supplier.OrderID);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public List<NhaCungCapDTO> GetProductByName(string orderName)
        {
            List<NhaCungCapDTO> suppliers = new List<NhaCungCapDTO>();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhaCungCap WHERE OrderName LIKE '%' + @OrderName + '%'", conn);
                cmd.Parameters.AddWithValue("@OrderName", orderName);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    NhaCungCapDTO supplier = new NhaCungCapDTO();
                    supplier.OrderID = reader.GetString(reader.GetOrdinal("OrderID"));
                    supplier.OrdderName = reader.GetString(reader.GetOrdinal("OrderName"));
                    supplier.Address = reader.GetString(reader.GetOrdinal("Address"));
                    supplier.PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));

                    suppliers.Add(supplier);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return suppliers;
        }



    }
}
