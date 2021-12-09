using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey(x => x.AddressCardId);
            builder.Property(x => x.AddressCardId).UseIdentityColumn();
            builder.Property(x => x.CityId).IsRequired();
            builder.Property(x => x.FullName).IsRequired();
            builder.Property(x => x.phoneNumber).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.DistricstId).IsRequired();
            builder.Property(x => x.WardsId).IsRequired();
            builder.HasOne(x => x.appUser).WithMany(x => x.Addresses).HasForeignKey(x => x.UserId);
        }
    }
}
