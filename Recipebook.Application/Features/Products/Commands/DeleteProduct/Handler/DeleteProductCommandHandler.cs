using MediatR;
using RecipeBook.Application.Exceptions;
using RecipeBook.Application.Features.Products.Commands.DeleteProduct.Record;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace RecipeBook.Application.Features.Products.Commands.DeleteProduct.Handler
{
	public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        public readonly IAsyncRepository<Product> _productRepository;

        public DeleteProductCommandHandler(IAsyncRepository<Product> productRepository)
        {
			_productRepository = productRepository;
        }

		public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var productDeleted = await _productRepository.GetByIdAsync(request.Id);
				if (productDeleted == null)
				{
					throw new NotFoundException(nameof(Product), request.Id);
				}
				await _productRepository.DeleteAsync(productDeleted);
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
