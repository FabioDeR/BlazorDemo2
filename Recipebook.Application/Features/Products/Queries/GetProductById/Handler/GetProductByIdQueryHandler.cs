



using AutoMapper;
using MediatR;
using Recipebook.Products.Features.Products.Queries.GetCategoryRecipeById.Record;
using RecipeBook.Common.Products.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.Products.Queries.GetProductById.Handler
{
	public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductVM>
	{
		public readonly IAsyncRepository<Product> _repository;

		public readonly IMapper _mapper;

		public GetProductByIdQueryHandler(IAsyncRepository<Product> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}




		public async Task<GetProductVM> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
		{
			try
			{
				return _mapper.Map<GetProductVM>(await _repository.GetByIdAsync(request.Id));
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
