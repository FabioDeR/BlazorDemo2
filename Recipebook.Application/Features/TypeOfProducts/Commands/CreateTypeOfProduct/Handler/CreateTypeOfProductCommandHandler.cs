using AutoMapper;
using MediatR;
using Recipebook.Application.Features.TypeOfProducts.Commands.CreateTypeOfProduct.Record;
using RecipeBook.Common.TypeOfProducts.Dto;
using RecipeBook.Common.TypeOfProducts.Responses;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.TypeOfProducts.Commands.CreateTypeOfProduct.Handler
{
	public class CreateTypeOfProductCommandHandler : IRequestHandler<CreateTypeOfProductCommand, CreateTypeOfProductCommandResponse>
	{
		private readonly IAsyncRepository<TypeOfProduct> _TypeOfProductRepository;
		private readonly IMapper _mapper;

		public CreateTypeOfProductCommandHandler(IAsyncRepository<TypeOfProduct> TypeOfProductRepository, IMapper mapper)
		{
			_TypeOfProductRepository = TypeOfProductRepository;
			_mapper = mapper;
		}

		public async Task<CreateTypeOfProductCommandResponse> Handle(CreateTypeOfProductCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var createTypeOfProductCommandResponse = new CreateTypeOfProductCommandResponse();

				var TypeOfProduct = new TypeOfProduct()
				{
					Name = request.Name,
				};
				await _TypeOfProductRepository.AddAsync(TypeOfProduct);
				createTypeOfProductCommandResponse.CreateTypeOfProductDto = _mapper.Map<CreateTypeOfProductDto>(TypeOfProduct);
				return createTypeOfProductCommandResponse;

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				throw;
			}
		}
	}
}
