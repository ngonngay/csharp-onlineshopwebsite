using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Data.Entities;
using Project.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.IsFeatured).HasDefaultValue(false);
            builder.Property(x => x.Price).IsRequired();

            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);

            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);

            builder.Property(x => x.productStatus).HasDefaultValue(ProductStatus.New);
            builder.HasMany<Category>(left => left.Categories)
                .WithMany(right => right.Products); 
                
        }
    }
}
