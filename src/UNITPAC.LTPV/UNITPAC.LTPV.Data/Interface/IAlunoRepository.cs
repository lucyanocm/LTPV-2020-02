using System.Collections.Generic;
using UNITPAC.LTPV.Dominio.AlunoRoot;

namespace UNITPAC.LTPV.Data.Interface
{
    public interface IAlunoRepository
    {
        List<Aluno> ObterTodos();
        void Adicionar(Aluno model);
        void Atualizar(Aluno model);
        void Excluir(Aluno model);
        Aluno ObterPorId(int id);
    }
}
