

using RecipeBook.Common.Common;
using RecipeBook.Common.HistoricShopping.Dto;

namespace RecipeBook.Common.HistoricShopping.Responses
{
	public class CreateHistoricShoppingCommandResponse : BaseResponse
    {
        public CreateHistoricShoppingDto CreateProductDto { get; set; } = default!;
    }
}
