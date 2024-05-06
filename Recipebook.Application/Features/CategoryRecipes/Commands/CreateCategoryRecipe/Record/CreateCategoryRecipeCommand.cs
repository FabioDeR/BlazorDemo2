using MediatR;
using RecipeBook.Common.CategoryRecipes.Responses;
using RecipeBook.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Recipebook.Application.Features.CategoryRecipes.Commands.CreateCategoryRecipe.Record
{
    public record CreateCategoryRecipeCommand : IRequest<CreateCategoryRecipeCommandResponse>
	{		
		public string Name { get; set; } = string.Empty;		
	}
}
