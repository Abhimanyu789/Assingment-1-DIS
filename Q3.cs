using System;

namespace Sum_of_squares_Q3
{
    class Program
    {
       private static bool SquareSums(int C)
        {
            for (long i = 1; i * i <= C; i++)
                for (long j = 1; j * j <= C; j++)
                    if (i * i + j * j == C)
                    {
                        Console.Write(i + "^2 + "
                                        + j + "^2");
                        return true;
                    }
            return false;
        }

        // Driver Code 
        public static void Main(String[] args)
        {
            Console.WriteLine("Q3 : Enter the number to check if squareSums exist: ");
            string input = Console.ReadLine();
            int C = Convert.ToInt32(input);

            
            if (SquareSums(C))
                Console.Write("\nYes,the number can be expressed as a sum of squares of 2 integers");
            else
                Console.Write("\nNo,the number cannot be expressed as a sum of squares of 2 integers");
        }
    }
}
    

