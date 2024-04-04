using AppWeb601_Horacio.Models;
using Microsoft.EntityFrameworkCore;
namespace AppWeb601_Horacio.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<Producto> Productos { get; set; }
               

    }
}