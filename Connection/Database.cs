using InvoiceManagement.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManagement.Connection
{
    internal class Database
    {
        private readonly string loginDBConnectionString = "Server=localhost;Database=bd_login;User ID=root;Password=Ovettmora_12;";
        private readonly string invoiceDBConnectionString = "Server=localhost;Database=bd_ventas;User ID=root;Password=Ovettmora_12;";
        public MySqlConnection GetLoginDBConnection()
        {
            MySqlConnection loginDBConnection = new MySqlConnection(loginDBConnectionString);
            try
            {
                loginDBConnection.Open();
                Console.WriteLine("Conexión exitosa a bd_login");
                return loginDBConnection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión a bd_login: " + ex.Message);
                throw; // Re-lanzar la excepción para que se maneje en un nivel superior
            }
        }

        public MySqlConnection GetInvoiceDBConnection()
        {
            MySqlConnection invoiceDBConnection = new MySqlConnection(invoiceDBConnectionString); ;
            try
            {
                invoiceDBConnection.Open();
                Console.WriteLine("Conexión exitosa a bd_ventas");
                return invoiceDBConnection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión a bd_ventas: " + ex.Message);
                return null;
            }

        }
    }
}
