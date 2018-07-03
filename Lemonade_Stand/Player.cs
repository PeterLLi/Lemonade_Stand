using System;
using System.Collections.Generic;

namespace Lemonade_Stand{
    public class Player{
        public string playerName;
        public string priceInput;
        public string recipeChoice;
        public string userLemons;
        public string userSugar;
        public string userIce;
        public string userCups;
        public int lemonInput;
        public int sugarInput;
        public int iceInput;
        public int cupInput;
        public int updatedLemons;
        public int updatedSugar;
        public int updatedIce;
        public int updatedCups;
        public int menuOption;
        public int price;
        public double userMoney = 20;
        public List<string> playerRecipe = new List<string>();

        public void PlayerInfo(){
            if(playerName == null){
                Console.WriteLine("What is your name?");
                playerName = Console.ReadLine();
                PlayerInfo();
            }
        }

        public void Recipe(int lemons, int sugar, int ice, int cups){
            Console.WriteLine("");
            Console.WriteLine("You currently have");
            Console.WriteLine("Lemons: " + lemons);
            Console.WriteLine("Sugar: " + sugar);
            Console.WriteLine("Ice: " + ice);
            Console.WriteLine("Cups: " + cups);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("What would you like to put in?");
            Console.WriteLine("1. Lemons");
            Console.WriteLine("2. Sugar");
            Console.WriteLine("3. Ice");
            Console.WriteLine("4. Cups");
            Console.WriteLine("5. Main Menu");

            recipeChoice = Console.ReadLine();

            if(recipeChoice == ""){
                Console.WriteLine("Please input something!");
                Recipe(lemons, sugar, ice, cups);
            }

            if(recipeChoice != "1" && recipeChoice != "2" && recipeChoice != "3" && recipeChoice != "4" && recipeChoice != "5"){
                Console.WriteLine("Please input a valid number!");
                Recipe(lemons, sugar, ice, cups);
            }

            menuOption = Int32.Parse(recipeChoice);

            //Lemons
            if(menuOption == 1){
                do{
                    Console.WriteLine("How many lemons: ");
                    userLemons = Console.ReadLine();

                    while (userLemons == ""){
                        Console.WriteLine("Please input something!");
                        userLemons = Console.ReadLine();
                    }

                    lemonInput = Int32.Parse(userLemons);

                    if(lemonInput > lemons){
                        Console.WriteLine("You don't have enough lemons!");
                    }
                } while (lemonInput >= lemons);

                //Update lemons
                updatedLemons = lemons - lemonInput;
                Recipe(updatedLemons, sugar, ice, cups);

            //Sugar
            } else if (menuOption == 2){
                do{
                    Console.WriteLine("How much sugar: ");
                    userSugar = Console.ReadLine();

                    while (userSugar == ""){
                        Console.WriteLine("Please input something!");
                        userSugar = Console.ReadLine();
                    }

                    sugarInput = Int32.Parse(userSugar);

                    if (sugarInput > sugar){
                        Console.WriteLine("You don't have enough sugar!");
                    }
                } while (sugarInput >= sugar);

                //Update sugar
                updatedSugar = sugar - sugarInput;
                Recipe(lemons, updatedSugar, ice, cups);
            
            //Ice
            } else if (menuOption == 3) {
                do{
                    Console.WriteLine("How much ice: ");
                    userIce = Console.ReadLine();

                    while (userIce == ""){
                        Console.WriteLine("Please input something!");
                        userIce = Console.ReadLine();
                    }

                    iceInput = Int32.Parse(userIce);

                    if (iceInput > ice){
                        Console.WriteLine("You don't have enough ice!");
                    }
                } while (iceInput >= ice);

                //Update ice
                updatedIce = ice - iceInput;
                Recipe(lemons, sugar, updatedIce, cups);

            //Cups
            } else if (menuOption == 4) {
                do{
                    Console.WriteLine("How many cups: ");
                    userCups = Console.ReadLine();

                    while (userCups == ""){
                        Console.WriteLine("Please input something!");
                        userCups = Console.ReadLine();
                    }

                    cupInput = Int32.Parse(userCups);

                    if (cupInput > cups){
                        Console.WriteLine("You don't have enough cups!");
                    }
                } while (cupInput >= cups);

                //Update cups
                updatedCups = cups - cupInput;
                Recipe(lemons, sugar, ice, updatedCups);

            //Return to main menu
            } else if (menuOption == 5){
                Game game = new Game();
                game.NewInventory(updatedLemons, updatedSugar, updatedIce, updatedCups);
                game.RunGame();
            }
        }

        //Lets the user set the price
        public void Price(){
            bool valid = false;
            Console.WriteLine("What price would you like to set your lemonade at? (Between 5 and 95 cents)");
            priceInput = Console.ReadLine();

            //Verify that the user has inputted something
            if(priceInput == ""){
                Console.WriteLine("Please input something!");
                Price();
            }

            //Verify that user input is an integer
            while(valid == false){
                if (int.TryParse(priceInput, out price)){
                    valid = true;
                } else {
                    Console.WriteLine("Please enter a valid number!");
                    Console.WriteLine("Please enter a price between 5 and 95 cents.");
                    priceInput = Console.ReadLine();
                }
            }
        }
    }
}
