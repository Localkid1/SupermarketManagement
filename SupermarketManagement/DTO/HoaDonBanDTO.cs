using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.DTO
{
    public class HoaDonBanDTO
    {
        private string invoiceID;
        private string productID;
        private string productName;
        private string unit;
        private int productIndex;
        private DateTime invoiceDate;
        private float totalAmount;

        public string InvoiceID { get => invoiceID; set => invoiceID = value; }
        public string ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Unit { get => unit; set => unit = value; }
        public int ProductIndex { get => productIndex; set => productIndex = value; }
        public DateTime InvoiceDate { get => invoiceDate; set => invoiceDate = value; }
        public float TotalAmount { get => totalAmount; set => totalAmount = value; }

        public HoaDonBanDTO()
        {

        }
        public HoaDonBanDTO(string invoiceID, string productID, string productName, string unit, int productIndex, DateTime invoiceDate,float totalAmount)
        {
            this.invoiceID = invoiceID;
            this.productID = productID;
            this.productName = productName;
            this.unit = unit;
            this.productIndex = productIndex;
            this.invoiceDate = invoiceDate;
            this.totalAmount = totalAmount;
        }
    }
    
    
}
