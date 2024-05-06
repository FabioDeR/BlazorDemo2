using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Common.CategoryProducts.Dto
{
    public class CreateCategoryProductDto
    {
        public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public Guid TypeOfProductId { get; set; }
		public string ImagePath { get; set; } = string.Empty;
	}
}
