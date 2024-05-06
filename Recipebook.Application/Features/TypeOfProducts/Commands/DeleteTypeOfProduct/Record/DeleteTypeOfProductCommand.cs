using MediatR;

namespace RecipeBook.Application.Features.TypeOfProducts.Commands.DeleteTypeOfProduct.Record
{
	public record DeleteTypeOfProductCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
