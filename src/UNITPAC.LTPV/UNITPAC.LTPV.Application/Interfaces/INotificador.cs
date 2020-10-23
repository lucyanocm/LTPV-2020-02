using System.Collections.Generic;
using UNITPAC.LTPV.Aplicacao.Notificacoes;

namespace UNITPAC.LTPV.Aplicacao.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
