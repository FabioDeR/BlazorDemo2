using RecipeBook.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

var app = builder.ConfigurationService()
				 .ConfigurationPipeline();

//await app.ResetDataBaseAsync();
app.Run();
