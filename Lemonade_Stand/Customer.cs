using System;
using System.Collections.Generic;

namespace Lemonade_Stand{
    public class Customer{
        public int customerDemand;
        public string customers;

        public void CustomerGenerator(){
            //List of names and demand
            List<string> customerNames = new List<string>();
            List<int> demand = new List<int>();
            Random rng = new Random();

            //Add list of names
            customerNames.Add("James");
            customerNames.Add("David");
            customerNames.Add("Connor");
            customerNames.Add("Alex");
            customerNames.Add("Hannah");
            customerNames.Add("Jared");
            customerNames.Add("Ralph");
            customerNames.Add("Shawn");
            customerNames.Add("Alan");
            customerNames.Add("Lauren");
            customerNames.Add("Jim");
            customerNames.Add("John");
            customerNames.Add("Lisa");
            customerNames.Add("Paul");
            customerNames.Add("Michael");
            customerNames.Add("Adam");
            customerNames.Add("Patrick");
            customerNames.Add("Carrie");
            customerNames.Add("Megan");
            customerNames.Add("Peter");

            //Loop through the demand list
            for (int i = 0; i < 20; i++){
                demand.Add(rng.Next(1, 50));
            }

            //Print every name in the list
            //for (int i = 0; i < customerNames.Count; i++){
            //    Console.WriteLine(customerNames[i]);
            //}

            customers = string.Join(", ", customerNames.ToArray());
            Console.WriteLine("Your customers are " + customers);

            //Print out the random numbers in the list
            //for (int i = 0; i < demand.Count; i++){
            //    Console.WriteLine(demand[i]);
            //}
        }
    }
}