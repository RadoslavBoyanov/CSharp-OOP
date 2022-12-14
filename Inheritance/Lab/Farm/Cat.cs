using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace Farm
{
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("meowing…");
        }
    }
}
