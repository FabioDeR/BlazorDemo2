using RecipeBook.Common.CategoryRecipes.Dto;
using RecipeBook.Common.Common;

namespace RecipeBook.Common.CategoryRecipes.Responses
{
    public class CreateCategoryRecipeCommandResponse : BaseResponse
    {
        public CreateCategoryRecipeDto CreateCategoryRecipeDto { get; set; } = default!;
    }
}
