using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Application.Features.CategoryRecipes.Commands.UpdateCategoryRecipe.Record
{
    public class UpdateCategoryRecipeCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
