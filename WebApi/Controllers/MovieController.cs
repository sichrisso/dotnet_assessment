using Microsoft.AspNetCore.Mvc;
using WebApi.Services.MovieService;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            
            _movieService = movieService;
        }
      
        [HttpGet]
        public async Task<ActionResult<List<Movie>>> GetAllMovies()
        {
           return _movieService.GetAllMovies();
        }

        [HttpGet("{id}")]
         public async Task<ActionResult<Movie>> SearchMovie(int id)
        {
             var result = _movieService.SearchMovie(id);
            if (result is null)
            {
                return NotFound("Unable to find");
            }
            return Ok(result);
         
        }

        [HttpPost]
         public async Task<ActionResult<List<Movie>>> CreateMovie(Movie movie)
        {
         var result = _movieService.CreateMovie(movie);
        
            return Ok(result);   
        }

        [HttpPut("{id}")]
         public async Task<ActionResult<List<Movie>>> UpdateMovie(int id, Movie request)
        {
             var result = _movieService.UpdateMovie(id, request);
            if (result is null)
            {
                return NotFound("Unable to find");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
         public async Task<ActionResult<List<Movie>>> DeleteMovie(int id)
        {
            var result = _movieService.DeleteMovie(id);
            if (result is null)
            {
                return NotFound("Unable to find");
            }
            return Ok(result);
        }



    }
}