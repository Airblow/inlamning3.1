using System;
namespace inlamning3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            short age = short.Parse(Console.ReadLine());

            if (age >= 16 && age <= 19)
                Console.WriteLine("Du får delta i tävlingen!");

            else
                Console.WriteLine("Du är inte i rätt ålder för tävlingen");

            Console.ReadKey();

        }

    }

}
