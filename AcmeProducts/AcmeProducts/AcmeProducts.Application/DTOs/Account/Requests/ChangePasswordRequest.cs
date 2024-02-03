﻿using AcmeProducts.Application.Helpers;
using AcmeProducts.Application.Interfaces;
using FluentValidation;

namespace AcmeProducts.Application.DTOs.Account.Requests
{
    public class ChangePasswordRequest
    {
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
    public class ChangePasswordRequestValidator : AbstractValidator<ChangePasswordRequest>
    {
        public ChangePasswordRequestValidator(ITranslator translator)
        {
            RuleFor(x => x.Password)
                .NotEmpty().NotNull()
                .MinimumLength(6)
                .Matches(Regexs.Password)
                .WithName(translator["Password"]);

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password)
                .Matches(Regexs.Password)
                .WithName(translator["ConfirmPassword"]);
        }
    }

}
