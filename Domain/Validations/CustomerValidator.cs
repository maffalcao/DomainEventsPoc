using Domain.Entities;
using FluentValidation;

namespace Domain.Validations
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(a => a.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Invalid email");

            RuleFor(a => a.Name)
                .NotEmpty()
                .WithMessage("Name cannot be empty");
        }
    }
}