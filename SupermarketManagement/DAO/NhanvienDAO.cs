using SupermarketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SupermarketManagement.DAO
{
    public class NhanvienDAO
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True");
      //  private List<NhanvienDTO> suppliers;

        public List<NhanvienDTO> proc_employee()
        {
            List<NhanvienDTO> employee = new List<NhanvienDTO>();

            using (conn)
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("proc_employee", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NhanvienDTO employees = new NhanvienDTO();
                            employees.EmployeeID = reader.GetString(reader.GetOrdinal("EmployeeID"));
                            employees.EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName"));
                            employees.Position = reader.GetString(reader.GetOrdinal("Position"));
                            employees.Address = reader.GetString(reader.GetOrdinal("Address"));
                            employees.PhoneNumber = reader.GetString(reader.GetOrdinal("Phone"));

                            employee.Add(employees);
                        }
                    }
                }
            }

            return employee;
        }


        public bool AddEmployee(NhanvienDTO employee)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Nhanvien (EmployeeID, EmployeeName,Position, Address, Phone) VALUES (@EmployeeID, @EmployeeName,@Position, @Address, @Phone)", conn);

                cmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                cmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                cmd.Parameters.AddWithValue("@Position", employee.Position);
                cmd.Parameters.AddWithValue("@Address", employee.Address);
                cmd.Parameters.AddWithValue("@Phone", employee.PhoneNumber);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool UpdateEmployee(NhanvienDTO employee)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Nhanvien SET EmployeeName = @EmployeeName,Position=@Position, Address = @Address, Phone = @Phone WHERE EmployeeID = @EmployeeID", conn);

                cmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                cmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                cmd.Parameters.AddWithValue("@Position", employee.Position);
                cmd.Parameters.AddWithValue("@Address", employee.Address);
                cmd.Parameters.AddWithValue("@Phone", employee.PhoneNumber);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool DeleteEmployee(NhanvienDTO employee)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Nhanvien WHERE EmployeeID = @EmployeeID", conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public List<NhanvienDTO> GetEmployeeByName(string employeeName)
        {
            List<NhanvienDTO> employee = new List<NhanvienDTO>();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Nhanvien WHERE EmployeeName LIKE '%' + @EmployeeName + '%'", conn);
                cmd.Parameters.AddWithValue("@EmployeeName", employeeName);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    NhanvienDTO employees = new NhanvienDTO();
                    employees.EmployeeID = reader.GetString(reader.GetOrdinal("EmployeeID"));
                    employees.EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName"));
                    employees.Position = reader.GetString(reader.GetOrdinal("Position"));
                    employees.Address = reader.GetString(reader.GetOrdinal("Address"));
                    employees.PhoneNumber = reader.GetString(reader.GetOrdinal("Phone"));

                    employee.Add(employees);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return employee;
        }



    
}
}
