using ReportPdfAspNetCore.Models;
using System.IO;
using System.Text;

namespace ReportPdfAspNetCore.Services
{
    public static class TemplateParser
    {
        public static string Parse(string path)
        {
            Invoice invoice = InvoiceService.Get();

            string content = File.ReadAllText(path)
                .Replace("{{customer}}", invoice.Customer)
                .Replace("{{address}}", invoice.Address)
                .Replace("{{email}}", invoice.Email)
                .Replace("{{numberInvoice}}", invoice.InvoiceNumber)
                .Replace("{{date}}", invoice.Date.ToString("dd-MM-yyyy"))
                .Replace("{{dueDate}}", invoice.DueDate.ToString("dd-MM-yyyy"));

            StringBuilder sb = new StringBuilder();

            foreach (var invoiceItem in invoice.InvoiceDetails)
            {
                sb.Append("<tr>");
                sb.Append($"<td class='no'>{invoiceItem.InvoiceNumber}</td>");
                sb.Append($"<td class='desc'><h3>{invoiceItem.Product}</h3>{invoiceItem.Description}</td>");
                sb.Append($"<td class='unit'>${invoiceItem.Price}</td>");
                sb.Append($"<td class='qty'>{invoiceItem.Quantity}</td>");
                sb.Append($"<td class='total'>${invoiceItem.Total}</td>");
                sb.Append("</tr>");
            }

            content = content.Replace("{{invoiceDetails}}", sb.ToString())
                .Replace("{{subTotal}}", invoice.SubTotal.ToString("C"))
                .Replace("{{tax}}", invoice.Tax.ToString())
                .Replace("{{total}}", invoice.Total.ToString("C"));

            return content;
        }
    }
}
