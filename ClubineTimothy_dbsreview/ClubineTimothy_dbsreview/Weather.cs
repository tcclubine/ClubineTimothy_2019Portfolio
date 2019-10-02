using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothy_dbsreview
{
    class Weather
    {
        private string _cityName;
        private string _temp;
        private string _pressure;
        private string _humidity;

        public string CityName { get { return _cityName; } set { _cityName = value; } }
        public string Temp { get { return _temp; } set { _temp = value; } }
        public string Pressure { get { return _pressure; } set { _pressure = value; } }
        public string Humidity { get { return _humidity; } set { _humidity = value; } }

        public Weather()
        {
            _cityName = null;
            _temp = null;
            _pressure = null;
            _humidity = null;
        }
    }
}
