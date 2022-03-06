using Clean.Architecture.Core.Interfaces;
using Clean.Architecture.Core.Repositorys.Infratructure;
using Clean.Architecture.Core.Services;
using Clean.Architecture.Infrastructure.Data.EF;
using Clean.Architecture.Infrastructure.Repositorys.Infratructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.Architecture.Web.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
            //builder.AddFilter(DbLoggerCategory.Database.Name, LogLevel.Information);
            builder.AddConsole();
        });
        public static IServiceCollection AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CleanArchitectureDbContext>(options => {
                string connectstring = configuration.GetConnectionString("CleanArchitectureContext");
                // hien thi cau truy van ra cua so console
                options.UseLoggerFactory(loggerFactory);
                options.UseSqlServer(connectstring);
            });

            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
