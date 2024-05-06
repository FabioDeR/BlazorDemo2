using AutoMapper;
using MediatR;
using Recipebook.Application.Features.Articles.Commands.CreateArticle.Record;
using RecipeBook.Common.Artciles.Dto;
using RecipeBook.Common.Artciles.Responses;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.Articles.Commands.CreateArticle.Handler
{
	public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand, CreateArticleCommandResponse>
	{
		private readonly IAsyncRepository<Article> _asyncRepository;
		private readonly IMapper _mapper;


		public CreateArticleCommandHandler(IAsyncRepository<Article> asyncRepository, IMapper mapper)
		{
			_asyncRepository = asyncRepository;
			_mapper = mapper;
		}

		public async Task<CreateArticleCommandResponse> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
		{

			try
			{
				var createArticleCommandResponse = new CreateArticleCommandResponse();

				var article = new Article()
				{
					CategoryProductId = request.CategoryProductId,
					UnitOfMeasurementId = request.UnitOfMeasurementId,
					ProductId = request.ProductId,
					ExpiratedDate = request.ExpiratedDate,
					Quantity = request.Quantity,
				};
				await _asyncRepository.AddAsync(article);
				createArticleCommandResponse.ArticlesDto = _mapper.Map<CreateArtcilesDto>(article);
				return createArticleCommandResponse;

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				throw;
			}

		}
	}
}
