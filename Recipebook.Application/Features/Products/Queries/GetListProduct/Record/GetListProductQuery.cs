

using MediatR;
using RecipeBook.Common.Products.ViewModels;

namespace Productbook.Application.Features.Products.Queries.GetListProduct.Record
{
    public record GetListProductQuery : IRequest<List<GetListProductVM>>;
}
