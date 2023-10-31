using InvoiceManagement.DAO.InvoiceDAO;
using InvoiceManagement.DAO.SalesDAO;
using InvoiceManagement.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManagement
{
    public partial class FormInvoice : Form
    {
        public FormInvoice()
        {
            InitializeComponent();
        }
        private void FormInvoice_Load(object sender, EventArgs e)
        {
            LoadCodeComboBoxes();
        }

        private void LoadCodeComboBoxes()
        {
            IInvoiceDAO dao = new InvoiceDAOImpl();
            DataSet ds = dao.LoadComboBox();
            if (ds.Tables["code_invoice"].Rows.Count > 0)
            {
                CodeCmb.DataSource = null;
                CodeCmb.SelectedIndexChanged -= CodeCmb_SelectedIndexChanged;
                CodeCmb.Items.Clear();
                CodeCmb.DataSource = ds.Tables[0];
                CodeCmb.DisplayMember = "codigo";
                CodeCmb.SelectedIndex = -1;
                CodeCmb.SelectedIndexChanged += CodeCmb_SelectedIndexChanged;
            }
            
            if (ds.Tables["info_catalog"].Rows.Count > 0)
            {
                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn) GridNewProducts.Columns["ProductColumn"];
                comboBoxColumn.DataSource = ds.Tables["info_catalog"];
                comboBoxColumn.DisplayMember = "nombre";
                comboBoxColumn.ValueMember = "codigo";
                GridNewProducts.RefreshEdit();
            }
        }

        private void CodeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IInvoiceDAO dao = new InvoiceDAOImpl();
                DataRowView selectedItem = (DataRowView)CodeCmb.SelectedItem;
                int invoiceId = (int)selectedItem["codigo"];
                DataSet dataSet = dao.ConsultInvoiceById(invoiceId);
                GridViewProducts.DataSource = dataSet.Tables["InfoPurchases"];
                GridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                float total = 0;
                DataTable dt = dataSet.Tables["InfoPurchases"];
                foreach (DataRow row in dt.Rows)
                {
                    float price = (float)row["precio"];
                    int amount = (int)row["cantidad"];
                    total += price * amount;
                }
                TotalTxt.Text = total.ToString();
                TotalTxt.ReadOnly = true;

                DataTable dataTable = dataSet.Tables["InfoClient"];
                StringBuilder stringBuilder = new StringBuilder();
                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime fecha = Convert.ToDateTime(row["fecha"]);
                    stringBuilder.AppendLine($"Client Name: {row["cliente"]}\n\nDate of Purchase: {fecha.ToString("d")}");
                }
                RichTextBox.Clear();
                RichTextBox.Text = stringBuilder.ToString();
                RichTextBox.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int invoiceId = int.Parse(InvoiceCodeTxt.Text.ToString().Trim());
                string clientName = ClientNameTxt.Text.ToString().Trim();
                DateTime dateOfPurchase = DatePurchaseTimer.Value.Date;

                IInvoiceDAO dao = new InvoiceDAOImpl();
                dao.InsertInvoice(new Invoice(invoiceId, clientName, dateOfPurchase));
                
                foreach (DataGridViewRow row in GridNewProducts.Rows)
                {
                    ISalesDAO daoSale = new SalesDAOImpl();
                    if (!row.IsNewRow) // Ignora la última fila si está vacía
                    {
                        int productId = 0;
                        int amount = 0;
                        if (row.Cells["ProductColumn"] is DataGridViewComboBoxCell comboBoxCell) { productId = (int)comboBoxCell.Value; }
                        if (row.Cells["AmountColumn"] is DataGridViewTextBoxCell textBoxCell) { amount = Convert.ToInt32(textBoxCell.Value); }

                        daoSale.InsertSale(new Sale(productId, amount, invoiceId));
                    }
                }
                MessageBox.Show("Data inserted correctly");
                LoadCodeComboBoxes();
                CleanFields();
            } 
            catch (FormatException ex)
            {
                MessageBox.Show("Format Error: invoice code must be only number\n\n" + ex.Message);
                return;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Error: " + ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void CleanFields()
        {
            InvoiceCodeTxt.Text = string.Empty;
            ClientNameTxt.Text = string.Empty;
            DatePurchaseTimer.Value = DateTime.Now;
            GridNewProducts.Rows.Clear();
        }
    }
}
