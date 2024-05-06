using RecipeBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Domain.Entities
{
	public class CategoryProduct : AuditableEntity
	{
		[Required(ErrorMessage = "Name is required")]
		[MaxLength(50,ErrorMessage = "Name must not exceed 50 characters")]
		public string Name { get; set; } = string.Empty;

		public virtual ICollection<Article>? Articles { get; set; }

		public virtual ICollection<Product>? Products { get; set; }
	}
}
