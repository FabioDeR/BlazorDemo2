using MediatR;
using RecipeBook.Common.Ingredients.ViewModels;

namespace RecipeBook.Application.Features.Ingredients.Queries.IngredientDetail
{
    public class GetIngredientByIdQuery : IRequest<GetIngredientVM>
    {
        public Guid Id { get; set; }
    }
}
