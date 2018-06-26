using System;
namespace Lemonade_Stand
{
    public class Day
    {
        public int weatherDemand;
        public int tempDemand;
        public int totalDemand;
        public int currentWeatherNumber;

        public void CurrentDay()
        {
            //Weather
            Weather weather = new Weather();
            weather.SetWeather();

            //Customers and demand
            Customer customer = new Customer();
            customer.CustomerGenerator();

            //Set weather int to a int variable in this class
            currentWeatherNumber = weather.weatherNumber;
            Console.WriteLine(currentWeatherNumber);
        }
    }
}
