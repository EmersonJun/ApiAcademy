using Microsoft.EntityFrameworkCore;
using EquipamentosApi.Models;

namespace EquipamentosApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Equipamento> Equipamentos { get; set; }
    }
}
