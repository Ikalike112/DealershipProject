using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDomain
{
    public class DealershipCustomerSales
    {
        public Guid Id { get; set; }
        public DealershipModels DealershipModel { get; set; }
        public Customer Customer { get; set; }
        public decimal PriceWithDiscount { get; set; }
        public DealershipDiscount Discount { get; set; }
    }
}
