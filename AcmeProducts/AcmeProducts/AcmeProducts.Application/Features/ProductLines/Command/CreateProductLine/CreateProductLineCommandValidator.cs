using AcmeProducts.Application.Interfaces;
using FluentValidation;

namespace AcmeProducts.Application.Features.ProductLines.Command.CreateProductLine;

public class CreateProductLineCommandValidator : AbstractValidator<CreateProductLineCommand>
{
    public CreateProductLineCommandValidator(ITranslator translator)
    {

        RuleFor(p => p.ProductLineName)
            .NotNull()
            .NotEmpty()
            .MaximumLength(100)
            .WithName(p => translator["ProductLine Name"]);

        RuleFor(p => p.HtmlDescription)
            .NotNull()
            .NotEmpty()
            .MaximumLength(10000)
            .WithName(p => translator["Html Description"]);

        RuleFor(p => p.TextDescription)
            .NotNull()
            .NotEmpty()
            .MaximumLength(1000)
            .WithName(p => translator["Text Description"]);
    }
}