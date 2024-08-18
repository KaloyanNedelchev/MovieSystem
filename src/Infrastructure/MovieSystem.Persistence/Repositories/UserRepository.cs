using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSystem.Application.Interfaces;
using MovieSystem.Domain.Entities;

namespace MovieSystem.Persistence.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly MovieSystemContext _context;
        public void Create(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
        }   

        public User Read(int id)
        {
            return _context.Users.SingleOrDefault(x => x.UserID == id);
        }

        public List<User> ReadAll()
        {
            return _context.Users.ToList();
        }

        public void Update(User entity)
        {
            User userFromRepository = Read(entity.UserID);
            if (userFromRepository != null)
            {
                userFromRepository.FirstName = entity.FirstName;
                userFromRepository.LastName = entity.LastName;
                userFromRepository.Email = entity.Email;
                userFromRepository.DateOfBirth= entity.DateOfBirth;
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("User does not exist.");
            }
        }

        public void Delete(int id)
        {
            User userFromDb = Read(id);
            if (userFromDb != null)
            {
                _context.Users.Remove(userFromDb);
            }
            else
            {
                throw new Exception("User dows not exist.");
            }
        }

    }
}
