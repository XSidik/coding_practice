using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Move_Zeroes
{
	public class Program
	{
		public static void Main(string[] args)
		{
            // Given an array nums, move all 0's to the end while maintaining the relative order of non-zero elements. Do it in-place.
            int[] nums = {0,1,2,3,4,0,5,0,6,0,8,0,9};
            int[] newNums = new int[0];
            int totalZero = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    totalZero += 1;
                }
                else
                {
                    newNums = newNums.Append(nums[i]).ToArray();
                }
            }

            for(int i = 0; i < totalZero; i++)
            {
                newNums = newNums.Append(0).ToArray();
            }

            for(int i = 0; i < newNums.Length; i++)
            {
                Console.Write(newNums[i]);
                if(i < newNums.Length - 1)
                {
                     Console.Write(",");
                }
            }

            Console.WriteLine();
        }
    }
}
