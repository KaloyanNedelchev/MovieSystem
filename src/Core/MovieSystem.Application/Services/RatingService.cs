using AutoMapper;
using MovieSystem.Application.DTOs.RatingDTOs;
using MovieSystem.Application.Interfaces;
using MovieSystem.Application.IRepository;
using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRepository<Rating> _repository;
        private readonly IMapper _mapper;
        public RatingService(IRepository<Rating> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Add(RatingCreateDTO entity)
        {
            Rating ratingFromClient = _mapper.Map<Rating>(entity);
            _repository.Create(ratingFromClient);
        }

        public RatingReadDTO Get(int id)
        {
            Rating ratingFromDb = _repository.ReadByID(id, false);
            return _mapper.Map<RatingReadDTO>(ratingFromDb);
        }

        public List<RatingReadDTO> GetAll()
        {
            List<Rating> ratingsFromDb = _repository.ReadAll(false);
            return _mapper.Map<List<RatingReadDTO>>(ratingsFromDb);
        }

        public void Update(RatingUpdateDTO entity)
        {
            Rating ratingFromClient = _mapper.Map<Rating>(entity);
            _repository.Update(ratingFromClient);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
