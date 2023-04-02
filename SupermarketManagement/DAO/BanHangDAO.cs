using SupermarketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.DAO
{
    public class BanHangDAO
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True");
        public List<SanPhamDTO> proc_sale()
        {
            List<SanPhamDTO> products = new List<SanPhamDTO>();

            using (conn)
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("proc_sale", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SanPhamDTO product = new SanPhamDTO();
                            product.ProductID = reader.GetString(reader.GetOrdinal("ProductID"));
                            product.ProductName = reader.GetString(reader.GetOrdinal("ProductName"));
                            product.Unit = reader.GetString(reader.GetOrdinal("Unit"));
                            product.ProductIndex = reader.GetInt32(reader.GetOrdinal("ProductIndex"));
                            product.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                          //  product.Quanlity = reader.GetString(reader.GetOrdinal("Quanlity"));
                          //  product.ExpirationDate = reader.GetDateTime(reader.GetOrdinal("ExpirationDate"));
                         //   product.ProductPlace = reader.GetString(reader.GetOrdinal("ProductPlace"));
                          

                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }
    }
}
