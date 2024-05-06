using MediatR;
using RecipeBook.Common.Artciles.ViewModels;

namespace Recipebook.Application.Features.Articles.Queries.GetListArticle.Handler
{
    public record GetListArticleQuery : IRequest<List<GetListArticleVM>>
    {

    }
}
