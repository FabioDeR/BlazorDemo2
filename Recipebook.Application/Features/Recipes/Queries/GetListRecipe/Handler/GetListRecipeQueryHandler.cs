



using AutoMapper;
using MediatR;
using Recipebook.Application.Features.Recipes.Queries.GetListRecipe.Record;
using RecipeBook.Common.Recipes.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.Recipes.Queries.GetListCategoryRecipe.Handler
{
    public class GetListRecipeQueryHandler : IRequestHandler<GetListRecipeQuery, List<GetListRecipeVM>>
	{
		public readonly IAsyncRepository<Recipe> _repository;
		public readonly IMapper _mapper;

		public GetListRecipeQueryHandler(IAsyncRepository<Recipe> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<List<GetListRecipeVM>> Handle(GetListRecipeQuery request, CancellationToken cancellationToken)
		{
			try
			{
				return _mapper.Map<List<GetListRecipeVM>>(await _repository.ListAllAsync());
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
