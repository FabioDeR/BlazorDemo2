

using MediatR;
using RecipeBook.Common.TypeOfProducts.ViewModels;

namespace TypeOfProductbook.Application.Features.TypeOfProducts.Queries.GetListTypeOfProduct.Record
{
    public record GetListTypeOfProductQuery : IRequest<List<GetListTypeOfProductVM>>;
}
