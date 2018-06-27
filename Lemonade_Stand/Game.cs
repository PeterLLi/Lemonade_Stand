using System;
using System.Collections.Generic;

namespace Lemonade_Stand{
    public class Game{
        public string menuInput;
        public int userMenuChoice = 0;

        public void PlayGame(){
            //Stores the menu options

            List<string> menuOptions = new List<string>();

            //User interface and menu
            Console.WriteLine("Welcome to the lemonade stand.");
            menuOptions.Add("1. Game length");
            menuOptions.Add("2. Recipe");
            menuOptions.Add("3. Run game");

            //Get weather
            Day day = new Day();
            day.weather.SetWeather();

            Console.WriteLine("Current weather is " + day.weather.currentWeather);

            //Validation of user input
            do{
                Console.WriteLine("What would you like to do?");

                //Displays all menu options
                for (int i = 0; i < 3; i++){
                    Console.WriteLine(menuOptions[i]);
                }

                menuInput = Console.ReadLine();

                //Validation whether the user entered anything and then validate they entered 1, 2 or 3
                if (menuInput == ""){
                    Console.WriteLine("\n" + "Please input something!");
                } else if (menuInput != "1" && menuInput != "2" && menuInput != "3" && menuInput != "")
                {
                    Console.WriteLine("\n" + "That's not a valid menu option!");
                } else {
                    userMenuChoice = Int32.Parse(menuInput);
                }
            } while (menuInput != null && (userMenuChoice != 1 && userMenuChoice != 2 && userMenuChoice != 3));
        }
    }
}
