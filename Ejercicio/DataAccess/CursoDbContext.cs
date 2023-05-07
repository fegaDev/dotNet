using Ejercicio.Models.DataModel;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio.DataAccess
{
    // : DBContext : Come from EntityFramework
    public class CursoDbContext : DbContext
    {
        public CursoDbContext(DbContextOptions<CursoDbContext> options): base(options) 
        {
            
        }

        public DbSet<Curso>? Cursos { get; set; }    


    }
}
