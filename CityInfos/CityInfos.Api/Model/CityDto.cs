using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfos.Api.Model
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int numberOfPointsOfInterest { get
            {
                return PointsOfInterest.Count;
            }
        }

        public ICollection<PointOfInterestDto> PointsOfInterest { get; set; }
        = new List<PointOfInterestDto>();

        ////public CityDto(int id , string Name)
        ////{
        ////    this.Id = id;
        ////    this.Name = Name;
        ////}
    }
}
