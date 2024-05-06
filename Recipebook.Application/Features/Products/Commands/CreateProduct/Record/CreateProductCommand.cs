

using MediatR;
using RecipeBook.Common.Products.Responses;


namespace Recipebook.Application.Features.Products.Commands.CreateProduct.Record
{
	public record CreateProductCommand : IRequest<CreateProductCommandResponse>
	{		
		public string Name { get; set; } = string.Empty;		
		public Guid TypeOfProductId { get; set; }
		public string ImagePath { get; set; } = string.Empty;
		public List<Guid> CategoryProducts { get; set; } = default!;
	}
}
