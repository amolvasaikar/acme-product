﻿using AcmeProducts.Application.Interfaces;
using AcmeProducts.Infrastructure.FileManager.Contexts;
using AcmeProducts.Infrastructure.FileManager.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AcmeProducts.Infrastructure.FileManager
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddFileManagerInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FileManagerDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("FileManagerConnection"));
            });
            services.AddScoped<IFileManagerService, FileManagerService>();
            return services;

        }
    }
}