using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string commands = Console.ReadLine();
            List<string> idsList = new List<string>();

            while (commands != "End")
            {
                string[] tokens = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 2)
                {
                    string model = tokens[0];
                    string idRobot = tokens[1];
                    Robot robot = new Robot(model, idRobot);
                    idsList.Add(idRobot);
                }
                else
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string id = tokens[2];
                    Citizen citizen = new Citizen(name, age, id);
                    idsList.Add(id);
                }
                commands = Console.ReadLine();
            }

            string idForDetain = Console.ReadLine();

            foreach (var id in idsList)
            {
                if (id.EndsWith(idForDetain))
                {
                    Console.WriteLine(id);
                }
            }
        }
    }
}
