﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YoutubeApi.Application.Interfaces.Repositories;
using YoutubeApi.Application.Interfaces.UnitOfWorks;
using YoutubeApi.Persistence.Context;
using YoutubeApi.Persistence.Repositories;
using YoutubeApi.Persistence.UnitOfWorks;

namespace YoutubeApi.Persistence
{
    public static class Registration
    {
        public static void AddPersistenceServices(this IServiceCollection services,IConfiguration configuration) 
        {
           services.AddDbContext<AppDbContext>(opt =>

           opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            
            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            services.AddScoped<IUnitOfWork , UnitOfWork>();

        }

    }
}
