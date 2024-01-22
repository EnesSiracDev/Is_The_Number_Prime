using System;

namespace IsTheNumberPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IsItPrime = 1;
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 2)
            {
                Console.WriteLine("This number is not prime");
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        IsItPrime++;
                        break;
                    }
                }

                if (IsItPrime == 1)
                {
                    Console.WriteLine("This number is prime");
                }
                else
                {
                    Console.WriteLine("This number is not prime");
                }
            }
        }
    }
}
