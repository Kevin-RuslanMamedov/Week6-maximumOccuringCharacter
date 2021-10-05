using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "hello world!";
            
            int counter = 0;

            foreach (char character in helloworld)
            {
                counter = counter + 1;
            }
            Console.WriteLine($"{helloworld} on {counter} sümbolit pikk.");





        }
    }
}
