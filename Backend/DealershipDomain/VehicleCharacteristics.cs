using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDomain
{
    public class VehicleCharacteristics
    {
        public int Year { get; set; }
        public string Body { get; set; } //Кузов
        public string Drive { get; set; } //Привод
        public string EngineType { get; set; }
        public string Transmission { get; set; }

    }
}
