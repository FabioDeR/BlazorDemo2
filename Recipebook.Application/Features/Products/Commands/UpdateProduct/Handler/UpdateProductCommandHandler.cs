



using AutoMapper;
using MediatR;
using RecipeBook.Application.Exceptions;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;
using RecipeBook.Products.Features.UpdateProduct.Commands.UpdateProduct.Record;

namespace RecipeBook.Application.Features.Products.Commands.UpdateProduct.Handler
{
	public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        public readonly IAsyncRepository<Product> _productRepository;
        public readonly IMapper _mapper;

        public UpdateProductCommandHandler(IAsyncRepository<Product> productRepository, IMapper mapper)
        {
			_productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
				var Updated = await _productRepository.GetByIdAsync(request.Id);
				if (Updated == null)
				{
					throw new NotFoundException(nameof(Product), request.Id);
				}
				_mapper.Map(request, Updated, typeof(UpdateProductCommand), typeof(Product));

				await _productRepository.UpdateAsync(Updated);
			}
            catch (Exception ex)
            {

                throw;
            }                

        }

		
	}
}
