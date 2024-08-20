using MovieSystem.Application.DTOs.DirectorDTOs;
using MovieSystem.Application.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Interfaces
{
    public interface IDirectorService
    {

        void Add(DirectorCreateDTO entity);
        DirectorReadDTO Get(int id);
        List<DirectorReadDTO> GetAll();
        void Update(DirectorUpdateDTO entity);
        void Delete(int id);
    }
}
