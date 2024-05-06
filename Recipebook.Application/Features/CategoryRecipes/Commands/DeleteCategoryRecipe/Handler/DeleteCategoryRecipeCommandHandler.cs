

using MediatR;
using RecipeBook.Application.Exceptions;
using RecipeBook.Application.Features.CategoryRecipes.Commands.DeleteCategoryRecipe.Record;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace RecipeBook.Application.Features.Categories.Commands.DeleteCategory
{
	public class DeleteCategoryRecipeCommandHandler : IRequestHandler<DeleteCategoryRecipeCommand>
    {
        public readonly IAsyncRepository<CategoryRecipe> _categoryRepository;

        public DeleteCategoryRecipeCommandHandler(IAsyncRepository<CategoryRecipe> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

		public async Task Handle(DeleteCategoryRecipeCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var categoryDeleted = await _categoryRepository.GetByIdAsync(request.Id);
				if (categoryDeleted == null)
				{
					throw new NotFoundException(nameof(CategoryRecipe), request.Id);
				}
				await _categoryRepository.DeleteAsync(categoryDeleted);
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
