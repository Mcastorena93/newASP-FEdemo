using CityInfo.API.Entities;
using CityInfo.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Xml.Linq;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;

        public DbSet<PointsOfInterest> PointsOfInterest { get; set; } = null!;

        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                
                new City("New York City")
                {
                    Id = 1,
                    Description = "The one with the big park."
                },
                new City("Antwerp")
                {
                    Id = 2,
                    Description = "The one with the cathedral that was never finished."
                },
                new City("Paris")
                {
                    Id = 3,
                    Description = "The one with that big tower."
                });

            modelBuilder.Entity<PointsOfInterest>().HasData(
                new PointsOfInterest("Central Park")
                {
                    Id = 1,
                    CityId = 1,
                    Description = "The most visited urban park in the United States."
                },
                new PointsOfInterest("Empire State Building")
                {
                    Id = 2,
                    CityId = 1,
                    Description = "A 102-story skyscrapper located in Manhattan"
                },
                new PointsOfInterest("Cathedral of our lady")
                {
                    Id = 3,
                    CityId = 2,
                    Description = "A gothic style cathedral, conceived by architechts Jan and Piete" 
                },
                new PointsOfInterest("Antwerp")
                {
                    Id = 4,
                    CityId = 2,
                    Description = "The finest example of railway architecture in Belgium"
                },
                new PointsOfInterest("Eiffel Tower")
                {
                    Id = 5,
                    CityId = 3,    
                    Description = "An Iron lattice tower on the Champs de Mars" },
                new PointsOfInterest("The Louvre")
                {
                    Id = 6,
                    CityId = 3,
                    Description = "The world's largest museum"
                }
                );
            base.OnModelCreating(modelBuilder);
        }

        //protected override void onConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //  optionsBuilder.UseSqlite("Connectionstring");
        //base.onConfiguring(OptionsBuilder);
        //}

    }
}
