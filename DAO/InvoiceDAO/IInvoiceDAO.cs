using InvoiceManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.DAO.InvoiceDAO
{
    internal interface IInvoiceDAO
    {
        DataSet LoadComboBox();
        DataSet ConsultInvoiceById(int id);
        void InsertInvoice(Invoice invoice);
    }
}
