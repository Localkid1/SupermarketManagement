using SupermarketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagement.GUI;

namespace SupermarketManagement.DAO
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strconn = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
    }



    public class DataBaseAccess
    {
        public static string CheckLoginDTO(DangNhapDTO login)
        {
            string user = null;
           // string role = null;
            //connect to DB
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_login", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", login.userName);
            cmd.Parameters.AddWithValue("@pass", login.passWord);

            
           // cmd.CommandText = "SELECT q.nameRole FROM Quyen q INNER JOIN TaiKhoan nd ON q.idRole = nd.idRole WHERE nd.username = @user and nd.password = @pass" ;


            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);                 
                    return user;                                
                }
                
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }

            return user;
        }


      
    }

   
}
