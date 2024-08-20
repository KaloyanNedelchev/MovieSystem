using FluentValidation;
using MovieSystem.Application.DTOs.RatingDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Application.Validators.EventValidator
{
    public class BaseRatingDTOValidator<T> : AbstractValidator<T> where T : RatingTemplateDTO
    {
        public BaseRatingDTOValidator()
        {
            RuleFor(user => user.MovieID)
                .NotNull().WithMessage("ID Can`t be null")
                .GreaterThanOrEqualTo(0).WithMessage("Id must be a positive number");

            RuleFor(user => user.UserID)
                .NotNull().WithMessage("ID Can`t be null")
                .GreaterThanOrEqualTo(0).WithMessage("Id must be a positive number");

            RuleFor(ra => ra.MovieRating)
                .NotEmpty().WithMessage("Rating can`t be null")
                .GreaterThan(1).LessThan(10).WithMessage("Movie's rating must be between 1 and 10");

        }
    }
}
