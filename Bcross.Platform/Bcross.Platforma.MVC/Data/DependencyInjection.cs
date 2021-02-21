﻿using Bcross.Platforma.MVC.Data.Repositories;
using Bcross.Platforma.MVC.Data.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcross.Platforma.MVC.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDi(this IServiceCollection services)
        {
            services.AddScoped<ICompanyRepository, CompanyRepository>();


            return services;
        }
    }
}