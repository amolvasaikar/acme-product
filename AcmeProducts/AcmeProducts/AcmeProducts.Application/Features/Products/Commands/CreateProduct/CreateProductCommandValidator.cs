using System;
using AcmeProducts.Application.Interfaces;
using FluentValidation;

namespace AcmeProducts.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator(ITranslator translator)
        {

            RuleFor(p => p.ProductName)
                .NotNull()
                .NotEmpty()
                .MaximumLength(100)
                .WithName(p => translator["Name"]);

            RuleFor(p => p.ProductCode)
                .NotNull()
                .NotEmpty()
                .MaximumLength(100)
                .WithName(p => translator["Code"]);

            RuleFor(p => p.ProductVendor)
                .NotNull()
                .NotEmpty()
                .MaximumLength(100)
                .WithName(p => translator["Product Vendor"]);

            RuleFor(p => p.ProductDescription)
                .NotNull()
                .NotEmpty()
                .MaximumLength(Int32.MaxValue)
                .WithName(p => translator["Product Description"]);
        }
    }
}
