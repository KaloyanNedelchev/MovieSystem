using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieSystem.Application.IRepository;
using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Persistence.Repositories
{
    public class MovieRepository : IRepository<Movie>
    {
        private readonly MovieSystemContext _context;
        public void Create(Movie entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
        public Movie ReadByID(int id, bool loadNP)
        {
            IQueryable<Movie> movies = _context.Movies;

            if (loadNP)
            {
                movies = movies
                    .Include(m => m.Title)
                    .Include(m => m.Genre);
            }

            return movies.SingleOrDefault(x => x.MovieID == id);
        }
        public List<Movie> ReadAll(bool loadNP)
        {
            IQueryable<Movie> movies = _context.Movies;

            if (loadNP)
            {
                movies = movies
                    .Include(m => m.Title)
                    .Include(m => m.Genre);
            }

            return movies.ToList();
        }
        public void Update(Movie entity)
        {
            Movie movieFromRepository = ReadByID(entity.MovieID, false);
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
        }
        public void Delete(int id)
        {
            Movie movieFromDb = ReadByID(id, false);
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
