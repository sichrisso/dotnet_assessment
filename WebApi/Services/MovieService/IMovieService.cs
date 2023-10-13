namespace WebApi.Services.MovieService
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie? SearchMovieByName(string name);
        List<Movie> CreateMovie(Movie movie);
        List<Movie>? UpdateMovie(int id, Movie request);
        List<Movie>? DeleteMovie(int id);
    }
}