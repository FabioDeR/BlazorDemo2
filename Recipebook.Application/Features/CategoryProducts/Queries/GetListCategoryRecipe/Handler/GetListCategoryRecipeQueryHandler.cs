using AutoMapper;
using MediatR;
using Productbook.Application.Features.CategoryProducts.Queries.GetListCategoryProduct.Record;
using RecipeBook.Common.CategoryProducts.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;



namespace Productbook.Application.Features.CategoryProducts.Queries.GetListCategoryProduct.Handler
{
    public class GetListCategoryProductQueryHandler : IRequestHandler<GetListCategoryProductQuery, List<GetListCategoryProductVM>>
	{
		public readonly IAsyncRepository<CategoryProduct> _repository;

		public readonly IMapper _mapper;

		public GetListCategoryProductQueryHandler(IAsyncRepository<CategoryProduct> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<List<GetListCategoryProductVM>> Handle(GetListCategoryProductQuery request, CancellationToken cancellationToken)
		{
			try
			{
				return _mapper.Map<List<GetListCategoryProductVM>>(await _repository.ListAllAsync());
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
