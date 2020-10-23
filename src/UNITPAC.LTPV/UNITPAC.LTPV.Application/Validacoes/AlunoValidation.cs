using FluentValidation;
using System;
using UNITPAC.LTPV.Dominio.AlunoRoot;

namespace UNITPAC.LTPV.Aplicacao.Validacoes
{
    public class AlunoValidation : AbstractValidator<Aluno>
    {
        public AlunoValidation()
        {
            RuleFor(a => a.Nome)
                .NotEmpty().WithMessage("O compo {PropertyName} é obrigatório.")
                .Length(2, 150).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres.");

            RuleFor(a => a.SobreNome)
                .NotEmpty().WithMessage("O compo {PropertyName} é obrigatório.")
                .Length(2, 150).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres.");

            RuleFor(a => a.DataNascimento)
                .NotEmpty().WithMessage("O compo {PropertyName} é obrigatório.")
                .LessThan(DateTime.Now).WithMessage("O campo {PropertyName} não pode ser maior que hoje.");

            RuleFor(a => a.Matricula)
                .NotEmpty().WithMessage("O compo {PropertyName} é obrigatório.")
                .Length(10).WithMessage("O campo {PropertyName} precisa ter {MaxLength} caracteres.");            
        }
    }
}
