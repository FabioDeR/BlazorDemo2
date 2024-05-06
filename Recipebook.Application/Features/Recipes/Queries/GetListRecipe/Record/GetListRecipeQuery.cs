

using MediatR;
using RecipeBook.Common.Recipes.ViewModels;

namespace Recipebook.Application.Features.Recipes.Queries.GetListRecipe.Record
{
    public record GetListRecipeQuery : IRequest<List<GetListRecipeVM>>;
}
