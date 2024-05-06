using MediatR;

namespace RecipeBook.Application.Features.CategoryRecipes.Commands.DeleteCategoryRecipe.Record
{
	public record DeleteCategoryRecipeCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
