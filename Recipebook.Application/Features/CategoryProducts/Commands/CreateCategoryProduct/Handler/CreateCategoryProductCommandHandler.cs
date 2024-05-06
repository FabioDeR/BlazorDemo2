using AutoMapper;
using MediatR;
using Productbook.Application.Features.CategoryProducts.Commands.CreateCategoryProduct.Record;
using RecipeBook.Common.CategoryProducts.Dto;
using RecipeBook.Common.CategoryProducts.Responses;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Productbook.Application.Features.CategoryProducts.Commands.CreateCategoryProduct.Handler
{
	public class CreateCategoryProductCommandHandler : IRequestHandler<CreateCategoryProductCommand, CreateCategoryProductCommandResponse>
	{
		private readonly IAsyncRepository<CategoryProduct> _categoryProductRepository;
		private readonly IMapper _mapper;

		public CreateCategoryProductCommandHandler(IAsyncRepository<CategoryProduct> categoryProductRepository, IMapper mapper)
		{
			_categoryProductRepository = categoryProductRepository;
			_mapper = mapper;
		}

		public async Task<CreateCategoryProductCommandResponse> Handle(CreateCategoryProductCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var createCategoryProductCommandResponse = new CreateCategoryProductCommandResponse();

				var categoryProduct = new CategoryProduct()
				{
					Name = request.Name,
				};
				await _categoryProductRepository.AddAsync(categoryProduct);
				createCategoryProductCommandResponse.CreateCategoryProductDto = _mapper.Map<CreateCategoryProductDto>(categoryProduct);
				return createCategoryProductCommandResponse;

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				throw;
			}
		}

	}
}

