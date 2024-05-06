using AutoMapper;
using MediatR;
using Recipebook.Application.Features.Recipes.Commands.CreateRecipe.Record;
using RecipeBook.Common.Recipes.Dto;
using RecipeBook.Common.Recipes.Responses;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.Recipes.Commands.CreateRecipe.Handler
{
	public class CreateRecipeCommandHandler : IRequestHandler<CreateRecipeCommand, CreateRecipeCommandResponse>
	{
		private readonly IAsyncRepository<Recipe> _RecipeRepository;
		private readonly IMapper _mapper;

		public CreateRecipeCommandHandler(IAsyncRepository<Recipe> RecipeRepository, IMapper mapper)
		{
			_RecipeRepository = RecipeRepository;
			_mapper = mapper;
		}

		public async Task<CreateRecipeCommandResponse> Handle(CreateRecipeCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var createRecipeCommandResponse = new CreateRecipeCommandResponse();
				var Recipe = new Recipe()
				{
					Name = request.Name,
					NumberOfPerson = request.NumberOfPerson,
					Comment = request.Comment,
					ImagePath = request.ImagePath,					
				};
				await _RecipeRepository.AddAsync(Recipe);
				createRecipeCommandResponse.CreateRecipeDto = _mapper.Map<CreateRecipeDto>(Recipe);
				return createRecipeCommandResponse;

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				throw;
			}

		}
	}
}
