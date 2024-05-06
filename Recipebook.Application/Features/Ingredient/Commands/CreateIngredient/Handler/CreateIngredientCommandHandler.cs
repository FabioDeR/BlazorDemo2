using AutoMapper;
using MediatR;
using Recipebook.Application.Features.Ingredients.Commands.CreateIngredient.Record;
using RecipeBook.Common.Ingredients.Dto;
using RecipeBook.Common.Ingredients.Responses;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.Ingredients.Commands.CreateIngredient.Handler
{
	public class CreateIngredientCommandHandler : IRequestHandler<CreateIngredientCommand, CreateIngredientCommandResponse>
	{
		private readonly IAsyncRepository<Ingredient> _asyncRepository;
		private readonly IMapper _mapper;


		public CreateIngredientCommandHandler(IAsyncRepository<Ingredient> asyncRepository, IMapper mapper)
		{
			_asyncRepository = asyncRepository;
			_mapper = mapper;
		}

		public async Task<CreateIngredientCommandResponse> Handle(CreateIngredientCommand request, CancellationToken cancellationToken)
		{

			try
			{
				var createIngredientCommandResponse = new CreateIngredientCommandResponse();

				var Ingredient = new Ingredient()
				{
					ProductId = request.ProductId,
					Quantity = request.Quantity,
					RecipeId = request.RecipeId,	
					UnitOfMeasurementId = request.UnitOfMeasurementId,					
				};
				await _asyncRepository.AddAsync(Ingredient);
				createIngredientCommandResponse.CreateIngredientDto = _mapper.Map<CreateIngredientDto>(Ingredient);
				return createIngredientCommandResponse;

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				throw;
			}

		}
	}
}
