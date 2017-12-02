using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GMS.Models;

namespace GMS.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        #region Auxiliar tables
        public DbSet<EntityType> EntityTypes { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<RelationshipType> RelationshipTypes { get; set; }
        public DbSet<Title> Countries { get; set; }
        #endregion

        #region Core Tables
        public DbSet<Person> People { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        #endregion

        #region Relation Tablels
        public DbSet<PersonName > PersonNames { get; set; }
        public DbSet<OrganisationName> OrganisationNames { get; set; }
        public DbSet<EntityEmailAddress> EntityEmailAddresses { get; set; }
        public DbSet<EntityAddress> EntityAddresses { get; set; }
        public DbSet<EntityPhone> EntityPhones { get; set; }
        #endregion 

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
