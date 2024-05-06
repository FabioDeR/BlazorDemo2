using AutoMapper;
using MediatR;
using RecipeBook.Application.Exceptions;
using RecipeBook.Application.Features.Ingredients.Commands.Updateingredient;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace RecipeBook.Application.Features.Ingredients.Commands.UpdateIngredient
{
	public class UpdateIngredientCommandHandler : IRequestHandler<UpdateIngredientCommand>
    {
        public readonly IAsyncRepository<Ingredient> _IngredientRepository;
        public readonly IMapper _mapper;

        public UpdateIngredientCommandHandler(IAsyncRepository<Ingredient> IngredientRepository,IMapper mapper)
        {
            _IngredientRepository = IngredientRepository;
            _mapper = mapper;
        }

		public async Task Handle(UpdateIngredientCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var IngredientToUpdate = await _IngredientRepository.GetByIdAsync(request.Id);

				if (IngredientToUpdate == null)
				{
					throw new NotFoundException(nameof(Ingredient), request.Id);
				}

				_mapper.Map(request, IngredientToUpdate);
				await _IngredientRepository.UpdateAsync(IngredientToUpdate);
			}
			catch (Exception ex)
			{

				throw;
			}		
		
		}
	}
}
