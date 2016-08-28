
using ManachIt.Entities;
using ManachIt.Entities.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{
    public class MainContext : DbContext 
    {

        public MainContext() : base("MainContextConn") // <-- Conexion BD
        {
        }

       
        public DbSet<Producto> Producto { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}