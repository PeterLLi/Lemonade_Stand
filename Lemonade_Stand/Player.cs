using System;

namespace Lemonade_Stand{
    public class Player
    {
        public string playerName;
        public string recipe;
        public string priceInput;
        public int price;

        public void PlayerInfo(){
            if(playerName == null){
                Console.WriteLine("What is your name?");
                playerName = Console.ReadLine();
                PlayerInfo();
            } else {
                Recipe();
            }
        }

        public void Recipe(){
            
        }

        public void Price(){
            bool valid = false;
            Console.WriteLine("What price would you like to set your lemonade at? (Between 5 and 95 cents)");
            priceInput = Console.ReadLine();

            if(priceInput == ""){
                Console.WriteLine("Please input something!");
                Price();
            }
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

        public void Profits(){
            
        }
    }
}
