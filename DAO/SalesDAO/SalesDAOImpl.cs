using InvoiceManagement.Connection;
using InvoiceManagement.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManagement.DAO.SalesDAO
{
    internal class SalesDAOImpl : Database, ISalesDAO
    {
        public void InsertSale(Sale sale)
        {
            try
            {
                using (MySqlConnection conn = GetInvoiceDBConnection())
                {
                    string sql = "insert into ventas(codigo_producto, cantidad, codigo_factura) values (@productId, @quantity, @invoiceId);";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", sale.ProductId);
                        cmd.Parameters.AddWithValue("@quantity", sale.Quantity);
                        cmd.Parameters.AddWithValue("@invoiceId", sale.InvoiceId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public void DeleteSale(int id)
        {
            throw new NotImplementedException();
        }
    }
}
