using System;

namespace Telephony
{
    public class StationaryPhone : ICalling
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
                Console.WriteLine($"Dialing... {number}");
            }
            
        }
    }
}
