

using RecipeBook.Common.Common;
using RecipeBook.Common.UnitOfMeasurements.Dto;

namespace RecipeBook.Common.UnitOfMeasurements.Responses
{
	public class CreateUnitOfMeasurementCommandResponse : BaseResponse
    {
        public CreateUnitOfMeasurementDto CreateUnitOfMeasurementDto { get; set; } = default!;
    }
}
