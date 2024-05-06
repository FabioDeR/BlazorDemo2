
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using RecipeBook.Service.Contract;
using RecipeBook.Service.Services;


namespace RecipeBook.Service.Extensions
{
    public static class ServiceRegister
    {

        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7261/")
            });
            services.AddScoped<IRecipeBookDataServiceProvider,RecipeBookDataServiceProvider>();
            return services;
        }
    }
}
