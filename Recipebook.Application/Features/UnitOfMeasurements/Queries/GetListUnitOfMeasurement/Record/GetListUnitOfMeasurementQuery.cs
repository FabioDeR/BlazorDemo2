

using MediatR;
using RecipeBook.Common.UnitOfMeasurements.ViewModels;

namespace UnitOfMeasurementbook.Application.Features.UnitOfMeasurements.Queries.GetListUnitOfMeasurement.Record
{
    public record GetListUnitOfMeasurementQuery : IRequest<List<GetListUnitOfMeasurementVM>>;
}
