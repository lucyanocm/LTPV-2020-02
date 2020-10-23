namespace UNITPAC.LTPV.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        SobreNome = c.String(nullable: false, maxLength: 150, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Matricula = c.String(nullable: false, maxLength: 10, unicode: false),
                        Observacoes = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Alunos");
        }
    }
}
