using System;
using System.Collections.Generic;

namespace Lemonade_Stand{
    public class Day{
        public int minCustomers = 40;
        public int maxCustomers = 100;
        public int totalCustomers;

        public Customer customer = new Customer();
        public Weather weather = new Weather();

        public void CustomerGenerator(){
            Random customerGenerator = new Random();


            if(weather.currentWeather == "Sunny"){
                minCustomers += 25;
                maxCustomers += 30;
            } else if (weather.currentWeather == "Partly sunny/cloudy"){
                minCustomers += 15;
                maxCustomers += 20;
            } else if (weather.currentWeather == "Hazy") {
                minCustomers += 10;
                maxCustomers += 10;
            } else if (weather.currentWeather == "Cloudy") {
                minCustomers -= 5;
                maxCustomers -= 5;
            } else if (weather.currentWeather == "Rainy") {
                minCustomers -= 10;
                maxCustomers -= 15;
            }

            if(weather.currentTemprature == "Cold"){
                minCustomers -= 15;
                maxCustomers -= 25;
            } else if (weather.currentTemprature == "Mild"){
                minCustomers -= 10;
                maxCustomers -= 15;
            } else if(weather.currentTemprature == "Warm"){
                minCustomers += 15;
                maxCustomers += 15;
            } else if (weather.currentTemprature == "Hot"){
                minCustomers += 20;
                maxCustomers += 25;
            } else if (weather.currentTemprature == "Burning"){
                minCustomers += 25;
                maxCustomers += 35;
            }

            totalCustomers = customerGenerator.Next(minCustomers, maxCustomers);
            Console.WriteLine("Total Customers: " + totalCustomers);
            CustomerBuyChance();
        }

        //Generate the customers chance, equivalent to the number of customers generated
        public void CustomerBuyChance(){
            for (int i = 0; i < totalCustomers; i++){
                customer.CustomerChance();
                Console.WriteLine(customer.chances[i]);
            }
        }

        //Evaluate how many people will buy lemonade depending on weather
        public void Results(string temp, string weather){
            customer.WeatherChance(temp, weather);

            Console.WriteLine("Total buyers " + customer.buyer);
            Console.WriteLine("People who passed " + customer.pass);
        }
    }
}
