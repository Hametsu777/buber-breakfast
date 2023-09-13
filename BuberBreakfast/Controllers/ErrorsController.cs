using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers
{
    //[Route("/error")]
    //[Route("/api/[controller]")]
    //[ApiController]
    public class ErrorsController : ControllerBase
    {
        [Route("/error")]
        public IActionResult Error()
        {
            // Problem method comes from controller base.
            return Problem();
        }
    }
}
