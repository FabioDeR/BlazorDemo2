using AutoMapper;
using MediatR;
using Recipebook.Application.Features.Products.Commands.CreateProduct.Record;
using RecipeBook.Common.Products.Dto;
using RecipeBook.Common.Products.Responses;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.Products.Commands.CreateProduct.Handler
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductCommandResponse>
    {
        private readonly IAsyncRepository<Product> _ProductRepository;
        private readonly IAsyncRepository<CategoryProduct> _CategoryProductRepository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IAsyncRepository<Product> ProductRepository, IMapper mapper, IAsyncRepository<CategoryProduct> categoryProductRepository)
        {
            _ProductRepository = ProductRepository;
            _mapper = mapper;
            _CategoryProductRepository = categoryProductRepository;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var createProductCommandResponse = new CreateProductCommandResponse();
                var Product = new Product()
                {
                    Name = request.Name,
                    ImagePath = request.ImagePath,
                    TypeOfProductId = request.TypeOfProductId,
                    CategoryProducts = (await _CategoryProductRepository.ListAllAsync()).Where(e => request.CategoryProducts.Any(w => w == e.Id)).ToList(), 
                };
                await _ProductRepository.AddAsync(Product);
                createProductCommandResponse.CreateProductDto = _mapper.Map<CreateProductDto>(Product);
                return createProductCommandResponse;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
    }
}
