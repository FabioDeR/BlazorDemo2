using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Common.CategoryRecipes.Dto
{
    public class CreateCategoryRecipeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
