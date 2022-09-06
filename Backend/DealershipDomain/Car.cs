using System;
using System.Collections.Generic;
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
    }
}
