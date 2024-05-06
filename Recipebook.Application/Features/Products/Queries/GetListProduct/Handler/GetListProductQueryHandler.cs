



using AutoMapper;
using MediatR;
using Productbook.Application.Features.Products.Queries.GetListProduct.Record;
using RecipeBook.Common.Products.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Productbook.Application.Features.Products.Queries.GetListCategoryProduct.Handler
{
    public class GetListProductQueryHandler : IRequestHandler<GetListProductQuery, List<GetListProductVM>>
	{
		public readonly IAsyncRepository<Product> _repository;
		public readonly IMapper _mapper;

		public GetListProductQueryHandler(IAsyncRepository<Product> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<List<GetListProductVM>> Handle(GetListProductQuery request, CancellationToken cancellationToken)
		{
			try
			{
				return _mapper.Map<List<GetListProductVM>>(await _repository.ListAllAsync());
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
