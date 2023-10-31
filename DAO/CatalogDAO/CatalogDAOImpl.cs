using InvoiceManagement.Connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManagement.DAO.CatalogDAO
{
    internal class CatalogDAOImpl : Database, ICatalogDAO
    {
        private MySqlDataAdapter da;
        public DataTable ConsultCatalog()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (MySqlConnection conn = GetInvoiceDBConnection())
                {
                    string sql = "select * from catalogo;";
                    da = new MySqlDataAdapter(sql, conn);
                    MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                    da.Fill(dataTable);
                    return dataTable;
                }
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateCatalog(DataTable dataTable)
        {
            try
            {
                da.Update(dataTable);
                MessageBox.Show("Data changed successfully");
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
