using MovieSystem.Domain.Entities;

namespace MovieSystem.Persistence.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieSystemContext _context;

        public MovieRepository(MovieSystemContext context)
        {
            _context = context;
        }

        public List<Movie> ReadAll()
        {
            return _context.Movies.ToList();
        }

        public Movie Read(int id)
        {
            return _context.Movies.SingleOrDefault(x => x.MovieID == id);
        }

        public Movie Create(Movie entity)
        {
            var movie = _context.Add(entity);
            _context.SaveChanges();
            return new Movie(); //  movie.Entity; //return the created movie
        }

        public Movie Update(Movie entity)
        {
            Movie movieFromRepository = Read(entity.MovieID);
            if (movieFromRepository != null)
            {
                movieFromRepository.Title = entity.Title;
                movieFromRepository.Genre = entity.Genre;
                movieFromRepository.ReleaseDate = entity.ReleaseDate;
                movieFromRepository.DirectorID = entity.DirectorID;
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Movie does not exist");
            }

            return new Movie(); //return the updated movie
        }
        public void Delete(int id)
        {
            Movie movieFromDb = Read(id);
            if (movieFromDb != null)
            {
                _context.Movies.Remove(movieFromDb);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Movie does not exist");
            }
        }
    }
}
