using System;
using System.ComponentModel;
using UNITPAC.LTPV.Aplicacao.Interfaces;
using UNITPAC.LTPV.Aplicacao.Services.Base;
using UNITPAC.LTPV.Aplicacao.Validacoes;
using UNITPAC.LTPV.Data.Interface;
using UNITPAC.LTPV.Dominio.AlunoRoot;

namespace UNITPAC.LTPV.Aplicacao.Services
{
    public class AlunoService : BaseService, IAlunoService
    {
        private readonly IAlunoRepository _repository;
        public AlunoService(INotificador notificador,
                            IAlunoRepository repository) : base(notificador)
        {
            _repository = repository;
        }

        public bool Adicionar(Aluno model)
        {
            if (!ExecutarValidacao(new AlunoValidation(), model))
                return false;

            try
            {
                _repository.Adicionar(model);
                return true;
            }
            catch (Exception ex)
            {
                Notificar("Não foi possível adicionar o registro. Motivo: {0}", ex.Message);
                return false;
            }
        }

        public bool Atualizar(Aluno model)
        {
            if (!ExecutarValidacao(new AlunoValidation(), model))
                return false;

            try
            {
                _repository.Atualizar(model);
                return true;
            }
            catch (Exception ex)
            {
                Notificar("Não foi possível atualizar o registro. Motivo: {0}", ex.Message);
                return false;
            }
        }
    }
}
