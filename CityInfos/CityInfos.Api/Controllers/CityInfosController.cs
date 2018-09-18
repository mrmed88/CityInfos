using CityInfos.Api.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CityInfos.Api.Controllers
{
    /* new List<City>() {
                new {id = 1 , Name = "Sfax"},
                new {id = 2 , Name = "Tunis"},
                new {id = 3 , Name = "Mednine"}
            } */
            



    [Route("api/cities")]
    public class CityInfosController : Controller
    {

        [HttpGet()]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public JsonResult GetCities(int id)
        {
            return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));
        }

    }
}
