using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DevFramework.Core.Infrastructure.Repository;

namespace DevFramework.Core.Infrastructure.Extensions
{
    public static class UnitOfWorkServiceCollectionExtensions
    {
 
        public static IServiceCollection AddUnitOfWork<TContext>(this IServiceCollection services) where TContext : DbContext
        {
            services.AddScoped<IRepositoryFactory, UnitOfWork<TContext>>();
            services.AddScoped<IUnitOfWork, UnitOfWork<TContext>>();
            return services;
        }

        public static IServiceCollection AddUnitOfWork<TContext1, TContext2>(this IServiceCollection services)
            where TContext1 : DbContext
            where TContext2 : DbContext
        {
            services.AddScoped<IUnitOfWork, UnitOfWork<TContext1>>();
            services.AddScoped<IUnitOfWork, UnitOfWork<TContext2>>();

            return services;
        }

    }
}
