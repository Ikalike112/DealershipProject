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
    public class CustomerOffersConfiguration : IEntityTypeConfiguration<CustomerOffers>
    {
        public void Configure(EntityTypeBuilder<CustomerOffers> builder)
        {
            /*
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.DealershipCustomerSales);
            */
            builder.HasOne(x => x.DealershipCustomerSales)
                .WithOne(x => x.CustomerOffers)
                .HasForeignKey<CustomerOffers>(x=> x.DealershipCustomerSalesId);
        }
    }
}
