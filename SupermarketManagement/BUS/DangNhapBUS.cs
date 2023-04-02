using SupermarketManagement.DAO;
using SupermarketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.BUS
{
    public class DangNhapBUS
    {

        DangNhapAcess dangnhap = new DangNhapAcess();
        public string CheckLogin(DangNhapDTO login)
        {
            //check 
            if (login.userName == "")
            {
                return "requeid_username";
            }
            if (login.passWord == "")
            {
                return "requeid_password";
            }

            string info = dangnhap.CheckLogin(login);
            return info;

        }
    }
}
