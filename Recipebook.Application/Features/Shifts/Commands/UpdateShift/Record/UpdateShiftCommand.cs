using MediatR;
using RecipeBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Shifts.Features.UpdateShift.Commands.UpdateShift.Record
{
    public class UpdateShiftCommand : IRequest
    {
		public Guid Id { get; set; }
		public DateTime Date { get; set; }
		public int NumberOfPerson { get; set; }
		public bool IsStatementRecipe { get; set; }
		public Guid RecipeId { get; set; }
		public virtual Recipe Recipe { get; set; } = default!;
	}
}
