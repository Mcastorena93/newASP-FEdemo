﻿using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase

    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }
    }
}
