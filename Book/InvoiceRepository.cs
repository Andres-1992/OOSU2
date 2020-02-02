using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class InvoiceRepository
    {
        List<Invoice> invoices = new List<Invoice>();
        public void addInvoice( Invoice invoice)
        {
            invoices.Add(invoice);
        }
    }
}
