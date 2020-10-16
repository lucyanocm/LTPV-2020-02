using System;
using System.Collections.Generic;
using UNITPAC.LTPV.Data.Interface;
using UNITPAC.LTPV.Dominio.AlunoRoot;

namespace UNITPAC.LTPV.Data.Repositorio
{
    public class AlunoRepository : IAlunoRepository
    {
        private List<Aluno> _alunos;

        public AlunoRepository()
        {
            _alunos = new List<Aluno>();
            _alunos.Add(new Aluno() 
            { 
                Id = 1,
                Nome = "Fulano",
                SobreNome = "da Silva",
                Matricula = "0800001",
                DataNascimento = new DateTime(2000, 01, 01), 
                Observacoes = "Exelente aluno"
            });
            _alunos.Add(new Aluno()
            {
                Id = 2,
                Nome = "Ayrton",
                SobreNome = "Senna da Silva",
                Matricula = "0800002",
                DataNascimento = new DateTime(1960, 03, 21),
                Observacoes = "Exelente aluno, porém é muito apressadinho."
            });
            _alunos.Add(new Aluno()
            {
                Id = 3,
                Nome = "Anderson",
                SobreNome = "da Silva",
                Matricula = "0800003",
                DataNascimento = new DateTime(1975, 04, 14),
                Observacoes = "Se eu fosse professor dele não ousaria contrariá-lo."
            });
            _alunos.Add(new Aluno()
            {
                Id = 4,
                Nome = "Santos",
                SobreNome = "Dumont",
                Matricula = "0800004",
                DataNascimento = new DateTime(1873, 07, 20),
                Observacoes = "Bom aluno, porém voa um pouco durante a aula."
            });
        }

        public List<Aluno> ObterTodos()
        {
            return _alunos;
        }
    }
}
