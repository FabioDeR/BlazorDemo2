using MediatR;

namespace RecipeBook.Application.Features.Shifts.Commands.DeleteShift.Record
{
	public record DeleteShiftCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
