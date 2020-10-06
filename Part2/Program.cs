using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter price of item(from 25 cents to a dollar, in 5 - cent increments): ");

            int price = Int32.Parse(Console.ReadLine());
            int extra = 100 - price;

            int quartersReturned = extra / 25;
            extra -= quartersReturned * 25;

            int dimesReturned = extra / 10;
            extra -= dimesReturned * 10;

            int nicklesReturned = extra / 5;

            Console.WriteLine($"You bought an item for ${price / 100.0} and gave me a dollar.");
            Console.WriteLine($"Your change is:");
            Console.WriteLine($"{quartersReturned} quarters, {dimesReturned} dimes, and {nicklesReturned} nickles.");
        }
    }
}
