

using MediatR;
using RecipeBook.Application.Exceptions;
using RecipeBook.Application.Features.CategoryRecipes.Commands.DeleteCategoryProduct.Record;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace RecipeBook.Application.Features.CategoryProducts.Commands.DeleteCategoryProduct.Handler
{
	public class DeleteCategoryProductCommandHandler : IRequestHandler<DeleteCategoryProductCommand>
    {
        public readonly IAsyncRepository<CategoryProduct> _categoryRepository;

        public DeleteCategoryProductCommandHandler(IAsyncRepository<CategoryProduct> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

		public async Task Handle(DeleteCategoryProductCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var categoryDeleted = await _categoryRepository.GetByIdAsync(request.Id);
				if (categoryDeleted == null)
				{
					throw new NotFoundException(nameof(CategoryProduct), request.Id);
				}
				await _categoryRepository.DeleteAsync(categoryDeleted);
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
