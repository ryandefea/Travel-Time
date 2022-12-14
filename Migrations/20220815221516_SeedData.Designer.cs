// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelTime.Models;

namespace TravelTime.Migrations
{
    [DbContext(typeof(TravelTimeContext))]
    [Migration("20220815221516_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TravelTime.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Country")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            City = "Tokyo",
                            Country = "Japan",
                            Rating = 4,
                            Review = "Best place"
                        },
                        new
                        {
                            DestinationId = 2,
                            City = "Aberdeen",
                            Country = "United States",
                            Rating = 3,
                            Review = "Almost as good as Portland"
                        },
                        new
                        {
                            DestinationId = 3,
                            City = "Seattle",
                            Country = "United States",
                            Rating = 4,
                            Review = "Great seafood"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
