using AutoMapper;
using MediatR;
using RecipeBook.Application.Exceptions;
using RecipeBook.Application.Features.CategoryRecipes.Commands.UpdateCategoryRecipe.Record;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace RecipeBook.Application.Features.CategoryRecipes.Commands.UpdateCategoryRecipe.Handler
{
	public class UpdateCategoryRecipeCommandHandler : IRequestHandler<UpdateCategoryRecipeCommand>
    {
        public readonly IAsyncRepository<CategoryRecipe> _categoryRepository;
        public readonly IMapper _mapper;

        public UpdateCategoryRecipeCommandHandler(IAsyncRepository<CategoryRecipe> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateCategoryRecipeCommand request, CancellationToken cancellationToken)
        {
            try
            {
				var categoryUpdated = await _categoryRepository.GetByIdAsync(request.Id);
				if (categoryUpdated == null)
				{
					throw new NotFoundException(nameof(CategoryRecipe), request.Id);
				}
				_mapper.Map(request, categoryUpdated, typeof(UpdateCategoryRecipeCommand), typeof(CategoryRecipe));

				await _categoryRepository.UpdateAsync(categoryUpdated);
			}
            catch (Exception ex)
            {

                throw;
            }                

        }

		
	}
}
