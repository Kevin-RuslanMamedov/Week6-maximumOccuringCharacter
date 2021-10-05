using System;

namespace SubstituteCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda nimi");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta enda perekonna nimi");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    fullName[i] = '*';
                }
            }




        }
    }
}
