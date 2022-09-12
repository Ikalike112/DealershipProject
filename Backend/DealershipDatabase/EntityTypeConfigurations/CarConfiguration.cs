using DealershipDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDatabase.EntityTypeConfigurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {

        public void Configure(EntityTypeBuilder<Car> builder)
        {
            //builder.HasKey(c => c.Id);

            builder.HasMany(x => x.CustomerOffers)
                .WithOne(o => o.Car)
                .HasForeignKey(o => o.DealershipCustomerSalesId);
            /*
            builder.HasMany(x => x.DealershipModels);
            builder.HasMany(x => x.SupplierCars)
                .WithOne(s => s.Car);
            */
            builder.Property(x => x.Model).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Characteristics)
                .HasConversion(v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                v => JsonConvert.DeserializeObject<VehicleCharacteristics>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }))
                .HasColumnType("jsonb");
        }
    }
}
