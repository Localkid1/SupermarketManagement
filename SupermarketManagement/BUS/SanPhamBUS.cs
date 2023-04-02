using SupermarketManagement.DAO;
using SupermarketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagement.BUS
{
    public class SanPhamBUS
    {
        private SanPhamDAO productDAO;

        public SanPhamBUS()
        {
            productDAO = new SanPhamDAO();
           
        }

        public List<SanPhamDTO> proc_product()
        {
            return productDAO.proc_product();
        }

        

        public bool AddProduct(SanPhamDTO product)
        {
            return productDAO.AddProduct(product);
        }

        public bool UpdateProduct(SanPhamDTO product)
        {
            return productDAO.UpdateProduct(product);
        }

        public bool DeleteProduct(SanPhamDTO product)
        {
            return productDAO.DeleteProduct(product);
        }

        public List<SanPhamDTO> GetProductsByName(string productName)
        {
            return productDAO.GetProductByName(productName);
        }

        public List<SanPhamDTO> GetProductsToExport()
        {
            return productDAO.proc_product();
        }

    }
}
