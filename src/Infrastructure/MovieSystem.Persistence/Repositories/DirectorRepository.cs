using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSystem.Application.Interfaces;
using MovieSystem.Domain.Entities;

namespace MovieSystem.Persistence.Repositories
{
    public class DirectorRepository : IRepository<Director>
    {
        private readonly MovieSystemContext _context;
        public void Create(Director entity)
        {
            _context.Directors.Add(entity);
            _context.SaveChanges();
        }

        public Director ReadByID(int id)
        {
            return _context.Directors.SingleOrDefault(x => x.DirectorID == id);
        }

        public List<Director> ReadAll()
        {
            return _context.Directors.ToList();
        }

        public void Update(Director entity)
        {
            Director directorFromRepository = ReadByID(entity.DirectorID);
            if (directorFromRepository != null)
            {
                directorFromRepository.Name = entity.Name;
                directorFromRepository.BirthDate = entity.BirthDate;
                directorFromRepository.Nationality = entity.Nationality;
            }
            else
            {
                throw new Exception("Director does not exist.");
            }
        }

        public void Delete(int id)
        {
            Director directorFromDb = ReadByID(id);
            if (directorFromDb != null)
            {
                _context.Directors.Remove(directorFromDb);
            }
            else
            {
                throw new Exception("User dows not exist.");
            }
        }
    }
}
