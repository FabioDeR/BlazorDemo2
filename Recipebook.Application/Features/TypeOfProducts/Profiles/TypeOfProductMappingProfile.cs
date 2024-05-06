using AutoMapper;
using Recipebook.Application.Features.TypeOfProducts.Commands.CreateTypeOfProduct.Record;
using RecipeBook.Common.TypeOfProducts.Dto;
using RecipeBook.Common.TypeOfProducts.ViewModels;
using RecipeBook.Domain.Entities;
using RecipeBook.TypeOfProducts.Features.UpdateTypeOfProduct.Commands.UpdateTypeOfProduct.Record;

namespace Recipebook.Application.Features.TypeOfProducts.Profiles
{
	public class TypeOfProductMappingProfile : Profile
	{
		public TypeOfProductMappingProfile()
		{

			CreateMap<TypeOfProduct, CreateTypeOfProductCommand>().ReverseMap();
			CreateMap<TypeOfProduct, CreateTypeOfProductDto>().ReverseMap();
			CreateMap<TypeOfProduct, UpdateTypeOfProductCommand>().ReverseMap();
			CreateMap<TypeOfProduct, GetListTypeOfProductVM>().ReverseMap();
			CreateMap<TypeOfProduct, GetTypeOfProductVM>().ReverseMap();

		}
	}
}
