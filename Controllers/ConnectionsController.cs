using Microsoft.AspNetCore.Mvc;
using ConnectionsApi.Data;
using ConnectionsApi.Models;

namespace ConnectionsApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class ConnectionsController : ControllerBase
    {
        // GET api/daily
        [HttpGet("daily")]
        public IActionResult GetDaily()
        {
            var puzzle = PuzzleRepository.GetTodaysPuzzle();
            return Ok(puzzle);
        }

        // GET api/daily/{date}
        [HttpGet("daily/{date}")]
        public IActionResult GetDailyByDate(string date)
        {
            var puzzle = PuzzleRepository.GetPuzzleByDate(date);
            return Ok(puzzle);
        }

        // GET api/random
        [HttpGet("random")]
        public ActionResult<ConnectionsPuzzle> GetRandom()
        {
            var puzzle = PuzzleRepository.GetRandomPuzzle();
            return Ok(puzzle);
        }

        // GET api/user/{user}
        [HttpGet("user/{user}")]
        public IActionResult GetByUser(string user)
        {
            // Not implemented, fail gracefully
            return NotFound(new { message = $"Not implemented. No result available for /api/user/{user}." });
        }
    }
}
