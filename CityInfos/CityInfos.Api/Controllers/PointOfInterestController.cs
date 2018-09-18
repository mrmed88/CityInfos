using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfos.Api.Controllers
{
    [Route("api/Cities")]
    public class PointOfInterestController : Controller
    {
        [HttpGet("{cityId}/POI")]
        public IActionResult GetPOIs(int cityId)
        {

            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
                return NotFound();
            else
            {
                return Ok(city.PointsOfInterest);
            }
        }
        ////[HttpGet("{id}")]
        ////public JsonResult GetPOI(int id)
        ////{
        ////    return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id).PointsOfInterest);
        ////}
        [HttpGet("{cityId}/POI/{PoiId}")]
        public IActionResult GetPOI(int cityId, int PoiId)
        {

            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
                return NotFound();


                var poi = city.PointsOfInterest.FirstOrDefault(p => p.Id == PoiId);
                if(poi == null)
            {
                return NotFound();
            }

            return Ok(city.PointsOfInterest.FirstOrDefault(p => p.Id == PoiId));
        }
    }



}
