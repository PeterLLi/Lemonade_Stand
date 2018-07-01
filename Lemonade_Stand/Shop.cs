using System;
using System.Collections.Generic;

namespace Lemonade_Stand{
    public class Shop
    {
        public string menuChoice;
        public int shopChoice;
        public string lemonAmount;
        public string sugarAmount;
        public string iceAmount;
        public string cupsAmount;
        public int lemons;
        public int sugar;
        public int ice;
        public int cups;
        public int totalLemons;
        public int totalSugar;
        public int totalIce;
        public int totalCups;
        Game game = new Game();

        public List<string> options = new List<string>();

        public void BuyItems(){
            //Populate the list containing the menu
            options.Add("1. Lemons (10 cents)");
            options.Add("2. Sugar (10 cents");
            options.Add("3. Ice (1 cents)");
            options.Add("4. Cups(5 cents)");
            options.Add("5. Back to main menu");

            Console.WriteLine("You have $" + game.userMoney + " left");

            //Get user input
            Console.WriteLine("What would you like to buy?");
            menuChoice = Console.ReadLine();

            //Display menu options
            for (int i = 0; i < options.Count; i++){
                Console.WriteLine(options[i]);
            }

            //Check if user has inputted something
            if(menuChoice == ""){
                Console.WriteLine("Please input something!");
                Console.WriteLine("");
                BuyItems();
            }

            //Check if the user inputted a menu option
            if(menuChoice != "1" && menuChoice != "2" && menuChoice != "3" && menuChoice != "4" && menuChoice != "5"){
                Console.WriteLine("Please enter a valid menu option!");
                BuyItems();
            } else {
                //Parse menu 
                shopChoice = Int32.Parse(menuChoice);
            }

            //Lemon count
            if(shopChoice == 1){
                Console.WriteLine("How many lemons would you like to buy?");
                lemonAmount = Console.ReadLine();

                //Checks to see if the user inputted anything
                do{
                    Console.WriteLine("Please input something!");
                    lemonAmount = Console.ReadLine();
                } while (lemonAmount == "");

                lemons = Int32.Parse(lemonAmount);
                totalLemons += lemons;
            }
        }
    }
}