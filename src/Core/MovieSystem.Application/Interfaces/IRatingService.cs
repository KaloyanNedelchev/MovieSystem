using MovieSystem.Application.DTOs.RatingDTOs;
using MovieSystem.Application.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Interfaces
{
    public interface IRatingService
    {
        void Add(RatingCreateDTO entity);
        RatingReadDTO Get(int id);
        List<RatingReadDTO> GetAll();
        void Update(RatingUpdateDTO entity);
        void Delete(int id);
    }
}
