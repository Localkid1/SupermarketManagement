using SupermarketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SupermarketManagement.DAO
{
    public class SanPhamDAO:DataBaseAccess
    {

        SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True");
        public List<SanPhamDTO> proc_product()
        {
            List<SanPhamDTO> products = new List<SanPhamDTO>();

            using (conn)
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("proc_product", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SanPhamDTO product = new SanPhamDTO();
                            product.ProductID = reader.GetString(reader.GetOrdinal("ProductID"));
                            product.ProductName = reader.GetString(reader.GetOrdinal("ProductName"));
                            product.ProductIndex = reader.GetInt32(reader.GetOrdinal("ProductIndex"));
                            product.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                            product.Quanlity = reader.GetString(reader.GetOrdinal("Quanlity"));
                            product.ExpirationDate = reader.GetDateTime(reader.GetOrdinal("ExpirationDate"));
                            product.ProductPlace = reader.GetString(reader.GetOrdinal("ProductPlace"));
                            product.Unit = reader.GetString(reader.GetOrdinal("Unit"));

                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }

        private int GetProductCount()
        {
            int count = 0;
            // Tạo kết nối đến cơ sở dữ liệu
          
                conn.Open();
                // Tạo câu lệnh SQL để lấy số lượng nhân viên
                string sql = "SELECT COUNT(*) FROM SanPham";
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Thực thi câu lệnh SQL và lấy kết quả
                count = (int)cmd.ExecuteScalar();


                // Đóng kết nối
                conn.Close();
            
            return count;
        }

        public bool AddProduct(SanPhamDTO product)
            {
                try
                {
                int count = 0;
                // Lấy số lượng nhân viên hiện có trong cơ sở dữ liệu
                count = GetProductCount();

                // Tính toán mã nhân viên mới
                string newProductID = "PDT" + (count + 1).ToString("00");

                SqlCommand cmd = new SqlCommand("INSERT INTO SanPham (ProductID, ProductName, ProductIndex, Price,Quanlity,  ExpirationDate, ProductPlace, Unit) VALUES (@ProductID, @ProductName, @ProductIndex, @Price,@Quanlity,  @ExpirationDate, @ProductPlace, @Unit)", conn);

                    cmd.Parameters.AddWithValue("@ProductID", newProductID);
                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("@ProductIndex", product.ProductIndex);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@Quanlity", product.Quanlity);
                    cmd.Parameters.AddWithValue("@ExpirationDate", product.ExpirationDate);
                    cmd.Parameters.AddWithValue("@ProductPlace", product.ProductPlace);
                    cmd.Parameters.AddWithValue("@Unit", product.Unit);

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

        public bool UpdateProduct(SanPhamDTO product)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE SanPham SET ProductName = @ProductName, ProductIndex = @ProductIndex, Price = @Price,Quanlity = @Quanlity, ExpirationDate = @ExpirationDate, ProductPlace = @ProductPlace, Unit = @Unit WHERE ProductID = @ProductID", conn);

                cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@ProductIndex", product.ProductIndex);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Quanlity", product.Quanlity);
                cmd.Parameters.AddWithValue("@ExpirationDate", product.ExpirationDate);
                cmd.Parameters.AddWithValue("@ProductPlace", product.ProductPlace);
                cmd.Parameters.AddWithValue("@Unit", product.Unit);

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

        public bool DeleteProduct(SanPhamDTO product)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM SanPham WHERE ProductID = @ProductID", conn);
                cmd.Parameters.AddWithValue("@ProductID", product.ProductID);

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

        public List<SanPhamDTO> GetProductByName(string productName)
        {
            List<SanPhamDTO> products = new List<SanPhamDTO>();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM SanPham WHERE ProductName LIKE '%' + @ProductName + '%'", conn);
                cmd.Parameters.AddWithValue("@ProductName", productName);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    SanPhamDTO product = new SanPhamDTO();
                    product.ProductID = reader.GetString(reader.GetOrdinal("ProductID"));
                    product.ProductName = reader.GetString(reader.GetOrdinal("ProductName"));
                    product.ProductIndex = reader.GetInt32(reader.GetOrdinal("ProductIndex"));
                    product.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                    product.Quanlity = reader.GetString(reader.GetOrdinal("Quanlity"));
                    product.ExpirationDate = reader.GetDateTime(reader.GetOrdinal("ExpirationDate"));
                    product.ProductPlace = reader.GetString(reader.GetOrdinal("ProductPlace"));
                    product.Unit = reader.GetString(reader.GetOrdinal("Unit"));

                    products.Add(product);
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

            return products;
        }

    }
}


