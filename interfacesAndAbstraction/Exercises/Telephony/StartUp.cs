using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] pfoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] websites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var number in pfoneNumbers)
            {
                if (number.Length == 7)
                {
                    StationaryPhone stationaryPhone = new StationaryPhone();
                    stationaryPhone.Call(number);
                }
                else
                {
                    Smartphone phone = new Smartphone();
                    phone.Call(number);
                }
            }

            foreach (var website in websites)
            {
                Smartphone smartphone = new Smartphone();
                smartphone.Browsing(website);
            }
        }
    }
}
