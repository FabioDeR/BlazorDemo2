

using MediatR;
using RecipeBook.Common.Shifts.Responses;
using RecipeBook.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Recipebook.Application.Features.Shifts.Commands.CreateShift.Record
{
	public record CreateShiftCommand : IRequest<CreateShiftCommandResponse>
	{
		public DateTime Date { get; set; }	
		public int NumberOfPerson { get; set; }
		public bool IsStatementRecipe { get; set; }	
		public Guid RecipeId { get; set; }
		public virtual Recipe Recipe { get; set; } = default!;
	}
}
