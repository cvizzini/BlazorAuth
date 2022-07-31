
using BlazorApp1.Server.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace BlazorApp1.Server.Context
{
    public class BlazorApp1Context : IdentityDbContext<IdentityUser>
    {
        private readonly IConfiguration configuration;
       
        public BlazorApp1Context(IConfiguration configuration, DbContextOptions<BlazorApp1Context> options)
            : base(options)
        {
            this.configuration = configuration;
        }

        //public virtual DbSet<EmployeeEntity> Employees { get; set; }     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnectionString");
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
