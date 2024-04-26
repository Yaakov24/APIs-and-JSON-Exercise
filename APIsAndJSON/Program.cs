using Newtonsoft.Json.Linq;
using RonVSKanyeAPI;
namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            for(var i = 0; i < 5; i++)
            {
                //QuoteGenarater.KanyeQuote();
                QuoteGenarater.RonQuote();
            }
           
                OpenWeatherMapAPI.WeatherMap();
            
               
            
        }
    }
}
