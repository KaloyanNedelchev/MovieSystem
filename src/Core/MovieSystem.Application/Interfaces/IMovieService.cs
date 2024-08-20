using MovieSystem.Application.DTOs.MovieDTOs;
using MovieSystem.Application.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Interfaces
{
    public interface IMovieService
    {
        void Add(MovieCreateDTO entity);
        MovieReadDTO Get(int id);
        List<MovieReadDTO> GetAll();
        void Update(MovieUpdateDTO entity);
        void Delete(int id);
    }
}
