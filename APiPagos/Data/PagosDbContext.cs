using System.Security.Cryptography.X509Certificates;
using APiPagos.Models;
using Microsoft.EntityFrameworkCore;

namespace APiPagos.Data
{
    public class PagosDbContext : DbContext
    {
        public PagosDbContext(DbContextOptions<PagosDbContext> options) : base(options) { }
            public DbSet<Pago> Pagos { get; set; }
    }
}
