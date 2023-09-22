using CityInfo.API.Entities;

namespace CityInfo.API.Services

{
    public interface ICityInfoRepository
    {
        Task<IEnumerable<City>> GetCitiesAsync();

        Task<City?> GetCityAsync(int cityId, Boolean includePointOfInterest);

        Task<IEnumerable<PointsOfInterest>> GetPointOfInterestForCityAsync(int cityId);

        Task<PointsOfInterest> GetPointOfInterestForCityAsync(int cityId, int pointOfInterestId);
    }
}
