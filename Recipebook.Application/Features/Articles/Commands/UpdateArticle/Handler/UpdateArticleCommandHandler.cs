using AutoMapper;
using MediatR;
using RecipeBook.Application.Exceptions;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace RecipeBook.Application.Features.Articles.Commands.UpdateArticle
{
	public class UpdateArticleCommandHandler : IRequestHandler<UpdateArticleCommand>
    {
        public readonly IAsyncRepository<Article> _articleRepository;
        public readonly IMapper _mapper;

        public UpdateArticleCommandHandler(IAsyncRepository<Article> articleRepository,IMapper mapper)
        {
            _articleRepository = articleRepository;
            _mapper = mapper;
        }

		public async Task Handle(UpdateArticleCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var articleToUpdate = await _articleRepository.GetByIdAsync(request.Id);

				if (articleToUpdate == null)
				{
					throw new NotFoundException(nameof(Article), request.Id);
				}

				_mapper.Map(request, articleToUpdate);
				await _articleRepository.UpdateAsync(articleToUpdate);
			}
			catch (Exception ex)
			{

				throw;
			}		
		
		}
	}
}
