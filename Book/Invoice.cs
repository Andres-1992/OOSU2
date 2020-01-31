using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class Invoice
    {
        private Reservation reservation { get; set; }
        private Member member { get; set; }
        private double totalAmount { get; set; }
        private DateTime from { get; set; }
        private DateTime to { get; set; }

    }

}
