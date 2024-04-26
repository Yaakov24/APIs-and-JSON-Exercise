using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    { 
        public static void WeatherMap()
        {
            var client = new HttpClient();
            var apiKeyObj = File.ReadAllText("appsettings.json");
            var apiKey = JObject.Parse(apiKeyObj).GetValue("apiKey").ToString();
            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?zip=33162,us&appid={apiKey}&units=imperial";
            var weatherForecast = client.GetStringAsync(weatherURL).Result;
            var weatherQuote = JObject.Parse(weatherForecast);
            var currentTemperature = weatherQuote["main"]["temp"].ToString();
            var city = weatherQuote["name"];
            var description = weatherQuote["weather"][0]["description"];
            Console.WriteLine("-------");
            Console.WriteLine($"Temprature in {city} is: {currentTemperature} with {description}");
        }
    }
}
/*{
  "coord": {
    "lon": -80.183,
    "lat": 25.9286
  },
  "weather": [
    {
      "id": 802,
      "main": "Clouds",
      "description": "scattered clouds",
      "icon": "03d"
    }
  ],
  "base": "stations",
  "main": {
    "temp": 80.65,
    "feels_like": 81.63,
    "temp_min": 77.99,
    "temp_max": 82.98,
    "pressure": 1019,
    "humidity": 52
  },
  "visibility": 10000,
  "wind": {
    "speed": 18.41,
    "deg": 70,
    "gust": 25.32
  },
  "clouds": {
    "all": 40
  },
  "dt": 1714164209,
  "sys": {
    "type": 2,
    "id": 2037247,
    "country": "US",
    "sunrise": 1714128431,
    "sunset": 1714175364
  },
  "timezone": -14400,
  "id": 0,
  "name": "Miami",
  "cod": 200
}*/