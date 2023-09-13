using Microsoft.EntityFrameworkCore;
using ventas.webapi.ApplicationCore.Models;

namespace ventas.webapi.Infrastructure.Base
{
    public class VentasContext : DbContext
    {
        private static string CONNECTION_STRING = "server=localhost;database=db_ventas;user=cbarrios;password=1234567;";
        public DbSet<Orden> Orden { get; set; } = null!;
        public DbSet<Producto> Producto { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(CONNECTION_STRING, serverVersion: ServerVersion.AutoDetect(CONNECTION_STRING));
        }
    }
}