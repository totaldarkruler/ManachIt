namespace ManachIt.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracionIdentity : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Usuario");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Correo = c.String(),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
        }
    }
}
