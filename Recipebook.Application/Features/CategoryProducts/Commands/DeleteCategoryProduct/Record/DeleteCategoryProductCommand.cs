using MediatR;

namespace RecipeBook.Application.Features.CategoryRecipes.Commands.DeleteCategoryProduct.Record
{
	public record DeleteCategoryProductCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
