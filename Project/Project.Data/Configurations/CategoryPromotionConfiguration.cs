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
    public class CategoryPromotionConfiguration : IEntityTypeConfiguration<CategoryPromotion>
    {
        public void Configure(EntityTypeBuilder<CategoryPromotion> builder)
        {
            builder.ToTable("CategoryPromotion");

            builder.HasKey(x => new { x.PromotionId, x.CategoryId });

            builder.HasOne(x => x.Promotion).WithMany(x => x.categoriesPromotion).HasForeignKey(x => x.PromotionId);
            builder.HasOne(x => x.Category).WithMany(x => x.CategoryPromotions).HasForeignKey(x => x.CategoryId);
        }


    }
}
