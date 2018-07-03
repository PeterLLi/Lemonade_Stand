using System;
using System.Collections.Generic;

//Main game functions such as menus and 
namespace Lemonade_Stand{
    public class Game{
        public string menuInput;
        public string gameMenuInput;
        public int userMenuChoice;
        public int gameMenuChoice;
        public int lemonCount;
        public int sugarCount;
        public int iceCount;
        public int cupCount;
        public int allLemons;
        public int allSugar;
        public int allIce;
        public int allCups;
        public int lemons2;
        public int sugar2;
        public int ice2;
        public int cups2;
        public int price;
        public int profits;
        public int currentDay;
        public double money;
        public List<string> menuOptions = new List<string>(); //Stores the menu options

        //Other classes
        Player player = new Player();
        Time time = new Time();
        Day day = new Day();

        Customer customer = new Customer();

        //First menu - selection of game length
        public void PlayGame(){
            //User interface and first menu
            Console.WriteLine("Welcome to the lemonade stand.");
            player.PlayerInfo();
            menuOptions.Add("1. Game length");
            menuOptions.Add("2. Play game");
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
                money = player.userMoney;
            } while (menuInput != null && (userMenuChoice != 1 && userMenuChoice != 2));
        }

        //Second menu - when user hits run game - displays the shop and recipe for the game
        public void RunGame(){
            //Validate user input
            do{
                Console.WriteLine("");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Shop");
                Console.WriteLine("2. Recipe");
                Console.WriteLine("3. Price");
                Console.WriteLine("4. Continue");
                Console.WriteLine("5. Exit");

                Console.WriteLine("What would you like to do?");
                gameMenuInput = Console.ReadLine();
                Console.WriteLine("");

                if(gameMenuInput == ""){
                    Console.WriteLine("You need to input something!");
                } else if (gameMenuInput != "1" && gameMenuInput != "2" && gameMenuInput != "3" && gameMenuInput != "4"){
                    Console.WriteLine("You need to input a valid option!");
                } else {
                    gameMenuChoice = Int32.Parse(gameMenuInput);
                }
            } while (gameMenuInput != null && (gameMenuInput != "1" && gameMenuInput != "2" && gameMenuInput != "3" && gameMenuInput != "4" && gameMenuInput != "5"));

            //Menu options
            if(gameMenuChoice == 1){
                Shop shop = new Shop();
                UsersMoney(money);
                shop.BuyItems(money);
            }
            if(gameMenuChoice == 2){
                player.Recipe(allLemons, allSugar, allIce, allCups);
            }
            if(gameMenuChoice == 3){
                player.Price();
            }
            if(gameMenuChoice == 4){
                for (int i = 0; i < time.userTime; i++){
                    currentDay = i;
                    Console.WriteLine("Current Day: " + time.userTime);
                    day.CustomerGenerator();
                    day.Results();
                    Profit();
                }
            }
            if(gameMenuChoice == 5){
                Console.WriteLine("Thanks for playing");
            }
        }

        //Get players inventory after the store
        public void GetInventory(int lemons, int sugar, int ice, int cups){
            lemonCount = lemons;
            sugarCount = sugar;
            iceCount = ice;
            cupCount = cups;
            Console.WriteLine("Lemon " + lemonCount);
            Console.WriteLine("Sugar " + sugarCount);
            Console.WriteLine("Ice " + iceCount);
            Console.WriteLine("Cup " + cupCount);
            CombineInventory();
        }

        //Get players inventory after recipe
        public void NewInventory(int updatedLemons, int updatedSugar, int updatedIce, int updatedCups){
            lemons2 = updatedLemons;
            sugar2 = updatedSugar;
            ice2 = updatedIce;
            cups2 = updatedCups;
        }

        //Combine the inventory from the remaining e
        public void CombineInventory(){
            allLemons = lemonCount + lemons2;
            allSugar = sugarCount + sugar2;
            allIce = iceCount + ice2;
            allCups = cupCount + cups2;

        }

        public void Profit(){
            price = player.price;
            profits = customer.buyer * price;
            Console.WriteLine("You made " + profits);
        }

        public void UsersMoney(double wallet){
            money = wallet;
        }
    }
}
