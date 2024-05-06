using MediatR;
using RecipeBook.Application.Exceptions;
using RecipeBook.Application.Features.Shifts.Commands.DeleteShift.Record;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace RecipeBook.Application.Features.Shifts.Commands.DeleteShift.Handler
{
	public class DeleteShiftCommandHandler : IRequestHandler<DeleteShiftCommand>
    {
        public readonly IAsyncRepository<Shift> _ShiftRepository;

        public DeleteShiftCommandHandler(IAsyncRepository<Shift> ShiftRepository)
        {
			_ShiftRepository = ShiftRepository;
        }

		public async Task Handle(DeleteShiftCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var ShiftDeleted = await _ShiftRepository.GetByIdAsync(request.Id);
				if (ShiftDeleted == null)
				{
					throw new NotFoundException(nameof(Shift), request.Id);
				}
				await _ShiftRepository.DeleteAsync(ShiftDeleted);
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
