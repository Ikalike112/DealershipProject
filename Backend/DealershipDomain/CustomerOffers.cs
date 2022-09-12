using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDomain
{
    public class CustomerOffers : BaseClass
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public decimal OfferPrice { get; set; }
        public bool IsCompleted { get; set; }
        public Guid DealershipCustomerSalesId { get; set; }
        public DealershipCustomerSales DealershipCustomerSales { get; set; }
    }
}
