using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.DTO
{
    public class SanPhamDTO
    {
        private string productID;
        private string productName;
        private int productIndex;
        private float price;
        private string quanlity;
        private DateTime expirationDate;
        private string productPlace;
        private string unit;


        public SanPhamDTO(string productID, string productName, int productIndex, float price, string quanlity, DateTime expirationDate, string productPlace, string unit)
        {
            this.productID = productID;
            this.productName = productName;
            this.productIndex = productIndex;
            this.price = price;
            this.quanlity = quanlity;
            this.ExpirationDate = expirationDate;
            this.productPlace = productPlace;
            this.unit = unit;
        }
        public  SanPhamDTO()
        {

        }
        

        public string ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int ProductIndex { get => productIndex; set => productIndex = value; }
        public float Price { get => price; set => price = value; }
        public string Quanlity { get => quanlity; set => quanlity = value; }
        public string ProductPlace { get => productPlace; set => productPlace = value; }
        public string Unit { get => unit; set => unit = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }
        // public String productID;

    }
}
