using AutoMapper;
using MediatR;
using Recipebook.Application.Features.Articles.Queries.GetListArticle.Handler;
using RecipeBook.Common.Artciles.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.Articles.Queries.GetListArticle.Record
{
    public class GetListArticleQueryHandler : IRequestHandler<GetListArticleQuery, List<GetListArticleVM>>
    {
        public readonly IAsyncRepository<Article> _articleRepository;

        public readonly IMapper _mapper;

        public GetListArticleQueryHandler(IAsyncRepository<Article> articleRepository, IMapper mapper)
        {
            _articleRepository = articleRepository;
            _mapper = mapper;
        }

        public async Task<List<GetListArticleVM>> Handle(GetListArticleQuery request, CancellationToken cancellationToken)
        {
            try
            {
				return _mapper.Map<List<GetListArticleVM>>(await _articleRepository.ListAllAsync());
			}
			catch (Exception ex)
            {

                throw;
            }
        }
    }
}
