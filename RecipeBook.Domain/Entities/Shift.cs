using RecipeBook.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Domain.Entities
{
	public class Shift : AuditableEntity
	{
		[Required(ErrorMessage = "Date is required")]

		public DateTime Date { get; set; }

		[Required(ErrorMessage = "NumberOfPerson is required")]
		[Range(0, int.MaxValue, ErrorMessage = "NumberOfPerson must greater than 0")]
		public int NumberOfPerson { get; set; }

		public bool IsStatementRecipe { get; set; }

		[Required(ErrorMessage = "Please select a recipe")]
		[ForeignKey("RecipeId")]
		public Guid RecipeId { get; set; }
		public virtual Recipe Recipe { get; set; } = default!;

		public Shift()
		{
			IsStatementRecipe = false;
		}
	}
}