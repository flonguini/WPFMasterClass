using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherMVVM.Model;

namespace WeatherMVVM
{
    public class WeatherViewModel
    {
        public const string API_KEY = "42e2e4db0db214874223d3d73da630e3";
        public const string BASE_URL = "http://apiadvisor.climatempo.com.br/api/v1/weather/locale/3477/current?token={0}&id={1}";

        public async Weather GetWeatherInformation(string cityName)
        {
            var result = new Weather();

            string url = string.Format(BASE_URL, API_KEY, cityName);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();
            }

            return result;
        }
    }
}
