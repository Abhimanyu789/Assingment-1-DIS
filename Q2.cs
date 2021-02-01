using System;

namespace Pell_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Q2 : Enter the number of terms in the Pell Series : ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = 2*n2 + n1;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            

        }
       
    }
}
