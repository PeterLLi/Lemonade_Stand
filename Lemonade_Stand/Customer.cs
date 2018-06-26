using System;
using System.Collections.Generic;

namespace Lemonade_Stand
{
    public class Customer
    {
        public int customerDemand;

        public void CustomerGenerator()
        {
            List<string> customerNames = new List<string>();

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

            Random rng = new Random();
            customerDemand = rng.Next(1, 50);

            for (int i = 0; i < customerNames.Count; i++){
                Console.WriteLine(customerNames[i]);
            }
        }
    }
}
