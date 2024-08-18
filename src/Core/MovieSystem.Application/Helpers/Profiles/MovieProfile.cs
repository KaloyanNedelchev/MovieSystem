using AutoMapper;
using MovieSystem.Application.DTOs.MovieDTOs;
using MovieSystem.Application.DTOs.UserDTOs;
using MovieSystem.Domain.Entities;

namespace MovieSystem.Application.Helpers.Profiles
{
    internal class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<MovieGetDTO, Movie>().ReverseMap();

            CreateMap<MovieCreateDTO, Movie>().ReverseMap();

            CreateMap<MovieUpdateDTO, Movie>().ReverseMap();
        }
    }
}
