using Microsoft.EntityFrameworkCore;
using CRUD_MYSQL.Models;

namespace CRUD_MYSQL.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }

        public DbSet<Usuario> Usuario { get; set; }

    }
}
