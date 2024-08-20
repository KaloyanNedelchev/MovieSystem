using MovieSystem.Application.DTOs.DirectorDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Application.Validators.SpeakerValidator
{
    public class UpdateDIrectorDTOValidator : BaseDirectorDTOValidator<DirectorUpdateDTO>
    {
        public UpdateDIrectorDTOValidator()
        {
            RuleFor(di => di.DirectorID)
                .NotNull().WithMessage("Id can`t be null")
                .GreaterThanOrEqualTo(0).WithMessage("Id must be a positive number");
        }

    }
}
