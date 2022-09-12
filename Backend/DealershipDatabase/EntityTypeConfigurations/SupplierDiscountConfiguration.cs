using DealershipDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDatabase.EntityTypeConfigurations
{
    public class SupplierDiscountConfiguration : IEntityTypeConfiguration<SupplierDiscount>
    {
        public void Configure(EntityTypeBuilder<SupplierDiscount> builder)
        {
            builder.Property(x => x.IdCars)
                .HasConversion(v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                v => JsonConvert.DeserializeObject<List<string>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                new ValueComparer<List<string>>(
            (c1, c2) => c1.SequenceEqual(c2),
            c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));
        }
    }
}
