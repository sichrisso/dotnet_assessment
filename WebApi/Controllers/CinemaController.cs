using Microsoft.AspNetCore.Mvc;
using WebApi.Services.CinemaService;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly ICinemaService _cinemaService;
        public CinemaController(ICinemaService cinemaService)
        {
            
            _cinemaService = cinemaService;
        }
      
        [HttpGet]
        public async Task<ActionResult<List<Cinema>>> GetAllCinema()
        {
           return _cinemaService.GetAllCinemas();
        }
    

        [HttpPost]
         public async Task<ActionResult<List<Cinema>>> CreateCinema(Cinema cinema)
        {
         var result = _cinemaService.CreateCinema(cinema);
        
            return Ok(result);   
        }

        [HttpPut("{id}")]
         public async Task<ActionResult<List<Cinema>>> UpdateCinema(int id, Cinema request)
        {
             var result = _cinemaService.UpdateCinema(id, request);
            if (result is null)
            {
                return NotFound("Unable to find");
            }
            return Ok(result);
        }

    }
}