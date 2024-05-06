

using RecipeBook.Common.Common;
using RecipeBook.Common.HistoricShoppingHasProduct.Dto;

namespace RecipeBook.Common.HistoricShoppingHasProducts.Responses
{
	public class CreateHistoricShoopingCommandResponse : BaseResponse
    {
        public CreateHistoricShoppingHasProductDto CreateProductDto { get; set; } = default!;
    }
}
