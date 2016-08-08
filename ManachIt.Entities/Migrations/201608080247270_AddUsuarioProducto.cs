namespace ManachIt.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsuarioProducto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Desc = c.String(),
                    })
                .PrimaryKey(t => t.ProductoId);
            
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
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
            DropTable("dbo.Producto");
        }
    }
}
