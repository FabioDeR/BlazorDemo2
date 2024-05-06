

using RecipeBook.Common.Common;
using RecipeBook.Common.Ingredients.Dto;

namespace RecipeBook.Common.Ingredients.Responses
{
	public class CreateIngredientCommandResponse : BaseResponse
    {
        public CreateIngredientDto CreateIngredientDto { get; set; } = default!;
    }
}
