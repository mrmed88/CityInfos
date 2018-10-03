using CityInfos.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfos.Api
{
    public class CitiesDataStore
    {
        ////List<PointOfInterestDto> pointTunis = new List<PointOfInterestDto>()
        ////        {
        ////            new PointOfInterestDto()
        ////            {
        ////                Id = 1,
        ////                Name = "Linedata",
        ////                Description = "WOOOOOORK"
        ////            }
        ////        };
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>() {
            new CityDto()
            {
                Id = 1,
                Name = "Tunis",
                Description = "Working",
                PointsOfInterest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 1,
                        Name = "Linedata",
                        Description = "WOOOOOORK"
                    },
                    new PointOfInterestDto()
                    {
                        Id =2,
                        Name = "Ariena",
                        Description = "SLEEEP"
                    }

                }
            },
            new CityDto()
            {
                Id = 2,
                Name = "Sfax",
                Description = "Home"
            },
            new CityDto()
            {
                Id = 3,
                Name = "Mednnine",
                Description = "Love",
                PointsOfInterest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 1,
                        Name = "Sabrine",
                        Description = "LOOOOVE"
                    }
                }
            }
        };
        }
        ////new CityDto(1,"Tunis"),
        ////  new CityDto(2,"Sfax"),
        ////new CityDto(3,"Mednine") };

    };
}
