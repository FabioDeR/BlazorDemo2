using MediatR;
using RecipeBook.Common.TypeOfProducts.ViewModels;


namespace Recipebook.TypeOfProducts.Features.TypeOfProducts.Queries.GetCategoryRecipeById.Record
{
    public record GetTypeOfProductByIdQuery : IRequest<GetTypeOfProductVM>
    {
        public Guid Id { get; set; }
    }
}
