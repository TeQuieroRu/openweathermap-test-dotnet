using System;
using System.Collections.Generic;
using testWeather.Models.SubModels;

namespace testWeather.Models
{
    class List
    {
        public long Dt { get; set; }
        public Temp Temp { get; set; }
        public feels_like Feels_Like { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public weather[] Weather { get; set; } // Супер-мега костыль
        public double Speed { get; set; }
        public int Deg { get; set; }
        public int Clouds { get; set; }
        public double Pop { get; set; }
        public double Snow { get; set; }
    }
}
