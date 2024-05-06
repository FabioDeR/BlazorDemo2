

using AutoMapper;
using MediatR;
using RecipeBook.Application.Exceptions;
using RecipeBook.Application.Features.CategoryProducts.Commands.UpdateCategoryProduct.Record;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace RecipeBook.Application.Features.CategoryProducts.Commands.UpdateCategoryProduct.Handler
{
	public class UpdateCategoryProductCommandHandler : IRequestHandler<UpdateCategoryProductCommand>
    {
        public readonly IAsyncRepository<CategoryProduct> _categoryRepository;
        public readonly IMapper _mapper;

        public UpdateCategoryProductCommandHandler(IAsyncRepository<CategoryProduct> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateCategoryProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
				var categoryUpdated = await _categoryRepository.GetByIdAsync(request.Id);
				if (categoryUpdated == null)
				{
					throw new NotFoundException(nameof(CategoryRecipe), request.Id);
				}
				_mapper.Map(request, categoryUpdated, typeof(UpdateCategoryProductCommand), typeof(CategoryProduct));

				await _categoryRepository.UpdateAsync(categoryUpdated);
			}
            catch (Exception ex)
            {

                throw;
            }                

        }

		
	}
}
