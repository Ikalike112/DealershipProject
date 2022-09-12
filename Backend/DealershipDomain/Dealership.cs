using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDomain
{
    public class Dealership : BaseClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public VehicleCharacteristics VehicleCharacteristics { get; set; }
        public decimal Balance { get; set; }
        public List<DealershipDiscount> DealershipDiscounts { get; set; }
        public List<DealershipModels> DealershipModels { get; set; }
        public List<SupplierDealershipSales> SupplierDealershipSales { get; set; }

    }
}
