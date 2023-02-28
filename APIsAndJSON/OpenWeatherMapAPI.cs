using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void FindCurrentWeather()
        {
            var client = new HttpClient();

            Console.WriteLine("Please enter the key:");
            string key = Console.ReadLine();
            bool condition = true;

            while (condition == true)
            {
                Console.WriteLine();
                Console.WriteLine( "Please enter the city name:");
                string cityName = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine( "Please enter the country code:");
                string countryCode = Console.ReadLine().ToLower();
                Console.WriteLine();

                var url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName},{countryCode}&units=imperial&appid={key}";

                var weatherResponse = client.GetStringAsync(url).Result;

                string prettyResponse = JObject.Parse(weatherResponse).GetValue("main").ToString();

                Console.WriteLine($"{prettyResponse}\n");

                Console.WriteLine("Would you like to look up another location? (Type \"yes\" or \"no\")");
                string yesNo = Console.ReadLine();
                if ( yesNo == "no")
                {
                    Console.WriteLine("\nHave a nice day!");
                    break;
                }
            }

        }
    }
}
