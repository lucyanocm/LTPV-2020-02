using System.Configuration;
using System.Data.Entity;
using UNITPAC.LTPV.Dominio.AlunoRoot;

namespace UNITPAC.LTPV.Data.Context
{
    public class LTPVContext : DbContext
    {
        public LTPVContext() : base(ConfigurationManager.ConnectionStrings["StrConexao"].ConnectionString)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("Alunos");

            modelBuilder.Entity<Aluno>().HasKey(pk => pk.Id);

            modelBuilder.Entity<Aluno>()
                .Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired()
                .HasColumnOrder(1);

            modelBuilder.Entity<Aluno>()
                .Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(150)
                .IsRequired()
                .HasColumnOrder(2);

            modelBuilder.Entity<Aluno>()
                .Property(p => p.SobreNome)
                .HasColumnName("SobreNome")
                .HasColumnType("varchar")
                .HasMaxLength(150)
                .IsRequired()
                .HasColumnOrder(3);

            modelBuilder.Entity<Aluno>()
                .Property(p => p.DataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("datetime")
                .IsRequired()
                .HasColumnOrder(4);

            modelBuilder.Entity<Aluno>()
                .Property(p => p.Matricula)
                .HasColumnName("Matricula")
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsRequired()
                .HasColumnOrder(5);

            modelBuilder.Entity<Aluno>()
                .Property(p => p.Observacoes)
                .HasColumnName("Observacoes")
                .HasColumnType("ntext")
                .HasColumnOrder(6);

            base.OnModelCreating(modelBuilder);
        }
    }
}
