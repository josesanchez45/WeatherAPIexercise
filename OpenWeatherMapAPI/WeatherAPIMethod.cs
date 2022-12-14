using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace OpenWeatherMapAPI
{
    public class WeatherAPIMethod
    {
        public void WeatherApi()
        {
            var weatherClient = new HttpClient();

            var weatherApiKey = new WeatherAPIKey();
             var weatherApi = weatherApiKey.API();

            var weatherResponse = weatherClient.GetStringAsync(weatherApi).Result;

            var weatherobject = JObject.Parse(weatherResponse);
            Console.WriteLine("Current weather for:");
            Console.WriteLine($"City: {weatherobject["name"]}");
            Console.WriteLine($"Country: {weatherobject["sys"]["country"]}");
            Console.WriteLine($"Temperature: {weatherobject["main"]["temp"]}");
            Console.WriteLine($"Temp Max: {weatherobject["main"]["temp_max"]}, Temp Min: {weatherobject["main"]["temp_min"]}");
            

        }
        
    }
}
