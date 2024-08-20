using FluentValidation;
using MovieSystem.Application.DTOs;
using MovieSystem.Application.DTOs.MovieDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Application.Validators.RegistrationValidator
{
    public class BaseMovieDTOValidator<T> : AbstractValidator<T> where T : MovieTemplateDTO
    {
        public BaseMovieDTOValidator()
        {
            RuleFor(mo => mo.Title)
                .NotNull().WithMessage("Title must not be null")
                .Length(40).WithMessage("Title must not exceed 40 symbols");

            RuleFor(mo => mo.Genre)
                .NotEmpty().WithMessage("Genre is required")
                .Length(30).WithMessage("Genre must not exceed 30 symbols");

            RuleFor(mo => mo.ReleaseDate)
                .NotEmpty().WithMessage("Movie must have a release date");

            RuleFor(mo => mo.DirectorID)
                .NotNull().WithMessage("ID can`t be null")
                .GreaterThanOrEqualTo(0).WithMessage("Id must be a positive number");


        }
    }
}
