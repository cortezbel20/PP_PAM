using System;
using System.Collections.Generic;
using System.Text;

namespace TempoPrevisao_PP.Models
{
    using System.Collections.Generic;

    public class WeatherApiResponse
    {
        public Current current { get; set; }
        public Forecast forecast { get; set; }

    }

    public class Current
    {
        public double temp { get; set; }
        public Condition condition { get; set; }
    }

    public class Forecast
    {
        public List<ForecastDay> forecastday { get; set; }
    }

    public class ForecastDay
    {
        public Day day { get; set; }
    }

    public class Day
    {
        public double maxtemp { get; set; }
        public double mintemp { get; set; }
        public Condition condition { get; set; }
    }

    public class Condition
    {
        public string text { get; set; }
        public string icon { get; set; }
    }

}