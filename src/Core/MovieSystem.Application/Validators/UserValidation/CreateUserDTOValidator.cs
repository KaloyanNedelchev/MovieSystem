using FluentValidation;
using MovieSystem.Application.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Validators.UserValidation
{
    public class CreateUserDTOValidator : AbstractValidator<UserCreateDTO>
    {
        public CreateUserDTOValidator() 
        {

        }
    }
}
