﻿
using Jazani.Domain.Admins.Repositories;
using Jazani.Infrastructure.Cores.Persistenses;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Jazani.Infrastructure.Cores.Contexts
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DbConnection"))
            );

            services.AddTransient<INatureRepository, NatureRepository>();
            services.AddTransient<IAlertRepository, AlertRepository>();

            return services;
        }
    }
}
