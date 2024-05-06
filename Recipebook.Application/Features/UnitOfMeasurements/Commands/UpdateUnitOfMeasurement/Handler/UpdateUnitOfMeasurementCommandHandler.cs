



using AutoMapper;
using MediatR;
using RecipeBook.Application.Exceptions;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;
using RecipeBook.UnitOfMeasurements.Features.UpdateUnitOfMeasurement.Commands.UpdateUnitOfMeasurement.Record;

namespace RecipeBook.Application.Features.UnitOfMeasurements.Commands.UpdateUnitOfMeasurement.Handler
{
	public class UpdateUnitOfMeasurementCommandHandler : IRequestHandler<UpdateUnitOfMeasurementCommand>
    {
        public readonly IAsyncRepository<UnitOfMeasurement> _UnitOfMeasurementRepository;
        public readonly IMapper _mapper;

        public UpdateUnitOfMeasurementCommandHandler(IAsyncRepository<UnitOfMeasurement> UnitOfMeasurementRepository, IMapper mapper)
        {
			_UnitOfMeasurementRepository = UnitOfMeasurementRepository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateUnitOfMeasurementCommand request, CancellationToken cancellationToken)
        {
            try
            {
				var Updated = await _UnitOfMeasurementRepository.GetByIdAsync(request.Id);
				if (Updated == null)
				{
					throw new NotFoundException(nameof(UnitOfMeasurement), request.Id);
				}
				_mapper.Map(request, Updated, typeof(UpdateUnitOfMeasurementCommand), typeof(UnitOfMeasurement));

				await _UnitOfMeasurementRepository.UpdateAsync(Updated);
			}
            catch (Exception ex)
            {

                throw;
            }                

        }

		
	}
}
