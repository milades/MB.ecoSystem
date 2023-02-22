using System.Collections.Generic;
using System.Reflection.Emit;  
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MB.AuthDefinition.Entities.Identity;
using MB.DefaultConstants.Shared;

namespace MB.WebApi.Data.dbContext
{
    public class mb_db_context : IdentityDbContext<Users, Roles, int, UserClaims, UserRoles, UserLogins, RoleClaims, UserTokens>
    {
         
        public mb_db_context(DbContextOptions options) : base(options)
        {

        }
        //public virtual DbSet<Setting> Setting { get; set; }
        //public virtual DbSet<Templates> Templates { get; set; }
        //public virtual DbSet<TemplateValues> TemplateValues { get; set; }
        //public virtual DbSet<ApiParameters> ApiParameters { get; set; }
        //public virtual DbSet<Logs> Logs { get; set; }

         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>().HasQueryFilter(m => EF.Property<bool>(m, SharedConstants.is_deleted) == false);
            modelBuilder.Entity<Roles>().HasQueryFilter(m => EF.Property<bool>(m, SharedConstants.is_deleted) == false);

        }
    }
}
