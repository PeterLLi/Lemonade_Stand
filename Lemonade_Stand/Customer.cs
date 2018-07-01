using System;
using System.Collections.Generic;

namespace Lemonade_Stand{
    public class Customer{
        public int chanceToBuy;
        public int buyer;
        public int pass;
        public List<int> chances = new List<int>();

        Random chance = new Random();
        Weather weather = new Weather();

        //Generate a random number for each person that is out
        public void CustomerChance(){
            chanceToBuy = chance.Next(1, 100);
            chances.Add(chanceToBuy);
        }

        //Chance a customer will buy lemonade based on weather
        public void WeatherChance(string temp, string weather){
            Console.WriteLine(temp);
            Console.WriteLine(weather);

            //Check to see if each persons demand is within the group
            for (int i = 0; i < chances.Count; i++){
                //Sunny weather
                if(weather == "Sunny" && temp == "Cold"){
                    if(chances[i] > 25 && chances[i] < 75){
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Sunny" && temp == "Mild") {
                    if (chances[i] > 20 && chances[i] < 80){
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Sunny" && temp == "Warm") {
                    if (chances[i] > 15 && chances[i] < 85) {
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Sunny" && temp == "Hot") {
                    if (chances[i] > 10 && chances[i] < 90) {
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Sunny" && temp == "Burning") {
                    if (chances[i] > 5 && chances[i] < 95) {
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                }

                //Partly sunny/cloudy
                if (weather == "Partly sunny/cloudy" && temp == "Cold"){
                    if (chances[i] > 25 && chances[i] < 75){
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Partly sunny/cloudy" && temp == "Mild") {
                    if (chances[i] > 20 && chances[i] < 80){
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Partly sunny/cloudy" && temp == "Warm") {
                    if (chances[i] > 15 && chances[i] < 85) {
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Partly sunny/cloudy" && temp == "Hot") {
                    if (chances[i] > 10 && chances[i] < 90) {
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Partly sunny/cloudy" && temp == "Burning") {
                    if (chances[i] > 5 && chances[i] < 95) {
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                }

                //Hazy weather
                if (weather == "Hazy" && temp == "Cold"){
                    if (chances[i] > 25 && chances[i] < 75){
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Hazy" && temp == "Mild") {
                    if (chances[i] > 20 && chances[i] < 80){
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Hazy" && temp == "Warm") {
                    if (chances[i] > 15 && chances[i] < 85){
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Hazy" && temp == "Hot") {
                    if (chances[i] > 10 && chances[i] < 90){
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Hazy" && temp == "Burning") {
                    if (chances[i] > 5 && chances[i] < 95) {
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                }

                //Cloudy weather
                if (weather == "Cloudy" && temp == "Cold"){
                    if (chances[i] > 25 && chances[i] < 75){
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Cloudy" && temp == "Mild") {
                    if (chances[i] > 20 && chances[i] < 80) {
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Cloudy" && temp == "Warm") {
                    if (chances[i] > 15 && chances[i] < 85){
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Cloudy" && temp == "Hot") {
                    if (chances[i] > 10 && chances[i] < 90){
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Cloudy" && temp == "Burning") {
                    if (chances[i] > 5 && chances[i] < 95) {
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                }

                //Rainy weather
                if (weather == "Rainy" && temp == "Cold"){
                    if (chances[i] > 25 && chances[i] < 75){
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Rainy" && temp == "Mild") {
                    if (chances[i] > 20 && chances[i] < 80){
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Rainy" && temp == "Warm") {
                    if (chances[i] > 15 && chances[i] < 85){
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Rainy" && temp == "Hot") {
                    if (chances[i] > 10 && chances[i] < 90) {
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                } else if (weather == "Rainy" && temp == "Burning") {
                    if (chances[i] > 5 && chances[i] < 95){
                        buyer += 1;
                    } else {
                        pass += 1;
                    }
                }     
            }
        }
    }
}