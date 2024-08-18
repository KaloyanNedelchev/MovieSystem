using MovieSystem.Application.Interfaces;
using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Services
{
    public class UserService : IService<User>
    {
        private readonly IRepository<User> _repository;
        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }
        public void Add(User entity)
        {
            _repository.Create(entity);
        }
        public User Read(int id)
        {
            return _repository.Read(id);
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
