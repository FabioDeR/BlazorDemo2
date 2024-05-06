using AutoMapper;
using MediatR;
using Recipebook.Application.Features.Shifts.Commands.CreateShift.Record;
using RecipeBook.Common.Shifts.Dto;
using RecipeBook.Common.Shifts.Responses;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.Shifts.Commands.CreateShift.Handler
{
	public class CreateShiftCommandHandler : IRequestHandler<CreateShiftCommand, CreateShiftCommandResponse>
	{
		private readonly IAsyncRepository<Shift> _ShiftRepository;
		private readonly IMapper _mapper;

		public CreateShiftCommandHandler(IAsyncRepository<Shift> ShiftRepository, IMapper mapper)
		{
			_ShiftRepository = ShiftRepository;
			_mapper = mapper;
		}

		public async Task<CreateShiftCommandResponse> Handle(CreateShiftCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var createShiftCommandResponse = new CreateShiftCommandResponse();
				var Shift = new Shift()
				{
					Date = request.Date,
					IsStatementRecipe = request.IsStatementRecipe,
					NumberOfPerson = request.NumberOfPerson,
					RecipeId = request.RecipeId,					
				};
				await _ShiftRepository.AddAsync(Shift);
				createShiftCommandResponse.CreateShiftDto = _mapper.Map<CreateShiftDto>(Shift);
				return createShiftCommandResponse;

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				throw;
			}

		}
	}
}
