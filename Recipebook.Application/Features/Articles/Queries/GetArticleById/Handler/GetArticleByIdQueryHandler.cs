using AutoMapper;
using MediatR;
using RecipeBook.Common.Artciles.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace RecipeBook.Application.Features.Articles.Queries.ArticleDetail
{
    internal class GetArticleByIdQueryHandler : IRequestHandler<GetArticleByIdQuery, GetArticleVM>
    {
		public readonly IAsyncRepository<Article> _articleRepository;

		public readonly IMapper _mapper;

		public GetArticleByIdQueryHandler(IAsyncRepository<Article> articleRepository, IMapper mapper)
		{
			_articleRepository = articleRepository;
			_mapper = mapper;
		}		

		public async Task<GetArticleVM> Handle(GetArticleByIdQuery request, CancellationToken cancellationToken)
		{
			var articleWithInclude = await _articleRepository.GetByIdAsync(request.Id);

			return _mapper.Map<GetArticleVM>(articleWithInclude);
		}
	}
}
