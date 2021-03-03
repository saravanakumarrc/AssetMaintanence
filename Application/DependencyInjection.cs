using System;
using System.Collections.Generic;
using System.Text;
using Application.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IUnitsManager, UnitsManager>();
        }
    }
}
