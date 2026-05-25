// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text.RegularExpressions;

// namespace HelloWorld
// {
// 	public class Program
// 	{
// 		public static void Main(string[] args)
// 		{
//             // Given an array prices where prices[i] is the price on day i, find the maximum profit you can achieve (you can only buy and sell once).
//             int[] prices = {7,1,5,3,6,4};
//             int maxProfit = 0;
//             for(int i = 0; i < prices.Length; i++){
//                 for(int j = i + 1; j < prices.Length; j++){
//                     if (prices[j] > prices[i]) {
//                         int profit = prices[j] - prices[i];
//                         if (profit > maxProfit) {
//                             maxProfit = profit;
//                         }
//                     }
//                 }
//             }

//             Console.WriteLine(maxProfit);
//         }
//     }
// }