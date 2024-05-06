using AutoMapper;
using MediatR;
using Recipebook.Application.Features.CategoryRecipes.Queries.GetListCategoryRecipe.Record;
using RecipeBook.Common.CategoryRecipes.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipebook.Application.Features.CategoryRecipes.Queries.GetListCategoryRecipe.Handler
{
    public class GetListCategoryRecipeQueryHandler : IRequestHandler<GetListCategoryRecipeQuery, List<GetListCategoryRecipeVM>>
	{
		public readonly IAsyncRepository<CategoryRecipe> _repository;

		public readonly IMapper _mapper;

		public GetListCategoryRecipeQueryHandler(IAsyncRepository<CategoryRecipe> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<List<GetListCategoryRecipeVM>> Handle(GetListCategoryRecipeQuery request, CancellationToken cancellationToken)
		{
			try
			{
				return _mapper.Map<List<GetListCategoryRecipeVM>>(await _repository.ListAllAsync());
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
