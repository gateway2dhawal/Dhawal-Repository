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
            int quot = A / 3;
            int rem = A % 3;
            total = 130 * quot + 50 * rem;
            // Applying promotion for product B
            quot = B / 2;
            rem = B % 2;
            total = total + 45 * quot + 30 * rem;
                // Applying promotion for products C + D
                int diff = Math.Abs(C - D);
                if (C < D) { total = total + 30 * C + 15 * diff; }
                else { total = total + 30 * D + 20 * diff; }
            Console.WriteLine("Total: {0}", total);
            Console.ReadKey(true);
        }
    }
}
