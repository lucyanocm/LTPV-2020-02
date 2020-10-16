using System.Collections.Generic;
using UNITPAC.LTPV.Dominio.AlunoRoot;

namespace UNITPAC.LTPV.Data.Interface
{
    public interface IAlunoRepository
    {
        List<Aluno> ObterTodos();
    }
}
