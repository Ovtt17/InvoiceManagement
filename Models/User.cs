using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Models
{
    internal class User
    {
        private string userName;
        private string password;

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
    }
}
