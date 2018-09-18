using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfos.Api.Model
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public City(int id , string Name)
        {
            this.Id = id;
            this.Name = Name;
        }
    }
}
