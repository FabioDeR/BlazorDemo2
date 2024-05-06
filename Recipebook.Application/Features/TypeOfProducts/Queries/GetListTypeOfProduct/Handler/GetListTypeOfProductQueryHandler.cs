



using AutoMapper;
using MediatR;
using TypeOfProductbook.Application.Features.TypeOfProducts.Queries.GetListTypeOfProduct.Record;
using RecipeBook.Common.TypeOfProducts.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace TypeOfProductbook.Application.Features.TypeOfProducts.Queries.GetListCategoryTypeOfProduct.Handler
{
    public class GetListTypeOfProductQueryHandler : IRequestHandler<GetListTypeOfProductQuery, List<GetListTypeOfProductVM>>
	{
		public readonly IAsyncRepository<TypeOfProduct> _repository;
		public readonly IMapper _mapper;

		public GetListTypeOfProductQueryHandler(IAsyncRepository<TypeOfProduct> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<List<GetListTypeOfProductVM>> Handle(GetListTypeOfProductQuery request, CancellationToken cancellationToken)
		{
			try
			{
				return _mapper.Map<List<GetListTypeOfProductVM>>(await _repository.ListAllAsync());
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
