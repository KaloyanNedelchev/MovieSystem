using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MovieSystem.Application.DTOs.DirectorDTOs;

namespace MovieSystem.Application.Validators.DirectorValidation
{
    public class CreateDirectorDTOValidator : AbstractValidator<DirectorCreateDTO>
    {
        public CreateDirectorDTOValidator()
        {
            
        }
    }
}
