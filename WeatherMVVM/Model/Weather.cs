using System.Collections.Generic;
using System.ComponentModel;

namespace WeatherMVVM.Model
{
    public class Data : INotifyPropertyChanged
    {
        public double Temperature { get; set; }
        public string WindDirection { get; set; }
        public int WindVelocity { get; set; }
        public int Humidity { get; set; }
        public string Condition { get; set; }
        public int Pressure { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName))
            }
        }
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
