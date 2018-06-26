using System;
namespace Lemonade_Stand
{
    public class Weather
    {
        public string currentWeather;
        public int weatherNumber;

        public void SetWeather()
        {
            Random rng = new Random();
            weatherNumber = rng.Next(1, 5);

            if(weatherNumber == 5){
                currentWeather = "Sunny";
            }else if(weatherNumber == 4){
                currentWeather = "Partly sunny/cloudy";
            }else if(weatherNumber == 3){
                currentWeather = "Cloudy";
            }else if(weatherNumber == 2){
                currentWeather = "Hazy";
            }else if(weatherNumber == 1){
                currentWeather = "Rainy";
            }
        }
    }
}