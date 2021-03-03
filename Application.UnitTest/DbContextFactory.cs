using Infrastructure.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitTest
{
    public class DbContextFactory
    {
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
