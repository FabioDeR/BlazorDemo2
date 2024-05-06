

using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Common.Recipes.Dto
{
    public class CreateRecipeDto
    {		
		public string Name { get; set; } = string.Empty;	
		public string Comment { get; set; } = string.Empty;	
		public int NumberOfPerson { get; set; }
		public string ImagePath { get; set; } = string.Empty;
	}
}
