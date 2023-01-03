using System;
using System.Threading.Channels;

namespace _01ClassBoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Box box = new Box(length, width, height);
                Console.WriteLine(box);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
