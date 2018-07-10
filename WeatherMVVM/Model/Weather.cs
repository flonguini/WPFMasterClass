using System.Collections.Generic;

namespace WeatherMVVM.Model
{
    public class Data
    {
        public double Temperature { get; set; }
        public string WindDirection { get; set; }
        public int WindVelocity { get; set; }
        public int Humidity { get; set; }
        public string Condition { get; set; }
        public int Pressure { get; set; }
        public string Icon { get; set; }
        public int Sensation { get; set; }
        public string Date { get; set; }
    }

    public class Weather
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Data Data { get; set; }
    }

}
