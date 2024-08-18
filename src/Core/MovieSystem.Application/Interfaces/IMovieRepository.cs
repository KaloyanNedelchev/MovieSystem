using MovieSystem.Domain.Entities;

namespace MovieSystem.Persistence.Repositories
{
    public interface IMovieRepository
    {
        Movie Read(int id);
        List<Movie> ReadAll();
        Movie Create(Movie entity);
        Movie Update(Movie entity);
        void Delete(int id);
    }
}