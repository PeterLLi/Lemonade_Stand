using System;
using System.Collections.Generic;

namespace Lemonade_Stand
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Stores the menu options
            string menuInput;
            int userMenuChoice = 0;
            List<string> menuOptions = new List<string>();

            //User interface and menu
            Console.WriteLine("Welcome to the lemonade stand.");
            menuOptions.Add("1. Game length");
            menuOptions.Add("2. Recipe");
            menuOptions.Add("3. Run game");

            //Day day = new Day();
            //day.CurrentDay();

            //Validation of user input
            do
            {
                Console.WriteLine("What would you like to do?");

                //Displays all menu options
                for (int i = 0; i < 3; i++){
                    Console.WriteLine(menuOptions[i]);
                }

                menuInput = Console.ReadLine();

                //Validation portion
                if (menuInput == ""){
                    Console.WriteLine("Please input something!");
                } else {
                    userMenuChoice = Int32.Parse(menuInput);
                }

                if (userMenuChoice != 1 && userMenuChoice != 2 && userMenuChoice != 3 && menuInput != ""){
                    Console.WriteLine("That's not a valid menu option!");
                }
            } while (menuInput != null && (userMenuChoice != 1 || userMenuChoice != 2 || userMenuChoice != 3));
        }
    }
}
