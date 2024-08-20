using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieSystem.Application.Interfaces;
using MovieSystem.Domain.Entities;

namespace MovieSystem.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MovieSystemContext _context;
        public void Create(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
        }   

        public User ReadByID(int id, bool loadNP)
        {
            IQueryable<User> users = _context.Users;

            if (loadNP)
            {
                users = users
                    .Include(r => r.FirstName);
                    
            }

            return users.SingleOrDefault(x => x.UserID == id);
        }
        public int ReadIdByEmail(string email)
        {
            return _context.Users.SingleOrDefault(x => x.Email == email).;
        }
        public List<User> ReadAll(bool loadNP)
        {
            IQueryable<User> users = _context.Users;

            if (loadNP)
            {
                users = users
                    .Include(x => x.FirstName)
                    .Include(x => x.LastName);
            }

            return users.ToList();
        }

        public void Update(User entity)
        {
            User userFromRepository = ReadByID(entity.UserID, false);
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
            User userFromDb = ReadByID(id, false);
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
