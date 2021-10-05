using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Mis on sinu nimi?");
            string firstName = Console.ReadLine();

            Console.WriteLine("Mis on sinu perekonna nimi?");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();

            int counter = 0;

            foreach(char character in fullName)
            {
                if (character == 'a')
                {
                    counter++;
                }
            }

            Console.WriteLine($"Sinu nimes on {counter} a-tähte");*/

            Console.WriteLine("Mis on sinu nimi?");
            string firstName = Console.ReadLine();

            Console.WriteLine("Mis on sinu perekonna nimi?");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();

            int counter = 0; 

            for(int i = 0; i < fullName.Length; i++)
            {
                if(fullName[i] == 'a')
                {
                    counter++;
                }
            }
            Console.WriteLine($"Sinu nimes on {counter} a-tähte");
        }
    }
}
