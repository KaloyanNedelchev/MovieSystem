using MovieSystem.Application.Interfaces;
using MovieSystem.Domain.Entities;
using MovieSystem.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Persistence.Repositories
{
    public class RatingRepository : IRepository<Rating>
    {
        private readonly MovieSystemContext _context;
        public void Create(Rating entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
        public Rating ReadByID(int id)
        {
            return _context.Ratings.SingleOrDefault(x => x.RatingID == id);
        }
        public List<Rating> ReadAll() 
        { 
            return _context.Ratings.ToList();
        }
        public void Update(Rating entity)
        { 
            Rating ratingFromRepository = ReadByID(entity.RatingID);
            if (ratingFromRepository != null)
            {
                ratingFromRepository.UserID = entity.UserID;
                ratingFromRepository.MovieID = entity.MovieID;
                ratingFromRepository.MovieRating = entity.MovieRating;
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Rating does not exist");
            }
        }
        public void Delete(int id)
        {
            Rating ratingFromDb = ReadByID(id);
            if (ratingFromDb != null)
            {
                _context.Ratings.Remove(ratingFromDb);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Rating does not exist");
            }
        }
    }
}
