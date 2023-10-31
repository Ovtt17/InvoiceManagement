using InvoiceManagement.Connection;
using InvoiceManagement.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManagement.DAO.InvoiceDAO
{
    internal class InvoiceDAOImpl : Database, IInvoiceDAO
    {
        
        public DataSet ConsultInvoiceById(int id)
        {
            try
            {
                DataSet dataSet = new DataSet();
                using (MySqlConnection conn = GetInvoiceDBConnection())
                {
                    string sql = "select * from factura where codigo = @code;";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(sql, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@code", id);
                        da.Fill(dataSet, "InfoClient");
                    }
                    sql = "detalles_venta";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(sql, conn))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@codigo_buscado", id);
                        da.Fill(dataSet, "InfoPurchases");
                    }
                }
                return dataSet;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public void InsertInvoice(Invoice invoice)
        {
           try
            {
                using (MySqlConnection conn = GetInvoiceDBConnection())
                {
                    string sql = "insert into factura(codigo, cliente, fecha) values (@code, @clientName, @date);";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@code", invoice.Id);
                        cmd.Parameters.AddWithValue("@clientName", invoice.ClientName);
                        cmd.Parameters.AddWithValue("@date", invoice.DateOfPurchase);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public DataSet LoadComboBox()
        {
            try
            {
                DataSet dataSet = new DataSet();
                using (MySqlConnection conn = GetInvoiceDBConnection())
                {
                    string sql = "select codigo from factura;";
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                    {
                        // Execute the SQL query and fill the DataSet with the results
                        dataAdapter.Fill(dataSet, "code_invoice");
                    }
                    sql = "select codigo, nombre from catalogo;";
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                    {
                        // Execute the SQL query and fill the DataSet with the results
                        dataAdapter.Fill(dataSet, "info_catalog");
                    }
                }
                return dataSet;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
    }
}
