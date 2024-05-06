using MediatR;
using RecipeBook.Common.Products.ViewModels;


namespace Recipebook.Products.Features.Products.Queries.GetCategoryRecipeById.Record
{
    public record GetProductByIdQuery : IRequest<GetProductVM>
    {
        public Guid Id { get; set; }
    }
}
