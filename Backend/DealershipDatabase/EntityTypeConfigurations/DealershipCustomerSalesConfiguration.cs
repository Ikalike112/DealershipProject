using DealershipDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDatabase.EntityTypeConfigurations
{
    public class DealershipCustomerSalesConfiguration : IEntityTypeConfiguration<DealershipCustomerSales>
    {
        public void Configure(EntityTypeBuilder<DealershipCustomerSales> builder)
        {
            /*
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.DealershipModel);
            builder.HasOne(x => x.Discount);
            builder.HasOne(x => x.CustomerOffers);
            */

        }
    }
}
