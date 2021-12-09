
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Configurations
{
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.ToTable("Promotions");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ApplyForProductIds).HasDefaultValue(false);
            builder.Property(x => x.ApplyForCategoryIds).HasDefaultValue(false);
            builder.Property(x => x.ApplyForAll).HasDefaultValue(false);
            builder.Property(x => x.ApplyForOrderTotal).HasDefaultValue(false);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.ApplyCode).IsRequired();
            builder.Property(x => x.Description).IsRequired();
        }
    }
}
