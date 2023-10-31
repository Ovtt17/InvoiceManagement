using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.DAO.CatalogDAO
{
    internal interface ICatalogDAO
    {
        DataTable ConsultCatalog();
        void UpdateCatalog(DataTable dataTable);
    }
}
