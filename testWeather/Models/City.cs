using System;
using System.Collections.Generic;
using System.Text;
using testWeather.Models.SubModels;

namespace testWeather.Models
{
    class City
    {
        public int Id { get; set; }
        public Coord coord { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
    }
}
