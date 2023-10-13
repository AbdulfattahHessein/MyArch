using FluentValidation;
using MyArch.Core.Entities;

namespace MyArch.BusinessLogic.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Description)
                .NotNull()
                .WithMessage("Description can't be null")
                .NotEmpty()
                .WithMessage("Description can't be empty");

        }
    }
}
