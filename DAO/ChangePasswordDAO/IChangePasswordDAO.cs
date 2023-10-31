using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.DAO.ChangePasswordDAO
{
    internal interface IChangePasswordDAO
    {
        void ChangePassword(string userName, string password);
    }
}
