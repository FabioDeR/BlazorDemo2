

using MediatR;
using RecipeBook.Application.Exceptions;
using RecipeBook.Application.Features.UnitOfMeasurements.Commands.DeleteUnitOfMeasurement.Record;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace RecipeBook.Application.Features.UnitOfMeasurements.Commands.DeleteUnitOfMeasurement.Handler
{
	public class DeleteUnitOfMeasurementCommandHandler : IRequestHandler<DeleteUnitOfMeasurementCommand>
    {
        public readonly IAsyncRepository<UnitOfMeasurement> _UnitOfMeasurementRepository;

        public DeleteUnitOfMeasurementCommandHandler(IAsyncRepository<UnitOfMeasurement> UnitOfMeasurementRepository)
        {
			_UnitOfMeasurementRepository = UnitOfMeasurementRepository;
        }

		public async Task Handle(DeleteUnitOfMeasurementCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var UnitOfMeasurementDeleted = await _UnitOfMeasurementRepository.GetByIdAsync(request.Id);
				if (UnitOfMeasurementDeleted == null)
				{
					throw new NotFoundException(nameof(UnitOfMeasurement), request.Id);
				}
				await _UnitOfMeasurementRepository.DeleteAsync(UnitOfMeasurementDeleted);
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
