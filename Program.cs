using System;
using System.Collections.Generic;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {

            BlackCoffee blackCoffee = new BlackCoffee();
            Cortado cortado = new Cortado();
            Latte latte = new Latte();

            List<Coffee> coffeeList = new List<Coffee>();

            System.Console.WriteLine(blackCoffee);
            Console.WriteLine(cortado);
            Console.WriteLine(latte);
            

            foreach (var kaffe in coffeeList)
            {
                System.Console.WriteLine(kaffe.ToString());
            }

        }
    }
}
