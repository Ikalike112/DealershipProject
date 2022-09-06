using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDomain
{
    public class SupplierDealershipSales
    {
        public Guid Id { get; set; }
        public SupplierCars SupplierCar { get; set; }
        public Dealership Dealership { get; set; }
        public int Amount { get; set; }
        public decimal PriceWithDiscount { get; set; }
        public SupplierDiscount Discount { get; set; }
    }
}
