using MediatR;
using RecipeBook.Common.CategoryRecipes.ViewModels;

namespace Recipebook.Application.Features.CategoryRecipes.Queries.GetCategoryRecipeById.Record
{
    public record GetCategoryRecipeByIdQuery : IRequest<GetCategoryRecipeVM>
    {
        public Guid Id { get; set; }
    }
}
