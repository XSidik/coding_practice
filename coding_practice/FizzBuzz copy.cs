using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
            // Print numbers from 1 to n. For multiples of 3 print "Fizz", of 5 print "Buzz", both print "FizzBuzz".

            int input = 100;
            for(int i = 1; i <= input; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " FizzBuzz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine(i + " Buzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine(i + " Fizz");
                }

            }

        }
    }
}
