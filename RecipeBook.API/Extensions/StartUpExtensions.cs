using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Recipebook.Application.Extensions;
using RecipeBook.Persistance.Context;
using RecipeBook.Persistance.Extensions;
using RecipeBook.Repository.Extensions;
using System.Text.Json.Serialization;

namespace RecipeBook.API.Extensions
{
	public static class StartUpExtensions
	{
		public static WebApplication ConfigurationService(this WebApplicationBuilder builder)
		{
			AddSwagger(builder.Services);
			builder.Services.AddPersistanceDbContextServices(builder.Configuration);
			builder.Services.AddApplicationService();
			builder.Services.AddRepositoryServices();
            builder.Services.AddOpenApiDocument();
         
            builder.Services.AddSwaggerDocument();

            builder.Services.AddControllers().AddJsonOptions(x =>
			   x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddControllers();

			return builder.Build();
		}

		public static WebApplication ConfigurationPipeline(this WebApplication app)
		{
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI(c =>
				{
					c.SwaggerEndpoint("/swagger/v1/swagger.json", "RecipeBook API");
				});
			}

			app.UseHttpsRedirection();

			app.UseCors(x => x
				.AllowAnyMethod()
				.AllowAnyHeader()
				.SetIsOriginAllowed(origin => true)
				.AllowCredentials()
			);
            app.UseOpenApi();
            app.UseSwaggerUi();
            app.MapControllers();

			return app;
		}

		private static void AddSwagger(IServiceCollection services)
		{
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo
				{
					Version = "v1",
					Title = "RecipeBook API",

				});		

			});

		}

		//public static async Task ResetDataBaseAsync(this WebApplication app)
		//{
		//	using var scope = app.Services.CreateScope();
		//	try
		//	{
		//		var context = scope.ServiceProvider.GetService<RecipeBookDbContext>();
		//		if (context != null)
		//		{
		//			await context.Database.EnsureCreatedAsync();
		//			await context.Database.MigrateAsync();
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		var logger = scope.ServiceProvider.GetRequiredService<ILogger>();
		//		logger.LogError(ex, "An error occurred while migrating the database.");
		//	}
		//}

	}
}
