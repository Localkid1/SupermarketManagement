using SupermarketManagement.DAO;
using SupermarketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.BUS
{
    public class NhaCungCapBUS
    {
        private NhaCungCapDAO supplierDAO;

        public NhaCungCapBUS()
        {
            supplierDAO = new NhaCungCapDAO();

        }

        public List<NhaCungCapDTO> proc_supplier()
        {
            return supplierDAO.proc_supplier();
        }

        public bool AddSupplier(NhaCungCapDTO supplier)
        {
            return supplierDAO.AddSupplier(supplier);
        }

        public bool UpdateSupplier(NhaCungCapDTO supplier)
        {
            return supplierDAO.UpdateSupplier(supplier);
        }

        public bool DeleteSupplier(NhaCungCapDTO supplier)
        {
            return supplierDAO.DeleteSupplier(supplier);
        }

        public List<NhaCungCapDTO> GetProductsByName(string orderName)
        {
            return supplierDAO.GetProductByName(orderName);
        }

        public List<NhaCungCapDTO> GetProductsToExport()
        {
            return supplierDAO.proc_supplier();
        }

    }
}
