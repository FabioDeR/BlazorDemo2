

using RecipeBook.Common.Common;
using RecipeBook.Common.Shifts.Dto;

namespace RecipeBook.Common.Shifts.Responses
{
	public class CreateShiftCommandResponse : BaseResponse
    {
        public CreateShiftDto CreateShiftDto { get; set; } = default!;
    }
}
