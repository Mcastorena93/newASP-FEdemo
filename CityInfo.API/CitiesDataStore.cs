using CityInfo.API.Controllers;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; set; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with the big park",
                    PointsOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States" },
                        new PointOfInterestDto()
                        {
                            Id= 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscrapper located in Manhattan"},

                    }
                },
                new CityDto()
                { 
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never finished",
                    PointsOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Cathedral of our lady",
                            Description = "A gothic style cathedral, conceived by architechts Jan and Piete" },
                        new PointOfInterestDto()
                        {
                            Id= 4,
                            Name = "Antwerp",
                            Description = "The finest example of railway architecture in Belgium"},

                    }

                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower",
                    PointsOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Eiffel Tower",
                            Description = "An Iron lattice tower on the Champs de Mars" },
                        new PointOfInterestDto()
                        {
                            Id= 4,
                            Name = "The Louvre",
                            Description = "The world's largest museum"
                        },
                    }
                }
            };
        }
    }
}
