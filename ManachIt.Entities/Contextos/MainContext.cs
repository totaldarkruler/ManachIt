
using ManachIt.Entities;
using ManachIt.Entities.Entidades;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ManachIt.Entities.Contextos
{
    public class MainContext : IdentityDbContext<Usuario>
    {

        public MainContext() : base("MainContextConn") {}

        public static MainContext Create()
        {
            return new MainContext();
        }


        public DbSet<Producto> Producto { get; set; }
        public DbSet<Orden> Orden { get; set; }
        public DbSet<Negocio> Negocio { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Inventario> Inventario { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Usuario>().ToTable("Usuario");
        }
    }
}