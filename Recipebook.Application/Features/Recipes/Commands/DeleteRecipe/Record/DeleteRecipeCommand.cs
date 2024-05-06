using MediatR;

namespace RecipeBook.Application.Features.Recipes.Commands.DeleteRecipe.Record
{
	public record DeleteRecipeCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
