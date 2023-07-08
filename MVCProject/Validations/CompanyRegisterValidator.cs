using FluentValidation;
using MVCProject.Models;

namespace MVCProject.Validations
{
    public class CompanyRegisterValidator:AbstractValidator<CompanyRegisterVM>
    {
        public CompanyRegisterValidator()
        {
            RuleFor(s => s.CompanyName).NotEmpty().NotNull().MaximumLength(5);
            RuleFor(s => s.Sector).NotEmpty().NotNull();
            RuleFor(s => s.Country).NotEmpty().NotNull();
            RuleFor(s => s.City).NotEmpty().NotNull();
            RuleFor(s => s.Phone).NotEmpty().NotNull();
            RuleFor(s => s.Address).NotEmpty().NotNull();
        }
    }
}
