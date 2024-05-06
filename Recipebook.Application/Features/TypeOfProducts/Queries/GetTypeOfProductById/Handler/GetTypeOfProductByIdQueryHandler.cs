



using AutoMapper;
using MediatR;
using Recipebook.TypeOfProducts.Features.TypeOfProducts.Queries.GetCategoryRecipeById.Record;
using RecipeBook.Common.TypeOfProducts.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.TypeOfProducts.Queries.GetTypeOfProductById.Handler
{
	public class GetTypeOfProductByIdQueryHandler : IRequestHandler<GetTypeOfProductByIdQuery, GetTypeOfProductVM>
	{
		public readonly IAsyncRepository<TypeOfProduct> _repository;

		public readonly IMapper _mapper;

		public GetTypeOfProductByIdQueryHandler(IAsyncRepository<TypeOfProduct> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}




		public async Task<GetTypeOfProductVM> Handle(GetTypeOfProductByIdQuery request, CancellationToken cancellationToken)
		{
			try
			{
				return _mapper.Map<GetTypeOfProductVM>(await _repository.GetByIdAsync(request.Id));
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
