using FluentValidation;
using SegfyHandsOn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SegfyHandsOn.Service.Validators
{
    public class SeguroAutoValidator : AbstractValidator<SeguroAuto>
    {
        public SeguroAutoValidator()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Não é possível encontrar o objeto.");
                    });

            RuleFor(c => c.CPF)
                .NotEmpty().WithMessage("É necessário informar o CPF.")
                .NotNull().WithMessage("É necessário informar o CPF.");

            RuleFor(c => c.NumeroApolice)
                .NotEmpty().WithMessage("É necessário informar o Numero da Apólice")
                .NotNull().WithMessage("É necessário informar o Numero da Apólice");

            RuleFor(c => c.PlacaVeiculo)
                .NotEmpty().WithMessage("É necessário informar a Placa do Veículo")
                .NotNull().WithMessage("É necessário informar a Placa do Veículo");

            RuleFor(c => c.ValorPremio)
                .NotEmpty().WithMessage("É necessário informar o Valor do Prêmio")
                .NotNull().WithMessage("É necessário informar o Valor do Prêmio");
        }

    }
}
