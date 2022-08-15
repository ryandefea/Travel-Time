using Microsoft.EntityFrameworkCore;

namespace TravelTime.Models
{
    public class TravelTimeContext : DbContext
    {
        public TravelTimeContext(DbContextOptions<TravelTimeContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
{
  builder.Entity<Destination>()
      .HasData(
          new Destination { DestinationId = 1, City = "Tokyo", Country = "Japan", Review = "Best place", Rating = 4 },
          new Destination { DestinationId = 2, City = "Aberdeen", Country = "United States", Review = "Almost as good as Portland", Rating = 3 },
          new Destination { DestinationId = 3, City = "Seattle", Country = "United States", Review = "Great seafood", Rating = 4 }
);
}
        public DbSet<Destination> Destinations { get; set; }
    }
}