using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text.RegularExpressions;

namespace Test1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // test 1
            // menghitung jumlah total dari 3 nilai teratas,
            int[] input = [1,2,3,4,5,6,4,1];
            int total = 0;

            for(int i = input.Length - 1; i >= input.Length - 3; i--)
            {
                total += input[i];
            }

            Console.WriteLine(total);
            Console.WriteLine();

            // test 2
            int[] input2 = {2,4,6,5,3,1,7,9,10,8};
            int[] newInput2 = {};

            for(int i = 0; i < input2.Length - 1; i++)
            {
                for(int j = 0; j < input2.Length - 1 - i; j++)
                {
                if(input2[j] > input2[j + 1])
                {
                    int temp = input2[j];
                    input2[j] = input2[j + 1];
                    input2[j + 1] = temp;
                }
                }
            }

            for(int i = 0; i < input2.Length; i++)
            {
                if(input2[i] % 2 == 0)
                {
                newInput2 = newInput2.Append(input2[i]).ToArray();
                }
            }

            for(int i = 0; i < newInput2.Length; i++)
            {
                for(int j = 0; j < newInput2.Length - i; j++)
                {
                    Console.Write(newInput2[j]);
                    if(j != newInput2.Length - 1 - i )
                    {
                        Console.Write(",");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // test 3
            int input3 = 10;
            int totalPrima = 0;
            int start = 2;

            while(totalPrima < input3)
            {
                if(IsPrima(start))
                {
                    Console.Write(start + ",");
                    totalPrima++;
                }

                start++;
            }

            Console.WriteLine();

        }

        private static bool IsPrima(int n)
        {
            if(n == 2 || n == 3)
            {
                return true;
            }

            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
