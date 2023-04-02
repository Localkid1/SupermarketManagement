using SupermarketManagement.DAO;
using SupermarketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.BUS
{
    public class BanHangBUS
    {
        private BanHangDAO productDAO;

        public BanHangBUS()
        {
            productDAO = new BanHangDAO();

        }

        public List<SanPhamDTO> proc_sale()
        {
            return productDAO.proc_sale();
        }
    }
}
