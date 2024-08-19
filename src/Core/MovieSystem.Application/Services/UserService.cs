using AutoMapper;
using MovieSystem.Application.Interfaces;
using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Services
{
    public class UserService : IUserService <User>
    {
        private readonly IUserRepository<User> _repository;
        public UserService(IUserRepository<User> repository)
        {
            _repository = repository;
        }
        public void Add(User entity)
        {
            _repository.Create(entity);
        }
        public User ReadByID(int id)
        {
            return _repository.ReadByID(id);
        }
        public User ReadByEmail(string email)
        {
            return _repository.ReadByEmail(email);
        }
        public List<User> GetAll()
        {

            return _repository.ReadAll();
        }
        public void Update(User entity)
        {
            _repository.Update(entity);
        }
        public void Delete(int key)
        {
            _repository.Delete(key);
        }
    }
}
