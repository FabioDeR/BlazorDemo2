

using RecipeBook.Common.Common;
using RecipeBook.Common.Products.Dto;

namespace RecipeBook.Common.Products.Responses
{
	public class CreateProductCommandResponse : BaseResponse
    {
        public CreateProductDto CreateProductDto { get; set; } = default!;
    }
}
