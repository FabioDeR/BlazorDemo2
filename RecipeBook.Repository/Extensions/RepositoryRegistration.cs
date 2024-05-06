using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Repository.Extensions
{
	public static class RepositoryRegistration
	{
		public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
		{
			services.AddScoped(typeof(IAsyncRepository<>), typeof(AsyncRepository<>));
			return services;

		}
	}
}
