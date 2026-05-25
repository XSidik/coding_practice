using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Contains_Duplicate
{
	public class Program
	{
		public static void Main(string[] args)
		{
            // Given an integer array nums, return true if any value appears at least twice.
            int[] nums = {1,2,3,4};

            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i +1; j < nums.Length; j++)
                {
                  if (nums[i] == nums[j])
                  {
                    Console.WriteLine(true);
                    return;
                  }
                }
            }

            Console.WriteLine(false);

        }
    }
}