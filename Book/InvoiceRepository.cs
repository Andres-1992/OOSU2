using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class InvoiceRepository
    {
       private List<Invoice> invoices = new List<Invoice>();
        internal void AddInvoice( Invoice invoice)
        {
            invoices.Add(invoice);
        }
    }
}
