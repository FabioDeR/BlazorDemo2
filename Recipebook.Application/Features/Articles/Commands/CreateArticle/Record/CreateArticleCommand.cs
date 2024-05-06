using MediatR;
using RecipeBook.Common.Artciles.Responses;

namespace Recipebook.Application.Features.Articles.Commands.CreateArticle.Record
{
    public record CreateArticleCommand : IRequest<CreateArticleCommandResponse>
	{		
		public Guid ProductId { get; set; }		
		public Guid? CategoryProductId { get; set; }
		public float Quantity { get; set; }	
		public Guid UnitOfMeasurementId { get; set; }
		public DateTime? ExpiratedDate { get; set; }
	}
}
