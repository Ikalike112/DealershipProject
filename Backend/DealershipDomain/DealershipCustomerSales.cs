using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDomain
{
    public class DealershipCustomerSales : BaseClass
    {
        public Guid Id { get; set; }
        public DealershipModels DealershipModel { get; set; }
        public CustomerOffers CustomerOffers { get; set; }
        public decimal Price { get; set; }
        public decimal PriceWithDiscount { get; set; }
        public DealershipDiscount Discount { get; set; }
    }
}
