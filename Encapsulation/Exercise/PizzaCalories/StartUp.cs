using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> command = Console.ReadLine().Split(" ").ToList();
                Pizza currentPizza = new Pizza(command[1]);
                command = Console.ReadLine().Split(" ").ToList();
                Dough currentDough = new Dough(command[1], command[2], int.Parse(command[3]));

                currentPizza.dough = currentDough;

                while (true)
                {
                    command = Console.ReadLine().Split(" ").ToList();

                    if (command[0].ToUpper() == "END")
                    {
                        break;
                    }

                    Topping currentTopping = new Topping(command[1], int.Parse(command[2]));

                    currentPizza.AddTopping(currentTopping);
                }

                Console.WriteLine($"{currentPizza.Name} - {currentPizza.TotalCalories():F2} Calories.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
