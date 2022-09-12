using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDomain
{
    public class Supplier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int FoundationYear { get; set; }
        public List<SupplierDiscount> SupplierDiscount { get; set; }
        public List<SupplierCars> SupplierCars { get; set; }
        public List<RegularSupplierDealerships> RegularSupplierDealerships { get; set; }
    }
}
