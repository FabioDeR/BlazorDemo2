using MediatR;
using RecipeBook.Common.Artciles.ViewModels;
using RecipeBook.Common.Ingredients.ViewModels;

namespace Recipebook.Application.Features.Articles.Queries.GetListArticle.Handler
{
    public record GetListIngredientQuery : IRequest<List<GetListIngredientVM>>
    {

    }
}
