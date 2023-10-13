
namespace WebApi.Services.MovieService
{
    public class MovieService : IMovieService
    {
           private static List<Movie> movies = new List<Movie> {
                new Movie 
                {
                    Id = 1,
                    Title = "Breaking Bad",
                    Genre = "Action",
                    Release_Year = 2000
                }
            };
        public List<Movie> CreateMovie(Movie movie)
        {
            movies.Add(movie);
            return movies;
        }

        public List<Movie>? DeleteMovie(int id)
        {
            var movie = movies.Find(x => x.Id == id);

            if (movie is null)
                return null;

           movies.Remove(movie);
            return movies;
        }

        public List<Movie> GetAllMovies()
        {
             return movies;
        }

        public Movie? SearchMovie(int id)
        {
               var movie = movies.Find(x => x.Id == id);
            if (movie is null)
            {
                return null;
            }
            return movie;
        }

        public List<Movie>? UpdateMovie(int id, Movie request)
        {
             var movie = movies.Find(x => x.Id == id);

            if (movie is null)
            {
                return null;
            }

            movie.Title = request.Title;
            movie.Genre = request.Genre;
            movie.Release_Year = request.Release_Year;

            return movies;
            
        }
    }
}