using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "Hello World!";
            string partToLookfor = "hello";

            bool isThere;

            isThere = helloworld.ToLower().Contains(partToLookfor);

            if(isThere)

            {
                Console.WriteLine($"Leidsin {partToLookfor} üles!");
            }
            else
            {
                Console.WriteLine($"Ei leidnud {partToLookfor} üles!");
            }



        }
    }
}
