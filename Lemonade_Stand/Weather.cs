using System;
namespace Lemonade_Stand{
    public class Weather{
        public int weatherNumber;
        public int currentTemp;
        public int tempratureNumber;
        public string currentWeather;
        public string currentTemprature;

        public void SetWeather(){
            //Generate a number between 1 and 5
            Random weatherNum = new Random();
            weatherNumber = weatherNum.Next(1, 5);

            //Assign a weather to each number
            if (weatherNumber == 5){
                currentWeather = "Sunny";
            } else if (weatherNumber == 4){
                currentWeather = "Partly sunny/cloudy";
            } else if (weatherNumber == 3) {
                currentWeather = "Hazy";
            } else if (weatherNumber == 2) {
                currentWeather = "Cloudy";
            } else if (weatherNumber == 1) {
                currentWeather = "Rainy";
            }
        }

        public void SetTemp(){
            //Generate a number between 50 and 100
            Random tempGen = new Random();
            currentTemp = tempGen.Next(50, 100);

            //Assign a description to each temprature bracket
            if (currentTemp > 50 && currentTemp < 60){
                currentTemprature = "Cold";
                tempratureNumber = currentTemp;
            } else if (currentTemp > 60 && currentTemp < 70){
                currentTemprature = "Mild";
                tempratureNumber = currentTemp;
            } else if (currentTemp > 70 && currentTemp < 80){
                currentTemprature = "Warm";
                tempratureNumber = currentTemp;
            } else if (currentTemp > 80 && currentTemp < 90){
                currentTemprature = "Hot";
                tempratureNumber = currentTemp;
            } else if (currentTemp > 90 && currentTemp < 100){
                currentTemprature = "Burning";
                tempratureNumber = currentTemp;
            }

        }
    }
}
