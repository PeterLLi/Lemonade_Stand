using System;

namespace Lemonade_Stand{
    public class Weather{
        public int weatherDemand;
        public int weatherNumber;
        public int currentTemp;
        public int tempDemand;
        public string currentWeather;

        public void SetWeather(){
            Random weatherNum = new Random();
            weatherNumber = weatherNum.Next(1, 5);

            if(weatherNumber == 5){
                currentWeather = "Sunny";
                weatherDemand = 60;
            } if (weatherNumber == 4){
                currentWeather = "Partly sunny/cloudy";
                weatherDemand = 50;
            } else if (weatherNumber == 3){
                currentWeather = "Cloudy";
                weatherDemand = 40;
            } else if (weatherNumber == 2){
                currentWeather = "Hazy";
                weatherDemand = 30;
            } else if (weatherNumber == 1){
                currentWeather = "Rainy";
                weatherDemand = 20;
            }
        }

        public void setTemp(){
            Random temp = new Random();
            currentTemp = temp.Next(50, 100);
            if (currentTemp > 50 && currentTemp < 60){
                tempDemand = 20;
            } else if (currentTemp > 60 && currentTemp < 70){
                tempDemand = 30;
            } else if (currentTemp > 70 && currentTemp < 80){
                tempDemand = 40;
            } else if (currentTemp > 80 && currentTemp < 90){
                tempDemand = 50;
            } else if (currentTemp > 90 && currentTemp < 100){
                tempDemand = 60;
            }
        }
    }
}