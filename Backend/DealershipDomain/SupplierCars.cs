using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDomain
{
    public class SupplierCars
    {
        public Guid Id { get; set; }
        public Supplier Supplier { get; set; }
        public Car Car { get; set; }
        public decimal BasePrice { get; set; }
    }
}
