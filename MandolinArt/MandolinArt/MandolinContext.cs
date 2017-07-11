using System.Data.Entity;
using MandolinArt.Models;

namespace MandolinArt
{
    public class MandolinContext : DbContext
    {
            public DbSet<Mandolin> Mandolins { get; set; }
    }
}