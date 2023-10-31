using InvoiceManagement.Connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.DAO.ChangePasswordDAO
{
    internal class ChangePassDAO : Database, IChangePasswordDAO
    {
        public void ChangePassword(string userName, string password)
        {
            try
            {
                using (MySqlConnection conn = GetLoginDBConnection())
                {
                    string sql = "update tb_login set clave = @password where usuario = @userName;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.ExecuteNonQuery();
                    }
                }
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
