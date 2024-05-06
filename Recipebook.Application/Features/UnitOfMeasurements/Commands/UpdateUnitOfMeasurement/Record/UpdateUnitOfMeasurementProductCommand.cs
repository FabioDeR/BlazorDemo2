using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.UnitOfMeasurements.Features.UpdateUnitOfMeasurement.Commands.UpdateUnitOfMeasurement.Record
{
    public class UpdateUnitOfMeasurementCommand : IRequest
    {
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
        public Guid TypeOfProductId { get; set; }
        public float AverageQuantity { get; set; }
        public string Abbreviation { get; set; } = string.Empty;
    }
}
