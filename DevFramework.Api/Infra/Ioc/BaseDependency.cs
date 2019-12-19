using System;
using AutoMapper;
using DevFramework.Core.Infrastracture.Http;
using DevFramework.Core.Infrastructure.Auth;
using DevFramework.Data.Context;
using DevFramework.Data.Repository;
using DevFramework.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace DevFramework.Api.Infra.Ioc
{
    public class BaseDependency
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = " Geo Distance API V1", Version = "v1" });
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddAutoMapper();
            services.AddSingleton<IHttpClient, StandardHttpClient>();

            //repository DI
            services.AddTransient<IDistanceRepository, DistanceRepository<DevContext>>();
            services.AddTransient<IRequestRepository, RequestRepository<DevContext>>();

            //service DI            
            services.AddSingleton<IJwtFactory, JwtFactory>();
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IDistanceService, DistanceService>();

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    bl => bl.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }
    }
}
