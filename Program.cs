// Created a Console App (.Net Core) for a promotion engine

using System;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;
            int D;
            int total;

            Console.WriteLine("How many quantities for product A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many quantities for product B: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many quantities for product C: ");
            C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many quantities for product D: ");
            D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press any key to apply promotion...");
            Console.ReadKey(true);
            // Applying promotion for product A
            int quotient = A / 3;
            int remainder = A % 3;
            total = 130 * quotient + 50 * remainder;
            // Applying promotion for product B
            quotient = B / 2;
            remainder = B % 2;
            total = total + 45 * quotient + 30 * remainder;
            // Applying promotion for products C + D
            int difference = Math.Abs(C - D);
            if (C < D) { total = total + 30 * C + 15 * difference; }
            else { total = total + 30 * D + 20 * difference; }
            Console.WriteLine("Total: {0}", total);
            Console.ReadKey(true);
        }
    }
}
