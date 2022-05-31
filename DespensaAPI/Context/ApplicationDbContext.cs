using DespensaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DespensaAPI.Context
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Producto> Producto { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
    }
}
