using MediatR;

namespace RecipeBook.Application.Features.Products.Commands.DeleteProduct.Record
{
	public record DeleteProductCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
