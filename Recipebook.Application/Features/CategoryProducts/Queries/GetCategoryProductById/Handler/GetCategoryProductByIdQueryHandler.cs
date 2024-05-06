

using AutoMapper;
using MediatR;
using Recipebook.Application.Features.CategoryRecipes.Queries.GetCategoryProductById.Record;
using RecipeBook.Common.CategoryProducts.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.CategoryProducts.Queries.GetCategoryProductById.Handler
{
	public class GetCategoryProductByIdQueryHandler : IRequestHandler<GetCategoryProductByIdQuery, GetCategoryProductVM>
	{
		public readonly IAsyncRepository<CategoryProduct> _repository;

		public readonly IMapper _mapper;

		public GetCategoryProductByIdQueryHandler(IAsyncRepository<CategoryProduct> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<GetCategoryProductVM> Handle(GetCategoryProductByIdQuery request, CancellationToken cancellationToken)
		{
			try
			{
				return _mapper.Map<GetCategoryProductVM>(await _repository.GetByIdAsync(request.Id));
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
