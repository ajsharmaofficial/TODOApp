using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TODOApp.Application.Interfaces;

namespace TODOApp.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {

            #region Register Unit of Work
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            #endregion
        }
    }
}
