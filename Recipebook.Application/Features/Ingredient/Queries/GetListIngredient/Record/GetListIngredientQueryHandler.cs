using AutoMapper;
using MediatR;
using Recipebook.Application.Features.Articles.Queries.GetListArticle.Handler;
using RecipeBook.Common.Ingredients.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace Recipebook.Application.Features.Ingredients.Queries.GetListIngredient.Record
{
    public class GetListIngredientQueryHandler : IRequestHandler<GetListIngredientQuery, List<GetListIngredientVM>>
    {
        public readonly IAsyncRepository<Ingredient> _IngredientRepository;

        public readonly IMapper _mapper;

        public GetListIngredientQueryHandler(IAsyncRepository<Ingredient> IngredientRepository, IMapper mapper)
        {
            _IngredientRepository = IngredientRepository;
            _mapper = mapper;
        }

        public async Task<List<GetListIngredientVM>> Handle(GetListIngredientQuery request, CancellationToken cancellationToken)
        {
            try
            {
				return _mapper.Map<List<GetListIngredientVM>>(await _IngredientRepository.ListAllAsync());
			}
			catch (Exception ex)
            {

                throw;
            }
        }
    }
}
