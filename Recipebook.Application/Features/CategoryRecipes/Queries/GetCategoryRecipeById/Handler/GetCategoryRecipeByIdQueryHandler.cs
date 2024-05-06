using AutoMapper;
using MediatR;
using Recipebook.Application.Features.CategoryRecipes.Queries.GetCategoryRecipeById.Record;
using RecipeBook.Common.CategoryRecipes.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipebook.Application.Features.CategoryRecipes.Queries.GetCategoryRecipeById.Handler
{
    public class GetCategoryRecipeByIdQueryHandler : IRequestHandler<GetCategoryRecipeByIdQuery, GetCategoryRecipeVM>
	{
		public readonly IAsyncRepository<CategoryRecipe> _repository;

		public readonly IMapper _mapper;

		public GetCategoryRecipeByIdQueryHandler(IAsyncRepository<CategoryRecipe> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<GetCategoryRecipeVM> Handle(GetCategoryRecipeByIdQuery request, CancellationToken cancellationToken)
		{
			try
			{
				return _mapper.Map<GetCategoryRecipeVM>(await _repository.GetByIdAsync(request.Id));
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
