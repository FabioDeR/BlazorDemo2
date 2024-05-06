



using AutoMapper;
using MediatR;
using Recipebook.Shifts.Features.Shifts.Queries.GetCategoryRecipeById.Record;
using RecipeBook.Common.Shifts.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.Shifts.Queries.GetShiftById.Handler
{
	public class GetShiftByIdQueryHandler : IRequestHandler<GetShiftByIdQuery, GetShiftVM>
	{
		public readonly IAsyncRepository<Shift> _repository;

		public readonly IMapper _mapper;

		public GetShiftByIdQueryHandler(IAsyncRepository<Shift> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}
		public async Task<GetShiftVM> Handle(GetShiftByIdQuery request, CancellationToken cancellationToken)
		{
			try
			{
				return _mapper.Map<GetShiftVM>(await _repository.GetByIdAsync(request.Id));
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
