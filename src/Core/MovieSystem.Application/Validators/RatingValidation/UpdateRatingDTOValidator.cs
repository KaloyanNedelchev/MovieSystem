using FluentValidation;
using MovieSystem.Application.DTOs.RatingDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Application.Validators.EventValidator
{
    public class UpdateRatingDTOValidator : BaseRatingDTOValidator<RatingUpdateDTO>
    {
        public UpdateRatingDTOValidator()
        {
            RuleFor(user => user.RatingID)
                .NotNull().WithMessage("ID can`t be null")
                .GreaterThanOrEqualTo(0).WithMessage("Id must be a positive number");
        }
    }
}
