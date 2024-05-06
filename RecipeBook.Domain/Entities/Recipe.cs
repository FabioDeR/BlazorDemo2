using RecipeBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RecipeBook.Domain.Entities
{
	public class Recipe : AuditableEntity
	{
		[Required(ErrorMessage = "Name is required")]
		[MaxLength(50, ErrorMessage = "Name must not exceed 50 characters")]
		public string Name { get; set; } = string.Empty;

		[MaxLength(255, ErrorMessage = "Name must not exceed 255 characters")]
		public string Comment { get; set; } = string.Empty;

		[Required(ErrorMessage = "NumberOfPerson is required")]
		[Range(0, int.MaxValue,ErrorMessage = "NumberOfPerson must greater than 0")]
		public int NumberOfPerson { get; set; }

		public string ImagePath { get; set; } = string.Empty;

		public virtual ICollection<Ingredient>? Ingredients { get; set; }
		public virtual ICollection<Shift>? Shifts { get; set; }
		public virtual ICollection<CategoryRecipe> CategoryRecipes { get; set; } = default!;
	}
}
