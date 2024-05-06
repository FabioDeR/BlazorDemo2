using MediatR;
using RecipeBook.Application.Exceptions;
using RecipeBook.Application.Features.TypeOfProducts.Commands.DeleteTypeOfProduct.Record;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace RecipeBook.Application.Features.TypeOfProducts.Commands.DeleteTypeOfProduct.Handler
{
	public class DeleteTypeOfProductCommandHandler : IRequestHandler<DeleteTypeOfProductCommand>
    {
        public readonly IAsyncRepository<TypeOfProduct> _TypeOfProductRepository;

        public DeleteTypeOfProductCommandHandler(IAsyncRepository<TypeOfProduct> TypeOfProductRepository)
        {
			_TypeOfProductRepository = TypeOfProductRepository;
        }

		public async Task Handle(DeleteTypeOfProductCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var TypeOfProductDeleted = await _TypeOfProductRepository.GetByIdAsync(request.Id);
				if (TypeOfProductDeleted == null)
				{
					throw new NotFoundException(nameof(TypeOfProduct), request.Id);
				}
				await _TypeOfProductRepository.DeleteAsync(TypeOfProductDeleted);
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
