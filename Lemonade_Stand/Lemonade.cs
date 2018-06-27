using System;

namespace Lemonade_Stand{
    class MainClass{
        public static void Main(string[] args){
            Game game = new Game();
            Time time = new Time();



            do{
                game.PlayGame();
                if(game.userMenuChoice == 1){
                    time.ChooseTime();
                }
            }while (game.userMenuChoice != 3);
        }
    }
}
