



using AutoMapper;
using MediatR;
using RecipeBook.Application.Exceptions;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;
using RecipeBook.TypeOfProducts.Features.UpdateTypeOfProduct.Commands.UpdateTypeOfProduct.Record;

namespace RecipeBook.Application.Features.TypeOfProducts.Commands.UpdateTypeOfProduct.Handler
{
	public class UpdateTypeOfProductCommandHandler : IRequestHandler<UpdateTypeOfProductCommand>
    {
        public readonly IAsyncRepository<TypeOfProduct> _TypeOfProductRepository;
        public readonly IMapper _mapper;

        public UpdateTypeOfProductCommandHandler(IAsyncRepository<TypeOfProduct> TypeOfProductRepository, IMapper mapper)
        {
			_TypeOfProductRepository = TypeOfProductRepository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateTypeOfProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
				var Updated = await _TypeOfProductRepository.GetByIdAsync(request.Id);
				if (Updated == null)
				{
					throw new NotFoundException(nameof(TypeOfProduct), request.Id);
				}
				_mapper.Map(request, Updated, typeof(UpdateTypeOfProductCommand), typeof(TypeOfProduct));

				await _TypeOfProductRepository.UpdateAsync(Updated);
			}
            catch (Exception ex)
            {

                throw;
            }                

        }

		
	}
}
