

using MediatR;
using RecipeBook.Common.CategoryProducts.ViewModels;

namespace Productbook.Application.Features.CategoryProducts.Queries.GetListCategoryProduct.Record
{
    public record GetListCategoryProductQuery : IRequest<List<GetListCategoryProductVM>>;
}
