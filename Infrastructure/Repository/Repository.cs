using Application;
using Domain.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly AssetMaintenanceDbContext assetMaintenanceDbContext;

        public Repository(AssetMaintenanceDbContext assetMaintenanceDbContext)
        {
            this.assetMaintenanceDbContext = assetMaintenanceDbContext;
        }

        public async Task<T> Add(T entity)
        {
            await assetMaintenanceDbContext.AddAsync<T>(entity);
            await assetMaintenanceDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task Commit()
        {
            await assetMaintenanceDbContext.SaveChangesAsync();
        }
    }
}
