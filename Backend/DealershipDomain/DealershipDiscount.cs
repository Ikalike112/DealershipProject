using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDomain
{
    public class DealershipDiscount : BaseClass
    {
        public Guid Id { get; set; }
        public Guid DealershipId { get; set; }
        public Dealership Dealership { get; set; }
        public string Title { get; set; }
        public int Discount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public List<string> IdCars { get; set; }
    }
}
