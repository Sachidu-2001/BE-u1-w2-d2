using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using WebAppEsame2.Models;

namespace WebAppEsame2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        
        public DbSet<Anagrafica> Anagrafiche { get; set; }
        public DbSet<Tipo_Violazione>  Tipo_Violazioni {  get; set; }
        public  DbSet<Verbale> Verbali { get; set; }
    }
}
