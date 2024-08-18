using MovieSystem.Application.DTOs.MovieDTOs;

namespace MovieSystem.Application.Interfaces
{
    public interface IMovieService
    {
        List<MovieGetDTO> GetAll();
        MovieGetDTO GetById(int id);
        MovieGetDTO Create(MovieCreateDTO entity);
        MovieGetDTO Update(MovieUpdateDTO entity);
        void Delete(int key);
    }
}