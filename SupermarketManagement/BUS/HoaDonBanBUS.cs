using SupermarketManagement.DAO;
using SupermarketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.BUS
{
    public class HoaDonBanBUS
    {
     

        public HoaDonBanBUS()
        {
            

        }

        public bool AddInvoice(List<HoaDonBanDTO> invoiceDAO)
        {
            HoaDonBanDAO invoicesDAO = new HoaDonBanDAO();
            return invoicesDAO.AddInvoice(invoiceDAO);
        }

    }
}
