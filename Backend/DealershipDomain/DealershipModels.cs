using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDomain
{
    public class DealershipModels : BaseClass
    {
        public Guid Id { get; set; }
        public Car Car { get; set; }
        public Dealership Dealership { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        
    }
}
