using FluentValidation;
using FluentValidation.Results;
using UNITPAC.LTPV.Aplicacao.Interfaces;
using UNITPAC.LTPV.Aplicacao.Notificacoes;

namespace UNITPAC.LTPV.Aplicacao.Services.Base
{
    public abstract class BaseService : IBaseService
    {
        protected readonly INotificador _notificador;

        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;            
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

        protected void Notificar(string mensagem, params object[] parametros)
        {
            _notificador.Handle(new Notificacao(string.Format(mensagem, parametros)));
        }

        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade)
            where TE : class
            where TV : AbstractValidator<TE>
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }

        public string ObterNotificacoes()
        {
            string retorno = string.Empty;

            _notificador.ObterNotificacoes().ForEach(n => retorno += n.Mensagem + " \n\n");

            return retorno;
        }
    }
}
