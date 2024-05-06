using AutoMapper;
using MediatR;
using Recipebook.Application.Features.UnitOfMeasurements.Commands.CreateUnitOfMeasurement.Record;
using RecipeBook.Common.UnitOfMeasurements.Dto;
using RecipeBook.Common.UnitOfMeasurements.Responses;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.UnitOfMeasurements.Commands.CreateUnitOfMeasurement.Handler
{
	public class CreateUnitOfMeasurementCommandHandler : IRequestHandler<CreateUnitOfMeasurementCommand, CreateUnitOfMeasurementCommandResponse>
	{
		private readonly IAsyncRepository<UnitOfMeasurement> _UnitOfMeasurementRepository;
		private readonly IMapper _mapper;

		public CreateUnitOfMeasurementCommandHandler(IAsyncRepository<UnitOfMeasurement> UnitOfMeasurementRepository, IMapper mapper)
		{
			_UnitOfMeasurementRepository = UnitOfMeasurementRepository;
			_mapper = mapper;
		}

		public async Task<CreateUnitOfMeasurementCommandResponse> Handle(CreateUnitOfMeasurementCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var createUnitOfMeasurementCommandResponse = new CreateUnitOfMeasurementCommandResponse();
				var UnitOfMeasurement = new UnitOfMeasurement()
				{
					Name = request.Name,
					Abbreviation = request.Abbreviation,
					AverageQuantity = request.AverageQuantity,
					TypeOfProductId = request.TypeOfProductId,					
				};
				await _UnitOfMeasurementRepository.AddAsync(UnitOfMeasurement);
				createUnitOfMeasurementCommandResponse.CreateUnitOfMeasurementDto = _mapper.Map<CreateUnitOfMeasurementDto>(UnitOfMeasurement);
				return createUnitOfMeasurementCommandResponse;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				throw;
			}


		}
	}
}
