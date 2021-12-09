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
    public class ReviewConfiguration : IEntityTypeConfiguration<Reviews>
    {
        public void Configure(EntityTypeBuilder<Reviews> builder)
        {
            builder.ToTable("Reviews");
            builder.Property(x => x.id).IsRequired();
            builder.Property(x => x.email).IsRequired();
            builder.Property(x => x.review).IsRequired().HasMaxLength(200);
            builder.HasKey(x => x.id);
            builder.HasOne(x => x.product).WithMany(x => x.Reviews).HasForeignKey(x => x.ProductId);
        }
    }
}
