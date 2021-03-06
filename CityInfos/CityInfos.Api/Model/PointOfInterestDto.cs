﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfos.Api.Model
{
    public class PointOfInterestDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class PointOfInterestCreationDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

}
