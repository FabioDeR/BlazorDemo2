

using MediatR;
using RecipeBook.Common.Recipes.Responses;
using System.ComponentModel.DataAnnotations;


namespace Recipebook.Application.Features.Recipes.Commands.CreateRecipe.Record
{
	public record CreateRecipeCommand : IRequest<CreateRecipeCommandResponse>
	{
	
		public string Name { get; set; } = string.Empty;	
		public string Comment { get; set; } = string.Empty;		
		public int NumberOfPerson { get; set; }
		public string ImagePath { get; set; } = string.Empty;
	}
}
