using Microsoft.Extensions.DependencyInjection;
using Recipebook.Application.Features.Articles.Profiles;
using Recipebook.Application.Features.CategoryProducts.Profiles;
using Recipebook.Application.Features.CategoryRecipes.Profiles;
using Recipebook.Application.Features.Ingredients.Profiles;
using Recipebook.Application.Features.Products.Profiles;
using Recipebook.Application.Features.Recipes.Profiles;
using Recipebook.Application.Features.Shifts.Profiles;
using Recipebook.Application.Features.TypeOfProducts.Profiles;
using Recipebook.Application.Features.UnitOfMeasurements.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Recipebook.Application.Extensions
{
    public static class ApplicationRegister
    {




        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(op =>
            {
                op.AddProfile(new ArticleMappingProfile());
                op.AddProfile(new ProductMappingProfile());
                op.AddProfile(new CategoryProductMappingProfile());
                op.AddProfile(new CategoryRecipeMappingProfile());
                op.AddProfile(new RecipeMappingProfile());
                op.AddProfile(new ShiftMappingProfile());
                op.AddProfile(new TypeOfProductMappingProfile());
                op.AddProfile(new UnitOfMeasurementMappingProfile());
                op.AddProfile(new IngredientMappingProfile());

            });
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
