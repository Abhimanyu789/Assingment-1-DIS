using System;

namespace Star_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            //Taking input from user
            Console.WriteLine("Q1 : Enter the number of rows for the traingle:");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            for (x = 1; x <= n; x++)
            {
                for (y = x; y < n; y++)
                {
                    Console.Write(" ");
                }
                for (z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
