



using AutoMapper;
using MediatR;
using Shiftbook.Application.Features.Shifts.Queries.GetListShift.Record;
using RecipeBook.Common.Shifts.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Shiftbook.Application.Features.Shifts.Queries.GetListCategoryShift.Handler
{
    public class GetListShiftQueryHandler : IRequestHandler<GetListShiftQuery, List<GetListShiftVM>>
	{
		public readonly IAsyncRepository<Shift> _repository;
		public readonly IMapper _mapper;

		public GetListShiftQueryHandler(IAsyncRepository<Shift> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<List<GetListShiftVM>> Handle(GetListShiftQuery request, CancellationToken cancellationToken)
		{
			try
			{
				return _mapper.Map<List<GetListShiftVM>>(await _repository.ListAllAsync());
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
