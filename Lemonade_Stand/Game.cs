using System;
using System.Collections.Generic;

//Main game functions such as menus and 
namespace Lemonade_Stand{
    public class Game{
        public string menuInput;
        public string gameMenuInput;
        public int userMenuChoice = 0;
        public int gameMenuChoice = 0;
        public double userMoney = 20.00;

        Player player = new Player();
        Time time = new Time();
        Day day = new Day();

        //First menu - selection of game length
        public void PlayGame(){
            //Stores the menu options
            List<string> menuOptions = new List<string>();

            //User interface and menu
            Console.WriteLine("Welcome to the lemonade stand.");
            player.PlayerInfo();
            menuOptions.Add("1. Game length");
            menuOptions.Add("2. Play game");
            Console.WriteLine("You have $" + userMoney + " to spend");
            Console.WriteLine("");

            //User input with validation
            do{
                Console.WriteLine("What would you like to do?");

                //Displays all menu options
                for (int i = 0; i < 2; i++){
                    Console.WriteLine(menuOptions[i]);
                }

                //Reads the users input
                menuInput = Console.ReadLine();

                //Validation whether the user entered anything and then validate they entered 1, 2 or 3
                if (menuInput == ""){
                    Console.WriteLine("\n" + "Please input something!");
                } else if (menuInput != "1" && menuInput != "2" && menuInput != ""){
                    Console.WriteLine("\n" + "That's not a valid menu option!");
                } else {
                    userMenuChoice = Int32.Parse(menuInput);
                }
            } while (menuInput != null && (userMenuChoice != 1 && userMenuChoice != 2));
        }

        //Second menu - when user hits run game - displays the shop and recipe for the game
        public void RunGame(string temp, string weather){
            List<string> gameMenu = new List<string>();

            //Populate secondary menu items
            gameMenu.Add("1. Shop");
            gameMenu.Add("2. Recipe");
            gameMenu.Add("3. Price");
            gameMenu.Add("4. Continue");
            gameMenu.Add("5. Exit");

            //Validate user input
            do{
                Console.WriteLine("");

                //Display menu options
                for (int i = 0; i < gameMenu.Count; i++){
                    Console.WriteLine(gameMenu[i]);
                }

                Console.WriteLine("What would you like to do?");
                gameMenuInput = Console.ReadLine();

                if(gameMenuInput == ""){
                    Console.WriteLine("You need to input something!");
                } else if (gameMenuInput != "1" && gameMenuInput != "2" && gameMenuInput != "3" && gameMenuInput != "4"){
                    Console.WriteLine("You need to input a valid option!");
                } else {
                    gameMenuChoice = Int32.Parse(gameMenuInput);
                }
            } while (gameMenuInput != null && (gameMenuInput != "1" && gameMenuInput != "2" && gameMenuInput != "3" && gameMenuInput != "4"));

            //Menu options
            if(gameMenuChoice == 1){
                day.CustomerGenerator();
                day.Results(temp, weather);
                RunGame(temp, weather);
            }
            if(gameMenuChoice == 3){
                player.Price();
                RunGame(temp, weather);
            }
        }
    }
}
