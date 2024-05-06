using MediatR;
using Microsoft.AspNetCore.Mvc;
using Recipebook.Application.Features.UnitOfMeasurements.Commands.CreateUnitOfMeasurement.Record;
using RecipeBook.Application.Features.UnitOfMeasurements.Commands.DeleteUnitOfMeasurement.Record;
using RecipeBook.Common.UnitOfMeasurements.ViewModels;
using Recipebook.UnitOfMeasurements.Features.UnitOfMeasurements.Queries.GetCategoryRecipeById.Record;
using RecipeBook.UnitOfMeasurements.Features.UpdateUnitOfMeasurement.Commands.UpdateUnitOfMeasurement.Record;
using UnitOfMeasurementbook.Application.Features.UnitOfMeasurements.Queries.GetListUnitOfMeasurement.Record;

namespace RecipeBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitOfMeasurementController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<GetListUnitOfMeasurementVM>>> GetAllAsync()
        {
            return Ok(await mediator.Send(new GetListUnitOfMeasurementQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetUnitOfMeasurementVM>> GetAllAsync(Guid id)
        {
            return Ok(await mediator.Send(new GetUnitOfMeasurementByIdQuery { Id = id }));
        }

        [HttpPost()]
        public async Task<ActionResult<CreateUnitOfMeasurementCommand>> PostAsync([FromBody] CreateUnitOfMeasurementCommand createUnitOfMeasurementCommand)
        {
            return Ok(await mediator.Send(createUnitOfMeasurementCommand));
        }

        [HttpPut()]
        public async Task<IActionResult> PutAsync([FromBody] UpdateUnitOfMeasurementCommand updateUnitOfMeasurementCommand)
        {
            await mediator.Send(updateUnitOfMeasurementCommand);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await mediator.Send(new DeleteUnitOfMeasurementCommand { Id = id });
            return Ok();
        }
    }
}
