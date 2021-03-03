using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public interface IAssetMaintenanceDbContext
    {
        DbSet<Unit> Units { get; set; }
    }
}