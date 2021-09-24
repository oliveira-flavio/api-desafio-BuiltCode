using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace Desafio.Business.Models.Validations
{
    public class MedicoValidation : AbstractValidator<Medico>
    {
        public MedicoValidation()
        {
            RuleFor(m => m.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(3, 255)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(m => m.Crm)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(1, 50)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(m => m.UfCrm)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2)
                .WithMessage("O campo {PropertyName} precisa ter 2 caracteres");

            RuleFor(m => m.Especialidade)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(1, 255)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

        }
    }
}
