using RecipeBook.Common.Artciles.Dto;
using RecipeBook.Common.Common;

namespace RecipeBook.Common.Artciles.Responses
{
    public class CreateArticleCommandResponse : BaseResponse
    {
        public CreateArtcilesDto ArticlesDto { get; set; } = default!;
    }
}
