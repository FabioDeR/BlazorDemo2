



using AutoMapper;
using MediatR;
using UnitOfMeasurementbook.Application.Features.UnitOfMeasurements.Queries.GetListUnitOfMeasurement.Record;
using RecipeBook.Common.UnitOfMeasurements.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace UnitOfMeasurementbook.Application.Features.UnitOfMeasurements.Queries.GetListCategoryUnitOfMeasurement.Handler
{
    public class GetListUnitOfMeasurementQueryHandler : IRequestHandler<GetListUnitOfMeasurementQuery, List<GetListUnitOfMeasurementVM>>
	{
		public readonly IAsyncRepository<UnitOfMeasurement> _repository;
		public readonly IMapper _mapper;

		public GetListUnitOfMeasurementQueryHandler(IAsyncRepository<UnitOfMeasurement> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<List<GetListUnitOfMeasurementVM>> Handle(GetListUnitOfMeasurementQuery request, CancellationToken cancellationToken)
		{
			try
			{
				return _mapper.Map<List<GetListUnitOfMeasurementVM>>(await _repository.ListAllAsync());
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
