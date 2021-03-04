using Infrastructure.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Application.UnitTest
{
    internal class DbContextFactory
    {
        public DbContextFactory()
        {
        }

        public AssetMaintenanceDbContext CreateInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<AssetMaintenanceDbContext>().UseInMemoryDatabase("InMemoryDb").Options;
            return new AssetMaintenanceDbContext(options);
        }

        public AssetMaintenanceDbContext CreateSqlLiteDbContext()
        {
            var connection = new SqliteConnection("DataSource=:memory");
            var options = new DbContextOptionsBuilder<AssetMaintenanceDbContext>().UseSqlite(connection).Options;
            return new AssetMaintenanceDbContext(options);
        }
    }
}