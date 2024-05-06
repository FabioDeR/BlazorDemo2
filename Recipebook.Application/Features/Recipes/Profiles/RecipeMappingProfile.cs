using AutoMapper;
using Recipebook.Application.Features.Recipes.Commands.CreateRecipe.Record;
using RecipeBook.Common.CategoryRecipes.ViewModels;
using RecipeBook.Common.Recipes.Dto;
using RecipeBook.Common.Recipes.ViewModels;
using RecipeBook.Domain.Entities;
using RecipeBook.Recipes.Features.UpdateRecipe.Commands.UpdateRecipe.Record;

namespace Recipebook.Application.Features.Recipes.Profiles
{
	public class RecipeMappingProfile : Profile
	{
		public RecipeMappingProfile()
		{
			CreateMap<Recipe, CreateRecipeCommand>().ReverseMap();
			CreateMap<Recipe, CreateRecipeDto>().ReverseMap();
			CreateMap<Recipe, UpdateRecipeCommand>().ReverseMap();
			CreateMap<Recipe, GetListRecipeVM>().ReverseMap();
			CreateMap<Recipe, GetRecipeVM>().ReverseMap();
		}
	}
}
