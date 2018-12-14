using AmCart.ProductModule.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmCart.ProductModule.Configuration
{
    public static class ExtensionUnitOfWorkService
    {
        /// <summary>
        /// Registers the repositories.
        /// </summary>
        /// <param name="service">The service collection.</param>
		public static void RegisterRepositories(this IServiceCollection service)
        {
            service.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
