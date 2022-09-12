using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDomain
{
    public class RegularDealershipCustomers
    {
        public Guid Id { get; set; }
        public Dealership Dealership { get; set; }
        public Customer Customer { get; set; }
        public int PurchaseAmount { get; set; }
        public DealershipCustomerSales Discount { get; set; }
    }
}
