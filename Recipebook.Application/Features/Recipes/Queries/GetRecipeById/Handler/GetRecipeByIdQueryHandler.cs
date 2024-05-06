



using AutoMapper;
using MediatR;
using Recipebook.Recipes.Features.Recipes.Queries.GetCategoryRecipeById.Record;
using RecipeBook.Common.Recipes.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.Recipes.Queries.GetRecipeById.Handler
{
	public class GetRecipeByIdQueryHandler : IRequestHandler<GetRecipeByIdQuery, GetRecipeVM>
	{
		public readonly IAsyncRepository<Recipe> _repository;

		public readonly IMapper _mapper;

		public GetRecipeByIdQueryHandler(IAsyncRepository<Recipe> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}




		public async Task<GetRecipeVM> Handle(GetRecipeByIdQuery request, CancellationToken cancellationToken)
		{
			try
			{
				return _mapper.Map<GetRecipeVM>(await _repository.GetByIdAsync(request.Id));
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
