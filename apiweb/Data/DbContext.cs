using Microsoft.EntityFrameworkCore;
using ProyectoRolesApi.Models;
using System.Collections.Generic;

namespace ProyectoRolesApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Rol> RolesEstudiantes { get; set; }
    }
}
