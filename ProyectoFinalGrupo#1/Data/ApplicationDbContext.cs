using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalGrupo_1.Models;

namespace ProyectoFinalGrupo_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Eventos { get; set; } 
    }
}
