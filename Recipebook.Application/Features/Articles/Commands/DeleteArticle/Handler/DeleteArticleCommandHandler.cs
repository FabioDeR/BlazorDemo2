using MediatR;
using Recipebook.Application.Features.Articles.Commands.DeleteArticle.Record;
using RecipeBook.Application.Exceptions;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipebook.Application.Features.Articles.Commands.DeleteArticle.Handler
{
	public class DeleteArticleCommandHandler : IRequestHandler<DeleteArticleCommand>
	{

		private readonly IAsyncRepository<Article> _articleRepository;

		public DeleteArticleCommandHandler(IAsyncRepository<Article> articleRepository)
		{
			_articleRepository = articleRepository;
		}



		public async Task Handle(DeleteArticleCommand request, CancellationToken cancellationToken)
		{

			try
			{
				var articleDeleted = await _articleRepository.GetByIdAsync(request.Id);

				if (articleDeleted == null)
				{
					throw new NotFoundException(nameof(Article), request.Id);
				}

				await _articleRepository.DeleteAsync(articleDeleted);
			}
			catch (Exception ex)
			{

				throw;
			}
			
		}
	}
}
