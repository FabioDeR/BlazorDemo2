

using MediatR;
using RecipeBook.Common.UnitOfMeasurements.Responses;
using RecipeBook.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Recipebook.Application.Features.UnitOfMeasurements.Commands.CreateUnitOfMeasurement.Record
{
	public record CreateUnitOfMeasurementCommand : IRequest<CreateUnitOfMeasurementCommandResponse>
	{		
		public string Name { get; set; } = string.Empty;		
		public Guid TypeOfProductId { get; set; }		
		public float AverageQuantity { get; set; }	
		public string Abbreviation { get; set; } = string.Empty;		
	}
}
