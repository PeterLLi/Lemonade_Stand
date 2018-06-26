using System;
namespace Lemonade_Stand
{
    public class Day
    {
        public int demand;
        public int currentWeatherNumber;

        public Day()
        {
            Weather weather = new Weather();
            weather.SetWeather();

            Customer customer = new Customer();
            customer.CustomerGenerator();

            currentWeatherNumber = weather.weatherNumber;
            Console.WriteLine(currentWeatherNumber);
        }
    }
}
