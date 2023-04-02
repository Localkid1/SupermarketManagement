using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.DTO
{
    public class NhaCungCapDTO
    {
        string orderID;
        string ordderName;
        string address;
        string phoneNumber;


        public NhaCungCapDTO()
        {

        }

        public NhaCungCapDTO(string orderID, string ordderName, string address, string phoneNumber)
        {
            this.orderID = orderID;
            this.ordderName = ordderName;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public string OrderID { get => orderID; set => orderID = value; }
        public string OrdderName { get => ordderName; set => ordderName = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
