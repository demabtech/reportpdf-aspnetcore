using System;
using System.Collections.Generic;

namespace ReportPdfAspNetCore.Models
{
    public class Invoice
    {
        public string InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public decimal Tax { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal TotalTax { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }
    }

    public class InvoiceDetail
    {
        public string InvoiceNumber { get; set; }
        public string Product { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
