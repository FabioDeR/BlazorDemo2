using AutoMapper;
using Recipebook.Application.Features.Ingredients.Commands.CreateIngredient.Record;
using RecipeBook.Application.Features.Ingredients.Commands.Updateingredient;
using RecipeBook.Common.Artciles.Dto;
using RecipeBook.Common.Artciles.ViewModels;
using RecipeBook.Common.Ingredients.ViewModels;
using RecipeBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipebook.Application.Features.Ingredients.Profiles
{
    public class IngredientMappingProfile : Profile
	{
		public IngredientMappingProfile()
		{

			CreateMap<Ingredient, CreateIngredientCommand>().ReverseMap();
			CreateMap<Ingredient, UpdateIngredientCommand>().ReverseMap();
			CreateMap<Ingredient, CreateArtcilesDto>().ReverseMap();
			CreateMap<Ingredient, GetListIngredientVM>().ReverseMap();
			CreateMap<Ingredient, GetIngredientVM>().ReverseMap();
		}
	}
}
