using System;
using AcmeProducts.Application.Interfaces;
using FluentValidation;

namespace AcmeProducts.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator(ITranslator translator)
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
