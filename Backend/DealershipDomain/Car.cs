using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDomain
{
    public class Car : BaseClass
    { 
        public Guid Id { get; set; }
        public string Model { get; set; }
        public VehicleCharacteristics Characteristics { get;set;} 
        public List<SupplierCars> SupplierCars { get; set; }
        public List<DealershipModels> DealershipModels { get; set; }
        public List<CustomerOffers> CustomerOffers { get; set; }
    }
}
