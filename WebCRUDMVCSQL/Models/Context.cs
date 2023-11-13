using Microsoft.EntityFrameworkCore;

namespace WebCRUDMVCSQL.Models
{
    public class Context : DbContext
    {
        public Context()
        {
            
        }

        public Context(DbContextOptions<Context> op) : base(op)
        {
            
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
