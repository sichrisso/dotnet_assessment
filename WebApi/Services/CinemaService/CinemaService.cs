
namespace WebApi.Services.CinemaService
{
    public class CinemaService : ICinemaService
    {
           private static List<Cinema> cinemas = new List<Cinema> {
                new Cinema 
                {
                    Id = 1,
                    Name = "Breaking Bad",
                    Location = "Action",
                    PhoneNo = "2000"
                }
            };
        public List<Cinema> CreateCinema(Cinema cinema)
        {
            cinemas.Add(cinema);
            return cinemas;
        }

        public List<Cinema> GetAllCinemas()
        {
             return cinemas;
        }

        public List<Cinema>? UpdateCinema(int id, Cinema request)
        {
             var cinema = cinemas.Find(x => x.Id == id);

            if (cinema is null)
            {
                return null;
            }

            cinema.Name = request.Name;
            cinema.Location = request.Location;
            cinema.PhoneNo = request.PhoneNo;

            return cinemas;
            
        }
    }
}