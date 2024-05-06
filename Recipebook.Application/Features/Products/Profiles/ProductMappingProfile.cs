using AutoMapper;
using Recipebook.Application.Features.Products.Commands.CreateProduct.Record;
using RecipeBook.Common.CategoryProducts.ViewModels;
using RecipeBook.Common.Products.Dto;
using RecipeBook.Common.Products.ViewModels;
using RecipeBook.Domain.Entities;
using RecipeBook.Products.Features.UpdateProduct.Commands.UpdateProduct.Record;

namespace Recipebook.Application.Features.Products.Profiles
{
	public class ProductMappingProfile : Profile
	{
		public ProductMappingProfile()
		{

			CreateMap<Product, CreateProductCommand>().ReverseMap();
			CreateMap<Product, CreateProductDto>().ReverseMap();
			CreateMap<Product, UpdateProductCommand>().ReverseMap();
			CreateMap<Product, GetListProductVM>().ReverseMap();
			CreateMap<Product, GetProductVM>().ReverseMap();

		}
	}
}
