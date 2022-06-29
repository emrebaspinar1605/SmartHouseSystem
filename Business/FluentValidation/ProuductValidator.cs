using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.FluentValidation
{
    public class ProuductValidator:AbstractValidator<Product>
    {
        public ProuductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).Length(2, 30);
            RuleFor(p => p.YearOfProduction).GreaterThan(2005);
            RuleFor(p => p.YearOfProduction).LessThan(DateTime.Now.Year);
            
        }
    }
}
