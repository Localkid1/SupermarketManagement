using SupermarketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SupermarketManagement.DAO
{
    public class DangNhapAcess:DataBaseAccess
    {
        public string CheckLogin(DangNhapDTO login)
        {
            string info = CheckLoginDTO(login);
            return info;
        }
    }
}
