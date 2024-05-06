using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipeBook.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Persistance.Extensions
{
	public static class PersistanceDbContextRegister
	{
		public static IServiceCollection AddPersistanceDbContextServices(this IServiceCollection services,IConfiguration configuration)
		{
			services.AddDbContext<RecipeBookDbContext>(options =>
				options.UseSqlServer(configuration.GetConnectionString("RecipeDbContextConnectionString")));

			return services;
		}
	}
}
