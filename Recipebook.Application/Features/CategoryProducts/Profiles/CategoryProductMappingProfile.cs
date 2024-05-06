using AutoMapper;
using Recipebook.Application.Features.Products.Commands.CreateProduct.Record;
using RecipeBook.Application.Features.CategoryProducts.Commands.UpdateCategoryProduct.Record;
using RecipeBook.Common.CategoryProducts.Dto;
using RecipeBook.Common.CategoryProducts.ViewModels;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.CategoryProducts.Profiles
{
	public class CategoryProductMappingProfile : Profile
	{
		public CategoryProductMappingProfile()
		{

			CreateMap<CategoryProduct, CreateProductCommand>().ReverseMap();
			CreateMap<CategoryProduct, CreateCategoryProductDto>().ReverseMap();
			CreateMap<CategoryProduct, UpdateCategoryProductCommand>().ReverseMap();
			CreateMap<CategoryProduct, GetListCategoryProductVM>().ReverseMap();
			CreateMap<CategoryProduct, GetCategoryProductVM>().ReverseMap();

		}
	}
}
