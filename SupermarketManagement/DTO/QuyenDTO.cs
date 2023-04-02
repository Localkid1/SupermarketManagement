using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.DTO
{
    public class QuyenDTO
    {
        private int idRole;
        private string nameRole;

        public QuyenDTO(int idRole, string nameRole)
        {
            this.idRole = idRole;
            this.nameRole = nameRole;
        }

        QuyenDTO()
        {

        }

        public int IdRole { get => idRole; set => idRole = value; }
        public string NameRole { get => nameRole; set => nameRole = value; }
    }
}
