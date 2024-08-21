using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSystem.Application.DTOs;

namespace EventManagementSystem.Application.Validators.UserValidator
{
    public class BaseUserDTOValidator<T> : AbstractValidator<T> where T : UserTemplateDTO
    {
        public BaseUserDTOValidator()
        {
            RuleFor(user => user.FirstName)
                .NotEmpty().WithMessage("First name can`t be null")
                .Length(1, 25);

            RuleFor(user => user.LastName)
                .NotEmpty().WithMessage("Last name can`t be null")
                .Length(1, 40);

            RuleFor(user => user.Email)
                 .NotEmpty().WithMessage("Email is required")
                 .EmailAddress().WithMessage("Invalid email")
                 .Length(10,40).WithMessage("Email must be between 10 and 40 characters");

            RuleFor(user => user.DateOfBirth)
                .NotNull().WithMessage("Date of birth can`t be null")
                .LessThan(DateOnly.FromDateTime(DateTime.Today)).WithMessage("Enter a valid date of birth");
        }
    }
}
