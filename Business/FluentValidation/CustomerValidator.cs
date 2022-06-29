using Entities;
using FluentValidation;

namespace Business.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.SurName).NotEmpty();
            RuleFor(c => c.Tel).NotEmpty();
            RuleFor(c => c.Name).Length(2, 30);
            RuleFor(c => c.SurName).Length(2, 30);

        }
    }
}
