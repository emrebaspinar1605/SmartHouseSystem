using Entities;
using FluentValidation;

namespace Business.FluentValidation
{
    public class ElectronicStuffValidator:AbstractValidator<ElectronicStuff>
    {
        public ElectronicStuffValidator()
        {
            RuleFor(c => c.PriceForSpendElectric).NotEmpty();
            RuleFor(c => c.SpendElectric).NotEmpty();
        }
    }
}
