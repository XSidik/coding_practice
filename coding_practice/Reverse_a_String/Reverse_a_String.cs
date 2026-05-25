using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Reverse_a_String
{
	public class Program
	{
		public static void Main(string[] args)
		{
            // Reverse a String (in-place if array) or Reverse Words in a String.
            string word = "nursidik";
            string reversedWord = "";

            for(int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord = reversedWord + word[i];
            }

            Console.WriteLine(reversedWord);
        }
    }
}
