using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WeatherMVVM.Model
{
    public class Data : WeatherBase
    {
        #region Private fields
        private double _temperature;
        private string _windDirection;
        private int _windVelocity;
        private int _humidity;
        private string _condition;
        private int _pressure;
        #endregion

        #region Public properties
        public double Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;
                OnPropertyChanged();
            }
        }
        public string WindDirection
        {
            get { return _windDirection; }
            set
            {
                _windDirection = value;
                OnPropertyChanged();
            }
        }
        public int WindVelocity
        {
            get { return _windVelocity; }
            set
            {
                _windVelocity = value;
                OnPropertyChanged();
            }
        }
        public int Humidity
        {
            get { return _humidity; }
            set
            {
                _humidity = value;
                OnPropertyChanged();
            }
        }
        public string Condition
        {
            get { return _condition; }
            set
            {
                _condition = value;
                OnPropertyChanged();
            }
        }
        public int Pressure
        {
            get { return _pressure; }
            set
            {
                _pressure = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }

    public class Weather : WeatherBase
    {
        #region Private fields
        private int _id;
        private string _name;
        private string _state;
        private string _country;
        private Data _data;
        #endregion

        #region Public properties
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                OnPropertyChanged();
            }
        }
        public string Country
        {
            get { return _country; }
            set
            {
                _country = value;
                OnPropertyChanged();
            }
        }
        public Data Data
        {
            get { return _data; }
            set
            {
                _data = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }

}
