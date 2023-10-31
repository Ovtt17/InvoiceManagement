using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceManagement.Connection;
using InvoiceManagement.Models;

namespace InvoiceManagement.DAO.LoginDAO
{
    internal class LoginDAOImpl : Database, ILoginDAO
    {
        public bool UserExists(User user)
        {
            using (MySqlConnection conn = GetLoginDBConnection())
            {
                string query = "SELECT COUNT(*) FROM tb_login WHERE usuario = @username AND clave = @password";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@username", user.UserName);
                    command.Parameters.AddWithValue("@password", user.Password);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    Console.WriteLine(count);
                    return count > 0;
                }       
            }
        }
    }
}
