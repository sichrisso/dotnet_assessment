namespace WebApi.Services.CinemaService
{
    public interface ICinemaService
    {
        List<Cinema> GetAllCinemas();
        List<Cinema> CreateCinema(Cinema cinema);
        List<Cinema>? UpdateCinema(int id, Cinema request);
    }
}