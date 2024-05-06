using AutoMapper;
using MediatR;
using RecipeBook.Common.Ingredients.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace RecipeBook.Application.Features.Ingredients.Queries.IngredientDetail
{
    internal class GetIngredientByIdQueryHandler : IRequestHandler<GetIngredientByIdQuery, GetIngredientVM>
    {
		public readonly IAsyncRepository<Ingredient> _IngredientRepository;

		public readonly IMapper _mapper;

		public GetIngredientByIdQueryHandler(IAsyncRepository<Ingredient> IngredientRepository, IMapper mapper)
		{
			_IngredientRepository = IngredientRepository;
			_mapper = mapper;
		}		

		public async Task<GetIngredientVM> Handle(GetIngredientByIdQuery request, CancellationToken cancellationToken)
		{
			var IngredientWithInclude = await _IngredientRepository.GetByIdAsync(request.Id);

			return _mapper.Map<GetIngredientVM>(IngredientWithInclude);
		}
	}
}
