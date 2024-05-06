

using MediatR;
using RecipeBook.Common.CategoryProducts.Responses;

namespace Productbook.Application.Features.CategoryProducts.Commands.CreateCategoryProduct.Record
{
    public record CreateCategoryProductCommand : IRequest<CreateCategoryProductCommandResponse>
	{		
		public string Name { get; set; } = string.Empty;		
	}
}
