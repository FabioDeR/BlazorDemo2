

using MediatR;
using RecipeBook.Common.Shifts.ViewModels;

namespace Shiftbook.Application.Features.Shifts.Queries.GetListShift.Record
{
    public record GetListShiftQuery : IRequest<List<GetListShiftVM>>;
}
