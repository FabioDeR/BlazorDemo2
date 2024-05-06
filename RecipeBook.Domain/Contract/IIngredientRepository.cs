using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;

namespace RecipeBook.Application.Contracts.Persistence
{
	public interface IIngredientRepository : IAsyncRepository<Ingredient>
    {
        
    }
}
