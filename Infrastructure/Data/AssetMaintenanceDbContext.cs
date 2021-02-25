using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class AssetMaintenanceDbContext : DbContext
    {
        public DbSet<Unit> Units { get; set; }

        public AssetMaintenanceDbContext(DbContextOptions<AssetMaintenanceDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
    }
}
