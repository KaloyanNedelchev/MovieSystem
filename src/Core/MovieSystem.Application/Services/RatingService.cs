using MovieSystem.Application.Interfaces;
using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Services
{
    public class RatingService : IService<Rating>
    {
        private readonly IRepository<Rating> _repository;
        public RatingService(IRepository<Rating> repository)
        {
            _repository = repository;
        }
        public void Add(Rating entity)
        {
            _repository.Create(entity);
        }
        public Rating Read(int id)
        {
            return _repository.Read(id);
        }
        public List<Rating> GetAll()
        {
            return _repository.ReadAll();
        }
        public void Update(Rating entity)
        {
            _repository.Update(entity);
        }
        public void Delete(int key)
        {
            _repository.Delete(key);
        }
    }
}
