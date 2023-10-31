using InvoiceManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.DAO.SalesDAO
{
    internal interface ISalesDAO
    {
        void InsertSale(Sale sale);
        void DeleteSale(int id);
    }
}
