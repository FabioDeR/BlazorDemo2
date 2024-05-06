using MediatR;

namespace RecipeBook.Application.Features.UnitOfMeasurements.Commands.DeleteUnitOfMeasurement.Record
{
	public record DeleteUnitOfMeasurementCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
