using SupermarketManagement.DAO;
using SupermarketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.BUS
{
    public class NhanvienBUS
    {
        private NhanvienDAO employeeDAO;

        public NhanvienBUS()
        {
            employeeDAO = new NhanvienDAO();

        }

        public List<NhanvienDTO> proc_employee()
        {
            return employeeDAO.proc_employee();
        }

        public bool AddEmployee(NhanvienDTO employee)
        {
            return employeeDAO.AddEmployee(employee);
        }

        public bool UpdateEmployee(NhanvienDTO employee)
        {
            return employeeDAO.UpdateEmployee(employee);
        }

        public bool DeleteEmployee(NhanvienDTO employee)
        {
            return employeeDAO.DeleteEmployee(employee);
        }

        public List<NhanvienDTO> GetEmployeesByName(string employeeName)
        {
            return employeeDAO.GetEmployeeByName(employeeName);
        }

        public List<NhanvienDTO> GetEmployeesToExport()
        {
            return employeeDAO.proc_employee();
        }

    }
}
