namespace ManachIt.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreacionTablasNegocio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Rfc = c.String(),
                        FechaAlta = c.DateTime(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        Negocio_NegocioId = c.Int(),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.Negocio", t => t.Negocio_NegocioId)
                .Index(t => t.Negocio_NegocioId);
            
            CreateTable(
                "dbo.Orden",
                c => new
                    {
                        OrdenId = c.Int(nullable: false, identity: true),
                        FechaCreacion = c.String(),
                        Descripcion = c.String(),
                        Cliente_ClienteId = c.Int(),
                        Negocio_NegocioId = c.Int(),
                        Producto_ProductoId = c.Int(),
                    })
                .PrimaryKey(t => t.OrdenId)
                .ForeignKey("dbo.Cliente", t => t.Cliente_ClienteId)
                .ForeignKey("dbo.Negocio", t => t.Negocio_NegocioId)
                .ForeignKey("dbo.Producto", t => t.Producto_ProductoId)
                .Index(t => t.Cliente_ClienteId)
                .Index(t => t.Negocio_NegocioId)
                .Index(t => t.Producto_ProductoId);
            
            CreateTable(
                "dbo.Inventario",
                c => new
                    {
                        InventarioId = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Almacen = c.String(),
                        ProductoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InventarioId);
            
            CreateTable(
                "dbo.Negocio",
                c => new
                    {
                        NegocioId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Direccion = c.String(),
                        Rfc = c.String(),
                    })
                .PrimaryKey(t => t.NegocioId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        NegocioId = c.Int(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Negocio", t => t.NegocioId, cascadeDelete: true)
                .Index(t => t.NegocioId)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            AddColumn("dbo.Producto", "Negocio_NegocioId", c => c.Int());
            CreateIndex("dbo.Producto", "Negocio_NegocioId");
            AddForeignKey("dbo.Producto", "Negocio_NegocioId", "dbo.Negocio", "NegocioId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUsers", "NegocioId", "dbo.Negocio");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Producto", "Negocio_NegocioId", "dbo.Negocio");
            DropForeignKey("dbo.Orden", "Producto_ProductoId", "dbo.Producto");
            DropForeignKey("dbo.Orden", "Negocio_NegocioId", "dbo.Negocio");
            DropForeignKey("dbo.Cliente", "Negocio_NegocioId", "dbo.Negocio");
            DropForeignKey("dbo.Orden", "Cliente_ClienteId", "dbo.Cliente");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUsers", new[] { "NegocioId" });
            DropIndex("dbo.Producto", new[] { "Negocio_NegocioId" });
            DropIndex("dbo.Orden", new[] { "Producto_ProductoId" });
            DropIndex("dbo.Orden", new[] { "Negocio_NegocioId" });
            DropIndex("dbo.Orden", new[] { "Cliente_ClienteId" });
            DropIndex("dbo.Cliente", new[] { "Negocio_NegocioId" });
            DropColumn("dbo.Producto", "Negocio_NegocioId");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Negocio");
            DropTable("dbo.Inventario");
            DropTable("dbo.Orden");
            DropTable("dbo.Cliente");
        }
    }
}
