using System;
using System.Linq;
using System.Threading.Channels;

namespace Telephony
{
    public class Smartphone : ICalling, IBrowsing
    {
        public void Call(string number)
        {
            bool isInvalid = false;
            for (int i = 0; i < number.Length; i++)
            {
                if (!char.IsDigit(number[i]))
                {
                    isInvalid = true;
                    Console.WriteLine("Invalid number!");
                    break;
                }
            }

            if (!isInvalid)
            {
                Console.WriteLine($"Calling... {number}");
            }
        }

        public void Browsing(string website)
        {
            bool isInvalid = false;
            for (int i = 0; i < website.Length; i++)
            {
                if (char.IsDigit(website[i]))
                {
                    isInvalid = true;
                    Console.WriteLine("Invalid URL!");
                    break;
                }
            }

            if (!isInvalid)
            {
                Console.WriteLine($"Browsing: {website}!");
            }
            
        }
    }
}
