using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Models
{
    internal class Sale
    {
        private int productId;
        private string productName;
        private float price;
        private int quantity;
        private int invoiceId;

        public Sale()
        {
        }

        public Sale(int productId, int quantity, int invoiceId)
        {
            ProductId = productId;
            Quantity = quantity;
            InvoiceId = invoiceId;
        }

        public int ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int InvoiceId { get => invoiceId; set => invoiceId = value; }
    }
}
