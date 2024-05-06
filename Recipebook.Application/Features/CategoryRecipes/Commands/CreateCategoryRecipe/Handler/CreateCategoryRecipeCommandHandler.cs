using AutoMapper;
using MediatR;
using Recipebook.Application.Features.CategoryRecipes.Commands.CreateCategoryRecipe.Record;
using RecipeBook.Common.CategoryRecipes.Dto;
using RecipeBook.Common.CategoryRecipes.Responses;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.CategoryRecipes.Commands.CreateCategoryRecipe.Handler
{
	public class CreateCategoryRecipeCommandHandler : IRequestHandler<CreateCategoryRecipeCommand, CreateCategoryRecipeCommandResponse>
	{
		private readonly IAsyncRepository<CategoryRecipe> _categoryRecipeRepository;
		private readonly IMapper _mapper;

		public CreateCategoryRecipeCommandHandler(IAsyncRepository<CategoryRecipe> categoryRecipeRepository, IMapper mapper)
		{
			_categoryRecipeRepository = categoryRecipeRepository;
			_mapper = mapper;
		}

		public async Task<CreateCategoryRecipeCommandResponse> Handle(CreateCategoryRecipeCommand request, CancellationToken cancellationToken)
		{





			try
			{
				var createCategoryRecipeCommandResponse = new CreateCategoryRecipeCommandResponse();
				var categoryRecipe = new CategoryRecipe()
				{
					Name = request.Name,
				};
				await _categoryRecipeRepository.AddAsync(categoryRecipe);
				createCategoryRecipeCommandResponse.CreateCategoryRecipeDto = _mapper.Map<CreateCategoryRecipeDto>(categoryRecipe);
				return createCategoryRecipeCommandResponse;

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				throw;
			}


		}
	}
}
