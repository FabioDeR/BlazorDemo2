using AutoMapper;
using MediatR;
using RecipeBook.Common.CategoryRecipes.ViewModels;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipebook.Application.Features.CategoryRecipes.Queries.GetListCategoryRecipe.Record
{
    public record GetListCategoryRecipeQuery : IRequest<List<GetListCategoryRecipeVM>>;
	
}
