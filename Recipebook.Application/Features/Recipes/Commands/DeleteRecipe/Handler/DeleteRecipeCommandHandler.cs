using MediatR;
using RecipeBook.Application.Exceptions;
using RecipeBook.Application.Features.Recipes.Commands.DeleteRecipe.Record;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace RecipeBook.Application.Features.Recipes.Commands.DeleteRecipe.Handler
{
	public class DeleteRecipeCommandHandler : IRequestHandler<DeleteRecipeCommand>
    {
        public readonly IAsyncRepository<Recipe> _RecipeRepository;

        public DeleteRecipeCommandHandler(IAsyncRepository<Recipe> RecipeRepository)
        {
			_RecipeRepository = RecipeRepository;
        }

		public async Task Handle(DeleteRecipeCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var RecipeDeleted = await _RecipeRepository.GetByIdAsync(request.Id);
				if (RecipeDeleted == null)
				{
					throw new NotFoundException(nameof(Recipe), request.Id);
				}
				await _RecipeRepository.DeleteAsync(RecipeDeleted);
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
