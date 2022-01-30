using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace algo_exercise.Controllers
{
    public class AlgoController : Controller
    {
        private readonly ILogger<AlgoController> _logger;

        public AlgoController(ILogger<AlgoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
