using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Models
{
    internal class Invoice
    {
        private int id;
        private string clientName;
        private DateTime dateOfPurchase;

        public Invoice()
        {
        }

        public Invoice(int id, string clientName, DateTime dateOfPurchase)
        {
            Id = id;
            ClientName = clientName;
            DateOfPurchase = dateOfPurchase;
        }

        public int Id { get => id; set => id = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public DateTime DateOfPurchase { get => dateOfPurchase; set => dateOfPurchase = value; }
    }
}
