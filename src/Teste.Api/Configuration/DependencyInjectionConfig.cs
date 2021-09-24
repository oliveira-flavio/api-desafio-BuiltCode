using Desafio.Business.Interfaces;
using Desafio.Business.Services;
using Desafio.Data.Context;
using Desafio.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<DesafioDbContext>();
            services.AddScoped<IMedicoRepository, MedicoRepository>();
            services.AddScoped<IMedicoService, MedicoService>();

            return services;
        }
    }
}
