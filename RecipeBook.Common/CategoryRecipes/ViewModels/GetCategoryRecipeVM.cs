﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Common.CategoryRecipes.ViewModels
{
    public class GetCategoryRecipeVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
