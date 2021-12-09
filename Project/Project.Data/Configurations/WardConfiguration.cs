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
    public class WardConfiguration : IEntityTypeConfiguration<Ward>
    {
        public void Configure(EntityTypeBuilder<Ward> builder)
        {
            builder.ToTable("Ward");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.district).WithMany(x => x.Wards).HasForeignKey(x => x.DistrictId);
            builder.HasOne(x => x.City).WithMany(x => x.Wards).HasForeignKey(x => x.CityId);
        }
    }
}
