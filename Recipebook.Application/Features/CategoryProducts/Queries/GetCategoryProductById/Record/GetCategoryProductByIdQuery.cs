using MediatR;
using RecipeBook.Common.CategoryProducts.ViewModels;
using RecipeBook.Common.CategoryRecipes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipebook.Application.Features.CategoryRecipes.Queries.GetCategoryProductById.Record
{
    public record GetCategoryProductByIdQuery : IRequest<GetCategoryProductVM>
    {
        public Guid Id { get; set; }
    }
}
