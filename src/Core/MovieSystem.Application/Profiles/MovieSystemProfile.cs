using AutoMapper;
using Microsoft.Data.SqlClient;
using MovieSystem.Application.DTOs.MovieDTOs;
using MovieSystem.Application.DTOs.RatingDTOs;
using MovieSystem.Application.DTOs.UserDTOs;
using MovieSystem.Application.DTOs.DirectorDTOs;
using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Profiles
{
    public class MovieSystemProfile : Profile
    {
        public MovieSystemProfile() 
        {
            CreateMap<DirectorCreateDTO, Director>().ReverseMap();

            CreateMap<Director ,DirectorReadDTO>()
                .ForMember(d => d.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(d => d.BirthDate, opt => opt.MapFrom(src => src.BirthDate))
                .ForMember(d => d.Nationality, opt => opt.MapFrom(src => src.Nationality)).ReverseMap();

            CreateMap<DirectorUpdateDTO, Director>()
                .ForMember(d => d.DirectorID, opt => opt.MapFrom(src => src.DirectorID))
                .ForMember(d => d.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(d => d.BirthDate, opt => opt.MapFrom(src => src.BirthDate))
                .ForMember(d => d.Nationality, opt => opt.MapFrom(src => src.Nationality));

            ///////////////////////////////////////////////////////////////////////////////
 
            CreateMap<MovieCreateDTO, Movie>().ReverseMap();

            CreateMap<Movie, MovieReadDTO>()
                .ForMember(m => m.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(m => m.Genre, opt => opt.MapFrom(src => src.Genre))
                .ForMember(m => m.ReleaseDate, opt => opt.MapFrom(src => src.ReleaseDate))
                .ForMember(m => m.DirectorID, opt => opt.MapFrom(src => src.DirectorID)).ReverseMap();

            CreateMap<MovieUpdateDTO, Movie>()
                .ForMember(m => m.MovieID, opt => opt.MapFrom(src => src.MovieID))
                .ForMember(m => m.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(m => m.Genre, opt => opt.MapFrom(src => src.Genre))
                .ForMember(m => m.ReleaseDate, opt => opt.MapFrom(src => src.ReleaseDate))
                .ForMember(m => m.DirectorID, opt => opt.MapFrom(src => src.DirectorID));

            ///////////////////////////////////////////////////////////////////////////////

            CreateMap<RatingCreateDTO, Rating>().ReverseMap();

            CreateMap<Rating, RatingReadDTO>()
                .ForMember(r => r.UserID, opt => opt.MapFrom(src => src.UserID))
                .ForMember(r => r.MovieID, opt => opt.MapFrom(src => src.MovieID))
                .ForMember(r => r.MovieRating, opt => opt.MapFrom(src => src.MovieRating)).ReverseMap();

            CreateMap<RatingUpdateDTO, Rating>()
                .ForMember(r => r.RatingID, opt => opt.MapFrom(src => src.RatingID))
                .ForMember(r => r.UserID, opt => opt.MapFrom(src => src.UserID))
                .ForMember(r => r.MovieID, opt => opt.MapFrom(src => src.MovieID))
                .ForMember(r => r.MovieRating, opt => opt.MapFrom(src => src.MovieRating));

            ///////////////////////////////////////////////////////////////////////////////

            CreateMap<UserCreateDTO, User>().ReverseMap();

            CreateMap<User, UserReadDTO>()
                .ForMember(u => u.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(u => u.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(u => u.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(u => u.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth)).ReverseMap();

            CreateMap<UserUpdateDTO, User>()
                .ForMember(u => u.UserID, opt => opt.MapFrom(src => src.UserID))
                .ForMember(u => u.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(u => u.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(u => u.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(u => u.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth));
        }
    }
}
