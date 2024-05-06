

using RecipeBook.Common.Common;
using RecipeBook.Common.Recipes.Dto;

namespace RecipeBook.Common.Recipes.Responses
{
	public class CreateRecipeCommandResponse : BaseResponse
    {
        public CreateRecipeDto CreateRecipeDto { get; set; } = default!;
    }
}
