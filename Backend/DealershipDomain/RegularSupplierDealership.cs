using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDomain
{
    public class RegularSupplierDealership
    {
        public Supplier Supplier { get; set; }
        public Dealership Dealership { get; set; }
        public int PurchaseAmount { get; set; }
        public SupplierDiscount SupplierDiscount { get; set; }
    }
}
