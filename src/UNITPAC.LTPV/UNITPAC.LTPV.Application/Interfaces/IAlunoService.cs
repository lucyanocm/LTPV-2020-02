using UNITPAC.LTPV.Dominio.AlunoRoot;

namespace UNITPAC.LTPV.Aplicacao.Interfaces
{
    public interface IAlunoService : IBaseService
    {
        bool Adicionar(Aluno model);
        bool Atualizar(Aluno model);
    }
}
