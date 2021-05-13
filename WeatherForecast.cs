using System;

namespace TodoApi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TempCelcius { get; set; }

        public int TempFahrenheit => 32 + (int)(TemperatureC / 0.5556);

        public string Tempsummary { get; set; }
    }
}
