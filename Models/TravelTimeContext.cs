using Microsoft.EntityFrameworkCore;

namespace TravelTime.Models
{
    public class TravelTimeContext : DbContext
    {
        public TravelTimeContext(DbContextOptions<TravelTimeContext> options)
            : base(options)
        {
        }

        public DbSet<Destination> Destinations { get; set; }
    }
}