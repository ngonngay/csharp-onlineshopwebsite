using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Data.EF
{
    public class ProjectDbContextFactory : IDesignTimeDbContextFactory<ProjectDbContext>
    {
        public ProjectDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ProjectOnlineShopDb3");

            var optionsBuilder = new DbContextOptionsBuilder<ProjectDbContext>();
            optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("Project.AdminApp"));
            /* var connectionString = configuration.GetConnectionString("ProjectOnlineShopDb3");

             var optionsBuilder = new DbContextOptionsBuilder<ProjectDbContext>();
             optionsBuilder.UseSqlServer(connectionString);*/

            return new ProjectDbContext(optionsBuilder.Options);
        }
    }
}
