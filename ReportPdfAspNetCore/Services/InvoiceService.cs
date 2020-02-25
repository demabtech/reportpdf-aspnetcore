using ReportPdfAspNetCore.Models;
using System;
using System.Collections.Generic;

namespace ReportPdfAspNetCore.Services
{
    public static class InvoiceService
    {
        public static Invoice Get()
        {
            return new Invoice
            {
                InvoiceNumber = "DM-0123",
                Customer = "Carlos Dema",
                Address = "Bogotá, Colombia",
                Email = "carlosdema@demabtech.com",
                Date = DateTime.Now,
                DueDate = DateTime.Now.AddDays(30),
                Tax = 0.19M,
                Total = 6188M,
                SubTotal = 5200M,
                TotalTax = 988M,
                InvoiceDetails = new List<InvoiceDetail>
                {
                    new InvoiceDetail{ InvoiceNumber = "01", Product = "Website Design", Description = "Creating a recognizable design solution based on the company's existing visual identity", Price = 40.00M, Quantity= 30, Total = 1200M },
                    new InvoiceDetail{ InvoiceNumber = "02", Product = "Website Development", Description = "Developing a Content Management System-based Website", Price = 40.00M, Quantity= 80, Total = 3200M },
                    new InvoiceDetail{ InvoiceNumber = "03", Product = "Search Engines Optimization", Description = "Optimize the site for search engines (SEO)", Price = 40.00M, Quantity= 20, Total = 800M },
                }
            };
        }
    }
}
