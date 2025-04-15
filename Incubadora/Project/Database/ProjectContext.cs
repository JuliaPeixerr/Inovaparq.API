﻿using Incubadora.Project.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Incubadora.Project.Database
{
    public class ProjectContext : DbContext
    {
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Domain.Models.Incubadora> Incubadora { get; set; }
        public virtual DbSet<IncubadoraStatus> IncubadoraStatus { get; set; }

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
