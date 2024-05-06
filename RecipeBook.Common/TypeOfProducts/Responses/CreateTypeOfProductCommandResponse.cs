using RecipeBook.Common.Common;
using RecipeBook.Common.TypeOfProducts.Dto;

namespace RecipeBook.Common.TypeOfProducts.Responses
{
    public class CreateTypeOfProductCommandResponse : BaseResponse
    {
        public CreateTypeOfProductDto CreateTypeOfProductDto { get; set; } = default!;
    }
}
