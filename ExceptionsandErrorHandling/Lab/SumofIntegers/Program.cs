using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            try
            {
                string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                

                foreach (var number in numbers)
                {
                    
                    if (int.Parse(number).GetType() == typeof(Int64))
                    {
                        if (int.Parse(number) >= int.MinValue && int.Parse(number) <= int.MaxValue)
                        {
                            sum += int.Parse(number);
                            Console.WriteLine($"Element '{number}' processed - current sum: {sum}");

                        }
                        else
                        {
                            throw new OverflowException($"The element '{number}' is out of range!");
                        }
                    }
                    else
                    {
                        throw new FormatException($"The element '{number}' is in wrong format!");
                    }
                }
            }
            catch (OverflowException overflowException)
            {
                Console.WriteLine(overflowException.Message);
            }
            catch (FormatException formatException)
            {
                Console.WriteLine(formatException.Message);
            }
            finally
            {
                Console.WriteLine($"The total sum of all integers is: {sum}");
            }
        }
    }
}
