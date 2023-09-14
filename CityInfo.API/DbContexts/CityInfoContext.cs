using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;

        public DbSet<PointOfInterest> PointOfInterests { get; set; } = null!;

        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        {

        }

        //protected override void onConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
          //  optionsBuilder.UseSqlite("Connectionstring");
            //base.onConfiguring(OptionsBuilder);
        //}

    }
}
