using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Infrastructure.Data.EF
{
    public class ProjectNameDbContextFactory : IDesignTimeDbContextFactory<CleanArchitectureDbContext>
    {
        private const string conectionString = "Server=DEV404\\SQLEXPRESS;Database=CleanArchitectureData;Trusted_Connection=True;";

        public CleanArchitectureDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CleanArchitectureDbContext>();


            optionsBuilder.UseSqlServer(conectionString);

            return new CleanArchitectureDbContext(optionsBuilder.Options);
        }
    }
}
