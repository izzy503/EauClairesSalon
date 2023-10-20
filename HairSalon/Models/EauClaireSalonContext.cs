using Microsoft.EntityFrameworkCore;

namespace EauClaireSalon.Models
{
  public class EauClaireSalonContext : DbContext
  {
    public EauClaireSalonContext(DbContextOptions<EauClaireSalonContext> options)
        : base(options)
    {
    }

    public DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }
  }
}
