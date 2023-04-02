using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.DTO
{
    public class NhanvienDTO
    {
        string employeeID;
        string employeeName;
        string position;
        string address;
        string phoneNumber;

        public NhanvienDTO()
        {
        }

        public NhanvienDTO(string employeeID, string employeeName, string position, string address, string phoneNumber)
        {
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
            this.Position = position;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }

        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string Position { get => position; set => position = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
