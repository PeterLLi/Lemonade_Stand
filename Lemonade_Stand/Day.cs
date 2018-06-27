using System;
namespace Lemonade_Stand{
    public class Day{
        public int totalDemand;
        public Weather weather = new Weather();
        public Customer customer = new Customer();

        public void CurrentDay(){
            //Weather
            //weather.SetWeather();

            //Customers and demand
            customer.CustomerGenerator();

            //Set weather int to a int variable in this class
            //currentWeatherNumber = weather.weatherNumber;

            //Console.WriteLine(currentWeather);
        }
    }
}
