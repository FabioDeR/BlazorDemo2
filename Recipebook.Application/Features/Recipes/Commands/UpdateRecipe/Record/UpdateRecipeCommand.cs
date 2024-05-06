using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Recipes.Features.UpdateRecipe.Commands.UpdateRecipe.Record
{
    public class UpdateRecipeCommand : IRequest
    {
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Comment { get; set; } = string.Empty;
		public int NumberOfPerson { get; set; }
		public string ImagePath { get; set; } = string.Empty;
	}
}
