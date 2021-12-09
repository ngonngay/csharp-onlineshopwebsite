using Project.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");
            builder.Property(x => x.UserName).IsRequired();
            builder.Property(x => x.Birthday).IsRequired();
            builder.Property(x => x.disable).HasDefaultValue(false);
            builder.Property(x => x.LastSignIn).HasDefaultValue(DateTime.Now);
           
        }
    }
}
