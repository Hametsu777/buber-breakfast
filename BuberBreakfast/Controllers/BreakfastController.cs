using BuberBreakfast.Models;
using BuberBreakfastContracts.Breakfast;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreakfastController : ControllerBase
    {
        [HttpPost("/breakfasts")]
        public IActionResult CreateBreakfast(CreateBreakfastRequest request)
        {
            // Map data from request to language the data speaks
            var breakfast = new Breakfast(
                Guid.NewGuid(),
                request.Name,
                request.Description,
                request.StartDateTime,
                request.EndDateTime,
                DateTime.UtcNow,
                request.Savory,
                request.Sweet);

            // Convert data from api definition and return appropriate response.
            var response = new BreakfastResponse(
                breakfast.Id,
                breakfast.Name,
                breakfast.Description,
                breakfast.StartDateTime,
                breakfast.EndDateTime,
                breakfast.LastModifiedDateTime,
                breakfast.Savory,
                breakfast.Sweet);

            // CreatedAtAction returns 3 things. (1) Recieves the action in which the client can retrieve the resource (GetBreakfast Endpoint).
            // (2) GetBreakfast Endpoint has parameter id, so need to pass the object the has the id property.
            // (3) Lastly the response content.
            return CreatedAtAction(
                actionName: nameof(GetBreakfast),
                routeValues: new { id = breakfast.Id },
                value: response);
        }

        [HttpGet("/breakfasts/{id:guid}")]
        public IActionResult GetBreakfast(Guid id)
        {
            return Ok(id);
        }

        [HttpPut("/breakfasts/{id:guid}")]
        public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
        {
            return Ok(request);
        }

        [HttpDelete("/breakfasts/{id:guid}")]
        public IActionResult DeleteBreakfast(Guid id)
        {
            return Ok(id);
        }
    }
}
