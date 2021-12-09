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
    public class ProductPromotionConfiguration: IEntityTypeConfiguration<ProductPromotion>
    {
        public void Configure(EntityTypeBuilder<ProductPromotion> builder)
        {
            builder.ToTable("ProductPromotion");

            builder.HasKey(x => new { x.PromotionId, x.ProductId });

            builder.HasOne(x => x.Promotion).WithMany(x => x.productsPromotion).HasForeignKey(x => x.PromotionId);
            builder.HasOne(x => x.Product).WithMany(x => x.productPromotions).HasForeignKey(x => x.ProductId);
        }

       
    }
}
