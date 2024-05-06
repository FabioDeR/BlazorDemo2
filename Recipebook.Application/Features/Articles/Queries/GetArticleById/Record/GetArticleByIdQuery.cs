using MediatR;
using RecipeBook.Common.Artciles.ViewModels;

namespace RecipeBook.Application.Features.Articles.Queries.ArticleDetail
{
    public class GetArticleByIdQuery : IRequest<GetArticleVM>
    {
        public Guid Id { get; set; }
    }
}
