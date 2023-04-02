using SupermarketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.DAO
{
    public class HoaDonBanDAO
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True");

        public bool AddInvoice(List<HoaDonBanDTO> invoice)
        {
            bool ketQua = false;
          //  SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
              
                conn.Open();
                foreach (HoaDonBanDTO invoices in invoice)
                {
                    string query = "INSERT INTO HoaDonBan (InvoiceID, ProductID, ProductName, Unit, ProductIndex, InvoiceDate, TotalAmount) " +
                        "VALUES (@InvoiceID, @ProductID, @ProductName, @Unit, @ProductIndex, @InvoiceDate, @TotalAmount)";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@InvoiceID", invoices.InvoiceID);
                    cmd.Parameters.AddWithValue("@ProductID", invoices.ProductID);
                    cmd.Parameters.AddWithValue("@ProductName", invoices.ProductName);
                    cmd.Parameters.AddWithValue("@Unit", invoices.Unit);
                    cmd.Parameters.AddWithValue("@ProductIndex", invoices.ProductIndex);
                    cmd.Parameters.AddWithValue("@InvoiceDate", invoices.InvoiceDate);
                    cmd.Parameters.AddWithValue("@DonGia", invoices.TotalAmount);
                   
                    cmd.ExecuteNonQuery();
                }
                ketQua = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                
            }
            return ketQua;
        }

    }
}
