using MediatR;
using RecipeBook.Common.Recipes.ViewModels;


namespace Recipebook.Recipes.Features.Recipes.Queries.GetCategoryRecipeById.Record
{
    public record GetRecipeByIdQuery : IRequest<GetRecipeVM>
    {
        public Guid Id { get; set; }
    }
}
