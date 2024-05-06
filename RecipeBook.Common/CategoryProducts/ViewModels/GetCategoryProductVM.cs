using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Common.CategoryProducts.ViewModels
{
    public class GetCategoryProductVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
