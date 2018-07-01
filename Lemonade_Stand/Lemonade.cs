using System;

namespace Lemonade_Stand{
    class MainClass{
        public static void Main(string[] args){
            string theWeather;
            string temp;
            string weather;
            int gameDuration = 0;

            Game game = new Game();
            Time time = new Time();
            Shop shop = new Shop();
            Player player = new Player();

            //Get weather
            Day day = new Day();
            day.weather.SetWeather();
            day.weather.SetTemp();

            //Set the weather to variables
            temp = day.weather.currentTemprature;
            weather = day.weather.currentWeather;

            //Display current weather
            theWeather = "The weather is currently " + day.weather.currentWeather + " and " + day.weather.tempratureNumber + " degrees";
            Console.WriteLine(theWeather);


            //Seperator
            Console.WriteLine("");

            //Start the game with validation
            do{
                game.PlayGame();

                //Make sure user inputted a game length before playing the game
                if (time.userTime == 0 && game.userMenuChoice == 2){
                    Console.WriteLine("Please input a time to continue!");
                    Console.WriteLine("");
                    game.PlayGame();
                }

                //Gets the user to set a time duration
                if(game.userMenuChoice == 1){
                    time.ChooseTime();
                    gameDuration = time.userTime;

                    Console.WriteLine("The length of the game has been set to: " + gameDuration);
                    Console.WriteLine("");
                } else if (game.userMenuChoice == 2) {
                    game.RunGame(temp, weather);
                }
            } while (game.userMenuChoice != 3);

            game.RunGame(temp, weather);
        }
    }
}
