using SupermarketManagement.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.DTO
{
    public class DangNhapDTO
    {
        public string idTK;
        public string userName;
        public string passWord;
        private int idRole;

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string IdTK { get => idTK; set => idTK = value; }
        public int IdRole { get => idRole; set => idRole = value; }

        public DangNhapDTO(string idTK, string userName, string passWord, int idRole)
        {
            this.idTK = idTK;
            this.UserName = userName;
            this.PassWord = passWord;
           
            this.IdRole = idRole;
        }

        public DangNhapDTO()
        {
        }
    }
}
