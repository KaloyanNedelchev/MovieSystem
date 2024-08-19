using MovieSystem.Application.Interfaces;
using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Services
{
    public class DirectorService : IService<Director>
    {
        private readonly IRepository<Director> _repository;
        public DirectorService(IRepository<Director> repository)
        {
            _repository = repository;
        }
        public void Add(Director entity)
        {
            _repository.Create(entity);
        }
        public Director ReadByID(int id)
        {
            return _repository.ReadByID(id);
        }
        public List<Director> GetAll()
        {
            return _repository.ReadAll();
        }
        public void Update(Director entity)
        {
            _repository.Update(entity);
        }
        public void Delete(int key)
        {
            _repository.Delete(key);
        }
    }
}
