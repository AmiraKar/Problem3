using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace Problem3



{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            int numOfRows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numOfRows; i++)
            {
                for (int a = i; a <= numOfRows; a++)
                {
                    Console.Write(" ");
                }
                for (int b = 1; b <= i; b++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }

}