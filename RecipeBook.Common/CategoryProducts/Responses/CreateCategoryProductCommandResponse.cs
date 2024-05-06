

using RecipeBook.Common.CategoryProducts.Dto;
using RecipeBook.Common.Common;

namespace RecipeBook.Common.CategoryProducts.Responses
{
	public class CreateCategoryProductCommandResponse : BaseResponse
    {
        public CreateCategoryProductDto CreateCategoryProductDto { get; set; } = default!;
    }
}
