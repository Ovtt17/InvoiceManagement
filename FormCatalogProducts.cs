using InvoiceManagement.DAO.CatalogDAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManagement
{
    public partial class FormCatalogProducts : Form
    {
        ICatalogDAO dao = new CatalogDAOImpl();
        private DataTable dataTable;

        public FormCatalogProducts()
        {
            InitializeComponent();
        }

        private void FormCatalogProducts_Load(object sender, EventArgs e)
        {
            dao = new CatalogDAOImpl();
            dataTable = dao.ConsultCatalog();
            GridCatalogProducts.DataSource = dataTable;
            GridCatalogProducts.ForeColor = Color.Black;
        }

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            dao.UpdateCatalog(dataTable);
        }
    }
}
