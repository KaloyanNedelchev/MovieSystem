using AutoMapper;
using MovieSystem.Application.DTOs.DirectorDTOs;
using MovieSystem.Application.Interfaces;
using MovieSystem.Application.IRepository;
using MovieSystem.Application.Validators.DirectorValidation;
using MovieSystem.Domain.Entities;

namespace MovieSystem.Application.Services
{
    public class DirectorService : IDirectorService
    {
        private readonly IRepository<Director> _repository;
        private readonly IMapper _mapper;
        private readonly CreateDirectorDTOValidator _validator;
        public DirectorService(IRepository<Director> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _validator = new CreateDirectorDTOValidator();
        }

        public void Add(DirectorCreateDTO entity)
        {
            _validator.Validate(entity);
            Director directorFromClient = _mapper.Map<Director>(entity);
            _repository.Create(directorFromClient);
        }

        public DirectorReadDTO Get(int id)
        {
            Director directorFromDb = _repository.ReadByID(id, false);
            return _mapper.Map<DirectorReadDTO>(directorFromDb);
        }

        public List<DirectorReadDTO> GetAll()
        {
            List<Director> directorsFromDb = _repository.ReadAll(false);
            return _mapper.Map<List<DirectorReadDTO>>(directorsFromDb);
        }

        public void Update(DirectorUpdateDTO entity)
        {
            Director directorFromClient = _mapper.Map<Director>(entity);
            _repository.Update(directorFromClient);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
