



using AutoMapper;
using MediatR;
using RecipeBook.Application.Exceptions;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;
using RecipeBook.Recipes.Features.UpdateRecipe.Commands.UpdateRecipe.Record;

namespace RecipeBook.Application.Features.Recipes.Commands.UpdateRecipe.Handler
{
	public class UpdateRecipeCommandHandler : IRequestHandler<UpdateRecipeCommand>
    {
        public readonly IAsyncRepository<Recipe> _RecipeRepository;
        public readonly IMapper _mapper;

        public UpdateRecipeCommandHandler(IAsyncRepository<Recipe> RecipeRepository, IMapper mapper)
        {
			_RecipeRepository = RecipeRepository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateRecipeCommand request, CancellationToken cancellationToken)
        {
            try
            {
				var Updated = await _RecipeRepository.GetByIdAsync(request.Id);
				if (Updated == null)
				{
					throw new NotFoundException(nameof(Recipe), request.Id);
				}
				_mapper.Map(request, Updated, typeof(UpdateRecipeCommand), typeof(Recipe));

				await _RecipeRepository.UpdateAsync(Updated);
			}
            catch (Exception ex)
            {

                throw;
            }                

        }

		
	}
}
