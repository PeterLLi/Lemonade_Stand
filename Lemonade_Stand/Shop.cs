using System;
using System.Collections.Generic;

namespace Lemonade_Stand{
    public class Shop{
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
        public double money;

        //Main shop method
        public void BuyItems(double usersMoney){
            money = usersMoney;
            Console.WriteLine(usersMoney);
            Console.WriteLine("You have $" + usersMoney + " left");

            //Get user input
            Console.WriteLine("What would you like to buy?");
            Console.WriteLine("1. Lemons");
            Console.WriteLine("2. Sugar");
            Console.WriteLine("3. Ice");
            Console.WriteLine("4. Cups");
            Console.WriteLine("5. Main Menu");

            Console.WriteLine("");

            menuChoice = Console.ReadLine();

            //Check if user has inputted something
            if(menuChoice == ""){
                Console.WriteLine("Please input something!");
                Console.WriteLine("");
                BuyItems(usersMoney);
            }

            //Check if the user inputted a menu option
            if(menuChoice != "1" && menuChoice != "2" && menuChoice != "3" && menuChoice != "4" && menuChoice != "5"){
                Console.WriteLine("Please enter a valid menu option!");
                Console.WriteLine("");
                BuyItems(usersMoney);
            } else {
                //Parse menu 
                shopChoice = Int32.Parse(menuChoice);
            }

            if(shopChoice == 1){
                BuyLemons();
            } else if(shopChoice == 2){
                BuySugar();
            } else if (shopChoice == 3){
                BuyIce();
            } else if (shopChoice == 4){
                BuyCups();
            } else if (shopChoice == 5){
                Game game = new Game();
                game.UsersMoney(money);
                game.GetInventory(totalLemons, totalSugar, totalIce, totalCups);
                game.RunGame();
            }
        }

        //Buy lemons
        public void BuyLemons(){
            Console.WriteLine("How many lemons would you like to buy?");
            Console.WriteLine("1. 10 for $2");
            Console.WriteLine("2. 50 for $5");
            Console.WriteLine("3. 100 for $8");
            Console.WriteLine("4. Exit");
            lemonAmount = Console.ReadLine();

            //Checks to see if the user inputted anything
            if(lemonAmount == ""){
                Console.WriteLine("Please input something!");
                Console.WriteLine("");
                BuyItems(money);
            }

            //Check to see if the user inputted 10, 15, or 20 or if they want to exit
            if(lemonAmount != "1" && lemonAmount != "2" && lemonAmount != "3" && lemonAmount != "4"){
                Console.WriteLine("Please input a valid option!");
                Console.WriteLine("");
                BuyItems(money);
            }

            //Parse string to int
            lemons = Int32.Parse(lemonAmount);

            //Verify the person has enough money
            if(lemons == 1){
                if(money > 2){
                    money = money - 2;
                    totalLemons += 10;
                    Console.WriteLine("You have successfully bought 10 lemons");
                    Console.WriteLine("You have $" + money + " left");
                    Console.WriteLine("You have " + totalLemons + " lemons");
                    Console.WriteLine("");
                    BuyItems(money);
                } else {
                    Console.WriteLine("We're sorry, you don't have enough");
                    Console.WriteLine("You only have " + money);
                    BuyItems(money);
                }
            } else if (lemons == 2){
                if(money > 5){
                    money = money - 5;
                    totalLemons += 50;
                    Console.WriteLine("You have successfully bought 50 lemons");
                    Console.WriteLine("You have $" + money + " left");
                    Console.WriteLine("You have " + totalLemons + " lemons");
                    Console.WriteLine("");
                    BuyItems(money);
                } else {
                    Console.WriteLine("We're sorry, you don't have enough");
                    Console.WriteLine("You only have " + money);
                    BuyLemons();
                }
            } else if (lemons == 3){
                if (money > 8){
                    money = money - 8;
                    totalLemons += 100;
                    Console.WriteLine("You have successfully bought 100 lemons");
                    Console.WriteLine("You have $" + money + " left");
                    Console.WriteLine("You have " + totalLemons + " lemons");
                    Console.WriteLine("");
                    BuyItems(money);
                } else {
                    Console.WriteLine("We're sorry, you don't have enough");
                    Console.WriteLine("You only have " + money);
                    BuyItems(money);
                }
            } else if (lemons == 4){
                BuyItems(money);
            }
        }

        //Buy sugar
        public void BuySugar(){
            Console.WriteLine("How much sugar would you like to buy?");
            Console.WriteLine("1. 15 for $1");
            Console.WriteLine("2. 75 for $3");
            Console.WriteLine("3. 150 for $5");
            Console.WriteLine("4. Exit");
            sugarAmount = Console.ReadLine();

            //Checks to see if the user inputted anything
            if (sugarAmount == ""){
                Console.WriteLine("Please input something!");
                Console.WriteLine("");
                BuyItems(money);
            }

            //Check to see if the user inputted 10, 15, or 20
            if (sugarAmount != "1" && sugarAmount != "2" && sugarAmount != "3" && sugarAmount != "4"){
                Console.WriteLine("Please input a valid option!");
                Console.WriteLine("");
                BuyItems(money);
            }

            //Parse string to int
            sugar = Int32.Parse(sugarAmount);

            //Verify the person has enough money
            if (sugar == 1){
                if (money > 1){
                    money = money - 1;
                    totalSugar += 15;
                    Console.WriteLine("You have successfully bought 15 sugar");
                    Console.WriteLine("You have $" + money + " left");
                    Console.WriteLine("You have " + totalSugar + " sugar");
                    Console.WriteLine("");
                    BuyItems(money);
                } else {
                    Console.WriteLine("We're sorry, you don't have enough");
                    Console.WriteLine("You only have " + money);
                    BuyItems(money);
                }
            } else if (sugar == 2) {
                if (money > 3){
                    money = money - 3;
                    totalSugar += 75;
                    Console.WriteLine("You have successfully bought 75 sugar");
                    Console.WriteLine("You have $" + money + " left");
                    Console.WriteLine("You have " + totalSugar + " sugar");
                    Console.WriteLine("");
                    BuyItems(money);
                } else {
                    Console.WriteLine("We're sorry, you don't have enough");
                    Console.WriteLine("You only have " + money);
                    BuyItems(money);
                }
            } else if (sugar == 3) {
                if (money > 5){
                    money = money - 5;
                    totalSugar += 150;
                    Console.WriteLine("You have successfully bought 150 sugar");
                    Console.WriteLine("You have $" + money + " left");
                    Console.WriteLine("You have " + totalSugar + " sugar");
                    Console.WriteLine("");
                    BuyItems(money);
                } else {
                    Console.WriteLine("We're sorry, you don't have enough");
                    Console.WriteLine("You only have " + money);
                    BuySugar();
                }
            } else if (sugar == 4){
                BuyItems(money);
            }
        }

        //Buy ice
        public void BuyIce(){
            Console.WriteLine("How much ice would you like to buy?");
            Console.WriteLine("1. 100 for $2");
            Console.WriteLine("2. 250 for $5");
            Console.WriteLine("3. 500 for $8");
            Console.WriteLine("4. Exit");
            iceAmount = Console.ReadLine();

            //Checks to see if the user inputted anything
            if (iceAmount == ""){
                Console.WriteLine("Please input something!");
                Console.WriteLine("");
                BuyItems(money);
            }

            //Check to see if the user inputted 50, 250, or 500
            if (iceAmount != "1" && iceAmount != "2" && iceAmount != "3" && iceAmount != "4"){
                Console.WriteLine("Please input a valid option!");
                Console.WriteLine("");
                BuyItems(money);
            }

            //Parse string to int
            ice = Int32.Parse(iceAmount);

            //Verify the person has enough money
            if (ice == 1){
                if (money > 2){
                    money = money - 2;
                    totalIce += 100;
                    Console.WriteLine("You have successfully bought 100 ice");
                    Console.WriteLine("You have $" + money + " left");
                    Console.WriteLine("You have " + totalIce + " ice");
                    BuyItems(money);
                } else {
                    Console.WriteLine("We're sorry, you don't have enough");
                    Console.WriteLine("You only have " + money);
                    BuyItems(money);
                }
            } else if (ice == 2) {
                if (money > 5){
                    money = money - 5;
                    totalIce += 250;
                    Console.WriteLine("You have successfully bought 250 ice");
                    Console.WriteLine("You have $" + money + " left");
                    Console.WriteLine("You have " + totalIce + " ice");
                    Console.WriteLine("");
                    BuyItems(money);
                } else {
                    Console.WriteLine("We're sorry, you don't have enough");
                    Console.WriteLine("You only have " + money);
                    BuyItems(money);
                }
            } else if (ice == 3) {
                if (money > 8){
                    money = money - 8;
                    totalIce += 500;
                    Console.WriteLine("You have successfully bought 500 ice");
                    Console.WriteLine("Your have $" + money + " left");
                    Console.WriteLine("You have " + totalIce + " ice");
                    Console.WriteLine("");
                    BuyItems(money);
                } else {
                    Console.WriteLine("We're sorry, you don't have enough");
                    Console.WriteLine("You only have " + money);
                    BuyItems(money);
                }
            } else if (ice == 4){
                BuyItems(money);
            }
        }

        //Buy cups
        public void BuyCups(){
            Console.WriteLine("How many cups would you like to buy?");
            Console.WriteLine("1. 25 for $3");
            Console.WriteLine("2. 50 for $4");
            Console.WriteLine("3. 100 for $5");
            Console.WriteLine("4. Exit");
            cupsAmount = Console.ReadLine();

            //Checks to see if the user inputted anything
            if (cupsAmount == ""){
                Console.WriteLine("Please input something!");
                Console.WriteLine("");
                BuyItems(money);
            }

            //Check to see if the user inputted 50, 250, or 500
            if (cupsAmount != "1" && cupsAmount != "2" && cupsAmount != "3" && cupsAmount != "4"){
                Console.WriteLine("Please input a valid option!");
                Console.WriteLine("");
                BuyItems(money);
            }

            //Parse string to int
            cups = Int32.Parse(cupsAmount);

            //Verify the person has enough money
            if (cups == 1){
                if (money > 3){
                    money = money - 3;
                    totalCups += 25;
                    Console.WriteLine("You have successfully bought 25 cups");
                    Console.WriteLine("You have $" + money + " left");
                    Console.WriteLine("You have " + totalCups + " cups");
                    Console.WriteLine("");
                    BuyItems(money);
                } else {
                    Console.WriteLine("We're sorry, you don't have enough");
                    Console.WriteLine("You only have " + money);
                    BuyItems(money);
                }
            } else if (cups == 2) {
                if (money > 4) {
                    money = money - 4;
                    totalCups += 50;
                    Console.WriteLine("You have successfully bought 50 cups");
                    Console.WriteLine("Your have $" + money + " left");
                    Console.WriteLine("You have " + totalCups + " cups");
                    Console.WriteLine("");
                    BuyItems(money);
                } else {
                    Console.WriteLine("We're sorry, you don't have enough");
                    Console.WriteLine("You only have " + money);
                    BuyItems(money);
                }
            } else if (cups == 3) {
                if (money > 5) {
                    money = money - 5;
                    totalCups += 100;
                    Console.WriteLine("You have successfully bought 100 cups");
                    Console.WriteLine("Your have $" + money + " left");
                    Console.WriteLine("You have " + totalCups + " cups");
                    Console.WriteLine("");
                    BuyItems(money);
                } else {
                    Console.WriteLine("We're sorry, you don't have enough");
                    Console.WriteLine("You only have " + money);
                    BuyItems(money);
                }
            } else if (cups == 4){
                BuyItems(money);
            }
        }
    }
}