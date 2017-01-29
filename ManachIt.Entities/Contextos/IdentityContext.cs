using ManachIt.Entities.Entidades;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManachIt.Entities.Contextos
{
    public class IdentityContext //: IdentityDbContext<Usuario>
    {
        //public IdentityContext()
        //    : base("MainContextConn", throwIfV1Schema: false)
        //{
        //}

    

        //public static IdentityContext Create()
        //{
        //    return new IdentityContext();
        //}

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
        //    modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
        //    modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        //}
    }
}
