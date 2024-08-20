using FluentValidation;
using MovieSystem.Application.DTOs.DirectorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Application.Validators.SpeakerValidator
{
    public class BaseDirectorDTOValidator<T> : AbstractValidator<T> where T : DirectorUpdateDTO
    {
        public BaseDirectorDTOValidator()
        {
            RuleFor(di => di.Name)
                .NotEmpty().WithMessage("Name can`t be null")
                .Length(3, 60);

        }
    }
}
