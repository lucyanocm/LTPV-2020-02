using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UNITPAC.LTPV.Data.Context;
using UNITPAC.LTPV.Data.Interface;
using UNITPAC.LTPV.Dominio.AlunoRoot;

namespace UNITPAC.LTPV.Data.Repositorio
{
    public class AlunoRepository : IAlunoRepository
    {
        private LTPVContext _context;

        public AlunoRepository(LTPVContext context)
        {
            _context = context;
        }

        public void Adicionar(Aluno model)
        {
            _context.Alunos.Add(model);
            _context.SaveChanges();
        }

        public void Atualizar(Aluno model)
        {
            _context.Entry(model).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Excluir(Aluno model)
        {
            var modelLocal = _context.Alunos.Where(a => a.Id == model.Id).First();

            _context.Alunos.Remove(modelLocal);

            _context.SaveChanges();
        }

        public Aluno ObterPorId(int id)
        {
            return _context.Alunos.Where(a => a.Id == id).AsNoTracking().FirstOrDefault();
        }

        public List<Aluno> ObterTodos()
        {
            return _context.Alunos.AsNoTracking().ToList();
        }
    }
}
