using Application.CQRS.Commands.PersonCommands;
using FluentValidation;
using System;

namespace Application.Common.Validators.EntityValidators
{
    public class CreatePersonCommandValidator : AbstractValidator<CreatePersonCommand>
    {
        public CreatePersonCommandValidator()
        {
            RuleFor(x => x.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Matches("^[a-zA-Z]*$").WithMessage("{PropertyName} can only contain alphabets")
                .MaximumLength(25);

            RuleFor(x => x.DateOfBirth)
                .Must(BeAValidAge).WithMessage("{PropertyName} is invalid");
        }

        protected bool BeAValidAge(DateTime date)
        {
            int currentYear = DateTime.Now.Year;
            int dobYear = date.Year;

            return (dobYear <= currentYear && dobYear > (currentYear - 100));
        }
    }
}
