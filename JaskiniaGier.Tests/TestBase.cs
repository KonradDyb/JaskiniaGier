using JaskiniaGier.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace JaskiniaGier.Tests
{
    public class TestBase
    {
        private bool useSqlServer;

        public AppDbContext GetDbContext()
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            if(useSqlServer)
            {

                builder.UseSqlServer("server=(localdb)\\mssqllocaldb;Database=JaskiniaGier;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
            else
            {
                builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            }

            var dbContext = new AppDbContext(builder.Options);
            if(useSqlServer)
            {
                dbContext.Database.OpenConnection();
            }

            dbContext.Database.EnsureCreated();

            return dbContext;
        }

        public void UseSqlServer()
        {
            useSqlServer = true;
        }
    }
}
