



using AutoMapper;
using MediatR;
using RecipeBook.Application.Exceptions;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;
using RecipeBook.Shifts.Features.UpdateShift.Commands.UpdateShift.Record;

namespace RecipeBook.Application.Features.Shifts.Commands.UpdateShift.Handler
{
	public class UpdateShiftCommandHandler : IRequestHandler<UpdateShiftCommand>
    {
        public readonly IAsyncRepository<Shift> _ShiftRepository;
        public readonly IMapper _mapper;

        public UpdateShiftCommandHandler(IAsyncRepository<Shift> ShiftRepository, IMapper mapper)
        {
			_ShiftRepository = ShiftRepository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateShiftCommand request, CancellationToken cancellationToken)
        {
            try
            {
				var Updated = await _ShiftRepository.GetByIdAsync(request.Id);
				if (Updated == null)
				{
					throw new NotFoundException(nameof(Shift), request.Id);
				}
				_mapper.Map(request, Updated, typeof(UpdateShiftCommand), typeof(Shift));

				await _ShiftRepository.UpdateAsync(Updated);
			}
            catch (Exception ex)
            {

                throw;
            }                

        }

		
	}
}
