

using MediatR;
using RecipeBook.Common.TypeOfProducts.Responses;


namespace Recipebook.Application.Features.TypeOfProducts.Commands.CreateTypeOfProduct.Record
{
	public record CreateTypeOfProductCommand : IRequest<CreateTypeOfProductCommandResponse>
	{		
		public string Name { get; set; } = string.Empty;
	}
}
