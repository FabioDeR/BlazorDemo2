



using AutoMapper;
using MediatR;
using Recipebook.UnitOfMeasurements.Features.UnitOfMeasurements.Queries.GetCategoryRecipeById.Record;
using RecipeBook.Common.UnitOfMeasurements.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.UnitOfMeasurements.Queries.GetUnitOfMeasurementById.Handler
{
	public class GetUnitOfMeasurementByIdQueryHandler : IRequestHandler<GetUnitOfMeasurementByIdQuery, GetUnitOfMeasurementVM>
	{
		public readonly IAsyncRepository<UnitOfMeasurement> _repository;

		public readonly IMapper _mapper;

		public GetUnitOfMeasurementByIdQueryHandler(IAsyncRepository<UnitOfMeasurement> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<GetUnitOfMeasurementVM> Handle(GetUnitOfMeasurementByIdQuery request, CancellationToken cancellationToken)
		{
			try
			{
				return _mapper.Map<GetUnitOfMeasurementVM>(await _repository.GetByIdAsync(request.Id));
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
