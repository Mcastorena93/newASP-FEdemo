﻿using CityInfo.API.Entities;

namespace CityInfo.API.Services

{
    public interface ICityInfoRepository
    {
        Task<IEnumerable<City>> GetCitiesAsync();

        Task<City?> GetCityAsync(int cityId, bool includePointOfInterest);

        Task<bool> CityExistsAsync(int cityId);

        Task<PointOfInterest> GetPointOfInterestForCityAsync(int cityId, int pointOfInterestId);

        Task<IEnumerable<PointOfInterest>> GetPointsOfInterestForCityAsync(int cityId);

        Task AddPointOfInterestForCityAsync(int cityId, PointOfInterest pointOfInterest);

        Task<bool>  SaveChangesAsync();
    }
}
