﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class WeatherWorker
    {
        // List of objects used to get and set properties from the weather class
        public static List<Weather> weathersList = new List<Weather>();
        // List of objects used to retrieve the range of a weather
        public static List<Weather> filtered;
    }
}