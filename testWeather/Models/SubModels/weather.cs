﻿using System;
using System.Collections.Generic;
using System.Text;

namespace testWeather.Models.SubModels
{
    class weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
