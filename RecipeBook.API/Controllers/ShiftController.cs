using MediatR;
using Microsoft.AspNetCore.Mvc;
using Recipebook.Application.Features.Shifts.Commands.CreateShift.Record;
using RecipeBook.Application.Features.Shifts.Commands.DeleteShift.Record;
using RecipeBook.Common.Shifts.Responses;
using RecipeBook.Common.Shifts.ViewModels;
using Recipebook.Shifts.Features.Shifts.Queries.GetCategoryRecipeById.Record;
using RecipeBook.Shifts.Features.UpdateShift.Commands.UpdateShift.Record;
using Shiftbook.Application.Features.Shifts.Queries.GetListShift.Record;

namespace RecipeBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftController(IMediator mediator) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<GetListShiftVM>>> GetAllAsync()
        {
            return Ok(await mediator.Send(new GetListShiftQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetShiftVM>> GetAllAsync(Guid id)
        {
            return Ok(await mediator.Send(new GetShiftByIdQuery { Id = id }));
        }

        [HttpPost()]
        public async Task<ActionResult<CreateShiftCommandResponse>> PostAsync([FromBody] CreateShiftCommand createShiftCommand)
        {
            return Ok(await mediator.Send(createShiftCommand));
        }

        [HttpPut()]
        public async Task<IActionResult> PutAsync([FromBody] UpdateShiftCommand updateShiftCommand)
        {
            await mediator.Send(updateShiftCommand);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await mediator.Send(new DeleteShiftCommand { Id = id });
            return Ok();
        }
    }
}
