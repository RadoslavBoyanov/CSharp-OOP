using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> yearsOfCitizenAndPets = new List<string>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "Pet")
                {
                    Pet pet = new Pet(tokens[1], tokens[2]);
                    yearsOfCitizenAndPets.Add(tokens[2]);
                }
                else if (tokens[0] == "Citizen")
                {
                    Citizen citizen = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
                    yearsOfCitizenAndPets.Add(tokens[4]);
                }
                else if (tokens[0] == "Robot")
                {
                    Robot robot = new Robot(tokens[1], tokens[2]);
                }

                command = Console.ReadLine();
            }

            string year = Console.ReadLine();

            foreach (var yearsOfCitizenAndPet in yearsOfCitizenAndPets)
            {
                if (yearsOfCitizenAndPet.Contains(year))
                {
                    Console.WriteLine(yearsOfCitizenAndPet);
                }
            }
        }
    }
}
