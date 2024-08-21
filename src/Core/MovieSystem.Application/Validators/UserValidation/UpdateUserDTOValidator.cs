using FluentValidation;
using MovieSystem.Application.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Application.Validators.UserValidator
{
    public class UpdateUserDTOValidator : BaseUserDTOValidator<UserUpdateDTO>
    {
        public UpdateUserDTOValidator() 
        { 
            RuleFor(user=>user.UserID)
                .NotNull().WithMessage("ID Can`t be null")
                .GreaterThanOrEqualTo(0).WithMessage("Id must be a positive number");
        }
    }
}
