using LB_HelpDesk.Data.DTO;
using Microsoft.EntityFrameworkCore;

namespace LB_HelpDesk.Data
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options)
            : base(options) { }

        public DbSet<CategoriaCliente> CategoriasCliente { get; set; }
    }
}
