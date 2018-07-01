using System;

namespace Lemonade_Stand{
    public class Time{
        public string userTimeChosen;
        public int userTime = 0;

        //Allows user to pick a time
        public void ChooseTime(){
            Console.WriteLine("");
            Console.WriteLine("How many days would you like to play?");
            Console.WriteLine("You can select 7, 14, or 30 days to play.");
            userTimeChosen = Console.ReadLine();

            //Validation
            if(userTimeChosen == ""){
                Console.WriteLine("\n" + "You need to input a number");
                    ChooseTime();
            } else if(userTimeChosen != "7" && userTimeChosen != "14" && userTimeChosen != "30" && userTimeChosen != ""){
                Console.WriteLine("\n" + "Please enter a valid number");
                ChooseTime();  
            } else {
                userTime = Int32.Parse(userTimeChosen);
            }
        }
    }
}
