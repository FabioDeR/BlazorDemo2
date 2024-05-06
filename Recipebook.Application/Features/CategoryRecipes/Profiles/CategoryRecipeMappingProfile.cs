using AutoMapper;
using Recipebook.Application.Features.CategoryRecipes.Commands.CreateCategoryRecipe.Record;
using RecipeBook.Application.Features.CategoryRecipes.Commands.UpdateCategoryRecipe.Record;
using RecipeBook.Common.CategoryRecipes.Dto;
using RecipeBook.Common.CategoryRecipes.ViewModels;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.CategoryRecipes.Profiles
{
	public class CategoryRecipeMappingProfile : Profile
	{
		public CategoryRecipeMappingProfile() {

			CreateMap<CategoryRecipe, CreateCategoryRecipeCommand>().ReverseMap();
			CreateMap<CategoryRecipe, CreateCategoryRecipeDto>().ReverseMap();
			CreateMap<CategoryRecipe, UpdateCategoryRecipeCommand>().ReverseMap();
			CreateMap<CategoryRecipe, GetListCategoryRecipeVM>().ReverseMap();
			CreateMap<CategoryRecipe, GetCategoryRecipeVM>().ReverseMap();

		}
	}
}
