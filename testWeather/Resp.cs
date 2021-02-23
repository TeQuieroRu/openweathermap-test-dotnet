using System;
using System.Collections.Generic;
using System.Text;
using testWeather.Models;
using testWeather.Models.SubModels;

namespace testWeather
{
    class Resp
    {
        public City City { get; set; }
        public int Cod { get; set; }
        public double Message { get; set; }
        public int Cnt { get; set; }
        public IList<List> List { get; set; }
    }
}
