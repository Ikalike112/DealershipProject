using DealershipDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDatabase.EntityTypeConfigurations
{
    public class DealershipConfiguration : IEntityTypeConfiguration<Dealership>
    {
        public void Configure(EntityTypeBuilder<Dealership> builder)
        {
            /*
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.SupplierDealershipSales);
            builder.HasMany(x => x.DealershipDiscounts);
            builder.HasMany(x => x.DealershipModels);
            */

            builder.Property(x => x.VehicleCharacteristics)
    .HasConversion(v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
    v => JsonConvert.DeserializeObject<VehicleCharacteristics>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }))
            .HasColumnType("jsonb");
        }
    }
}
